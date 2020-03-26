using System;
using System.Collections.Generic;
using System.Text;

namespace SerialDebug
{
    public interface ISendForm
    {
        List<CSendParam> GetSendList();


        int LoopCount
        {
            get;
        }

        bool EditEnable
        {
            get;
            set;
        }
    }



}
