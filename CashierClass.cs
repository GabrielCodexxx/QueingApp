using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueingApp
{
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }


        public string CashierGeneratedNumber(string CashierNumber)
        {
            if (x < 10010)
            {
                x++;
                return CashierNumber + x.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}