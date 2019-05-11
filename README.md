# SerialDebug
支持多种发送模式：普通模式，队列模式，文件模式。

普通模式：在发送模式中按键盘上下键可输入历史发送数据；支持CTRL+Enter快捷键可发送；

队列模式：在队列发送模式中可编辑无限个发送序列，发送可设置为延时发送或接收到数据帧后发送，方便调试某些时序数据帧。

文件模式：支持ASCII文件，二进制文件，XModem，YModem传输。
          ASCII文件发送支持按行发送。
          二进制文件发送支持分包发送。
          XModem、YModem支持128，1024字节，自动识别CRC和CheckSum校验。

支持各种CRC校验，串口助手也是一个CRC校验计算器。

接收区选中要转换的内容，右键菜单可选择相应的进制转换。

支持接收和发送时间戳显示。