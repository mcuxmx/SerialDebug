# SerialDebug
基于.net 2.0开发，单文件免费串口调试工具。
![serialdebug](https://raw.githubusercontent.com/mcuxmx/serialdebug/master/doc/images/serialdebug.png)
## 基本功能
- 自动识别系统串口号并显示相应的驱动名称。
- 支持常用波特率选择，也可手动输入波特率。
- 支持串口流控控制（使用时需要硬件支持）。
- 支持十六进制收发功能。
- 可一键恢复默认设置。
- 统计收发字节数。
- 支持窗体置顶功能。
- 关闭后自动保存上次设置。

## 接收区：
- 接收超时时间（分帧时间）可设置。
- 接收字节大小可设置。
- 支持接收内容自动换行功能。
- 支持显示时间戳。
- 支持文件保存，可存为二进制文件或文本文件。
- 接收区选中要转换的内容，右键菜单可选择相应的进制转换。
- 支持接收和发送时间戳显示，精确到毫秒。
![serialdebug](https://raw.githubusercontent.com/mcuxmx/serialdebug/master/doc/images/receive.png)
## 发送模式
- 支持多种发送模式：普通模式，队列模式，文件模式。

### 普通模式：
- 在发送区按键盘上下键可输入历史发送数据。
- 支持CTRL+Enter快捷键可发送。
- 十六进制下能自动识别带空格和不带空格等HEX字符串，如010203  0x01,0x02,0x03 等格式。
- HEX格式化功能，将发送区的输入内容格式化为01 02 03样式的内容。
- 发送后清空，发送区内容发送完成后自动清空发送区。
- 支持各种CRC校验。
- 支持发送区内容循环发送功能。
- 支持发送内容分包发送，每包发送字节数和发送时间间隔可设置。
![serialdebug](https://raw.githubusercontent.com/mcuxmx/serialdebug/master/doc/images/checksum.png)
### 队列模式：
- 在队列发送模式中可编辑无限个发送序列。发送可设置为延时发送或接收到数据帧后发送，方便调试某些时序数据帧。
- 发送可设置为延时发送或接收到数据帧后发送，方便调试某些时序数据帧。
- 支持添加、删除、修改、排序相应的发送序列。
- 双击发送行可进行内容修改。
- 支持设置发送内容标题。
- 支持发送序列的保存与导入功能。
![serialdebug](https://raw.githubusercontent.com/mcuxmx/serialdebug/master/doc/images/queue.png)
### 文件模式：
- ASCII文件发送，支持按行发送，支持追加换行符，控制发送间隔。
- 二进制文件发送，支持分包发送，支持控制发送时间间隔。
- 支持标准XModem，YModem传输，支持128，1024字节，自动识别CRC和CheckSum校验。








