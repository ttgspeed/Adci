using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adci
{
    class settings
    {
        private static int baudRate = 9600;
        private static string comPort = "COM1";

        public static void setbaudRate(int br)
        {
            baudRate = br;
        }
        public static void setComPort(string pr)
        {
            comPort = pr.ToUpper();
        }
        public static int getBaudRate()
        {
            return baudRate;
        }
        public static string getComPort()
        {
            return comPort;
        }
    }
}
