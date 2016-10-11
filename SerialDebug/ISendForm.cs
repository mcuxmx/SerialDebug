using System;
using System.Collections.Generic;
using System.Text;

namespace SerialDebug
{
    public interface ISendForm
    {
        List<CSendParam> getSendList();


        int LoopCount
        {
            get;
        }
    }



}
