using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class TimeStruct
    {
        struct Time
        {
            public static DateTime now = new DateTime();

            public static int secSinceMidnight
            {
                set
                {
                    secSinceMidnight = now.TimeOfDay.Seconds;
                }
                get { return secSinceMidnight; }
            }



            //public int Hour 
            //{
            //    set
            //    {
            //        int hour = value;
            //        int temp = secSinceMidnight % 3600;
            //        secSinceMidnight = (temp + hour *3600) % maxSeconds;
            //    }
            
            //}


            public int Minutes { get; set; }
            public int Seconds { get; set; }

            static void Main(string[] args)
            {
                Console.WriteLine(secSinceMidnight);
            }
        }
    }
}
