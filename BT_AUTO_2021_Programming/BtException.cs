using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class BtException 
    {
        string myCustomMessage;
        public BtException(string message)
        {
            this.myCustomMessage = "BT Exception :" + message;
        }

        public override string ToString()
        {
            return  myCustomMessage +base.ToString();
        }
        

    }
}
