using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Text;

namespace SerialDebug
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {


                //处理未捕获的异常  
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常  
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常  
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());

            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }

        }

        static void ExceptionHandler(Exception ex)
        {
           
            try
            {
                if (ex != null)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat("{0}Unhandled Exception:\r\n", DateTime.Now.ToString());
                    string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    msg.AppendFormat("Version:        {0}\r\n", Version);
                    msg.AppendFormat("Exception Type: {0}\r\n", ex.GetType().Name);
                    msg.AppendFormat("Message:        {0}\r\n", ex.Message);
                    msg.AppendFormat("StackTrace:     {0}\r\n", ex.StackTrace);


                    DialogResult dr = MessageBox.Show("An application error occurred. Please contact the author\r\nWhether to send e-mail", "system exception", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        //writeLog(msg.ToString());

                        string title = string.Format("SerialDebug V{0} exception", Version);
                        string body = msg.ToString();
                        sentEmail("516409354@qq.com", title, msg.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("An application error occurred. Please contact the author", "system exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            


        }


        static void sentEmail(string emailAddress, string Title, string Body)
        {
            string bodyContent;

            bodyContent = Body.Replace("\r", "%0d");
            bodyContent = bodyContent.Replace("\n", "%0a");
            bodyContent = bodyContent.Replace("&", "%26");
            bodyContent = bodyContent.Replace("<","%3c");
            bodyContent = bodyContent.Replace(">", "%3e");
            bodyContent = bodyContent.Replace("\"", "%22");

            string emailMsg = string.Format("mailto:{0}?subject={1}&body={2}",
                emailAddress,
                Title,
                bodyContent);
            System.Diagnostics.Process.Start(emailMsg);

        }
        /// <summary>
        ///这就是我们要在发生未处理异常时处理的方法，我这是写出错详细信息到文本，如出错后弹出一个漂亮的出错提示窗体，给大家做个参考
        ///做法很多，可以是把出错详细信息记录到文本、数据库，发送出错邮件到作者信箱或出错后重新初始化等等
        ///这就是仁者见仁智者见智，大家自己做了。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            Exception ex = e.Exception as Exception;

            ExceptionHandler(ex);

        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;

            ExceptionHandler(ex);

        }
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="str"></param>
        static void writeLog(string str)
        {
            //if (!Directory.Exists("ErrLog"))
            //{
            //    Directory.CreateDirectory("ErrLog");
            //}
            using (StreamWriter sw = new StreamWriter(@"ErrLog.txt", true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }



    }
}