using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    internal class Person
    {
        public String name;
        private DateTime birthday;

        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }


        public static void calcAge(DateTime birthdayInput, out int age)
        {
            DateTime now = DateTime.Today;
            age = now.Year - birthdayInput.Year;
            if (birthdayInput.Date > now.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine(age);
        }

        private static void myMethodWithError(int num = 0)
        {
            int result = 10 / num;
        }

        public static void myNormalMethod(int num = 0)
        {
            try
            {
                myMethodWithError(num);
            } 
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Did you get the expected result?");
            }

        }



    }
}
