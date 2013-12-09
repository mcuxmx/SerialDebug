using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace SerialDebug
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            //  初始化 AboutBox 以显示程序集信息中包含的产品信息。
            //  也可以通过以下方法更改应用程序的程序集信息设置:
            //  - 项目->属性->应用程序->程序集信息
            //  - AssemblyInfo.cs
            this.Text = String.Format("关于 {0}", AssemblyTitle);
            this.LabelProductName.Text = AssemblyProduct + String.Format("  V{0}", AssemblyVersion);
            this.LabelVersion.Text = "作者：谢明鑫";// String.Format("版本 {0}", AssemblyVersion);
            this.LabelCopyright.Text = "  QQ：516409354";//AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            this.LabelCompanyName.Text = "Mail：mcuxmx@qq.com";
            //this.textBoxDescription.Text = AssemblyDescription;

            //this.textBoxDescription.Text
        }

        #region 程序集属性访问器

        public string AssemblyTitle
        {
            get
            {
                // 获取此程序集上的所有 Title 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // 如果至少有一个 Title 属性
                if (attributes.Length > 0)
                {
                    // 请选择第一个属性
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // 如果该属性为非空字符串，则将其返回
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // 如果没有 Title 属性，或者 Title 属性为一个空字符串，则返回 .exe 的名称
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // 获取此程序集的所有 Description 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // 如果 Description 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Description 属性，则返回该属性的值
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // 获取此程序集上的所有 Product 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // 如果 Product 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Product 属性，则返回该属性的值
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // 获取此程序集上的所有 Copyright 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // 如果 Copyright 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Copyright 属性，则返回该属性的值
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // 获取此程序集上的所有 Company 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // 如果 Company 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Company 属性，则返回该属性的值
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
