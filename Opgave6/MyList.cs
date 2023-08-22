using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    internal class MyList
    {
        ArrayList list = new ArrayList();
 
        public MyList()
        {

        }

        public void add(int number)
        {
            list.Add(number);
        }
        public void printNumbers()
        {
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);            
            }
        }

        public void add10RandomNumbers()
        {
            for (int i = 0;i < 10; i++) {
                var random = new Random();   
                add(random.Next(11));
            }
        }
    }
}
