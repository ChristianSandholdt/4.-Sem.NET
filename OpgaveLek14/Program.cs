using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveLek14
{
    internal class Program
    {
        static eksempeldbEntities1 DB;
        static void Main(string[] args)
        {
            DB = new eksempeldbEntities1();
            //insertPerson();
            //deletePerson();
            //updatePerson();
            //printPeople();
            //printPeopleDetailed();
            //changePostalNumberUno();
            //changePostalNumberDos();
            changePostalNumberTres();
            Console.ReadLine();
        }


        // Opgave 1
        public static void insertPerson()
        {
            person p = new person();
            p.cpr = "2020202020";
            p.loen = 200000;
            p.navn = "James";
            p.postnr = "8000";
            p.stilling = "Midfielder";
            DB.people.Add(p);
            DB.SaveChanges();
            Console.ReadLine();
        }
        public static void deletePerson()
        {
            DB.people.Remove((from p in DB.people
                              where p.cpr == "1919191919"
                              select p).First());
            DB.SaveChanges();

        }

        public static void updatePerson()
        {
            string cpr = Console.ReadLine();
            person pers = (from p in DB.people where p.cpr == cpr select p).First();
            pers.loen = 150;
            DB.SaveChanges();
        }
        public static void printPeople()
        {
            foreach (var person in from p in DB.people select p)
            {
                Console.WriteLine(person.navn + " " + person.cpr);
            }
        }

        public static void printPeopleDetailed()
        {
            Console.WriteLine("Lavet på SQL måde");
            var tSQL = from p in DB.people
                    from pd in DB.postnummers
                    where p.postnr == pd.postnr
                    select new { p.navn, p.cpr, pd.postdistrikt };
            foreach (var x in tSQL)
                Console.WriteLine(x.navn + ", " + x.cpr + ", " + x.postdistrikt);
            Console.WriteLine("Lavet med navigation properties");
            Console.WriteLine();
            var t = from post in DB.postnummers
                    from p in post.people
                    select new { p.navn , p.cpr, post.postdistrikt };
            foreach (var p in t) 
            {
                Console.WriteLine(p.navn + " " + p.cpr + " " + p.postdistrikt);
            }
        }
        public static void changePostalNumberUno()
        {
            Console.WriteLine("Enter cpr..");
            string cpr = Console.ReadLine();
            person pers = (from p in DB.people where p.cpr == cpr select p).First();
            Console.WriteLine("Enter new postal for " + cpr);
            string newPostal = Console.ReadLine();
            pers.postnr = newPostal;
            DB.SaveChanges();
        }

        public static void changePostalNumberDos()
        {
            Console.WriteLine("Enter cpr..");
            string cpr = Console.ReadLine();
            Console.WriteLine("Enter new postal for " + cpr);
            string newPostal = Console.ReadLine();

            postnummer p = (from pn in DB.postnummers where pn.postnr == newPostal select pn).First();
            person pers = (from pe in DB.people where pe.cpr == cpr select pe).First();

            pers.postnummer = p;
            DB.SaveChanges();
        }

        public static void changePostalNumberTres()
        {
            Console.WriteLine("Enter cpr..");
            string cpr = Console.ReadLine();
            person pers = (from p in DB.people where p.cpr == cpr select p).First();
            Console.WriteLine("Enter new postal for " + cpr);
            string newPostal = Console.ReadLine();
            try
            {
                pers.postnr = newPostal;
                DB.SaveChanges();
            } catch
            {
                Console.WriteLine("Error, zip does not exist");
                DB.Entry(pers).Reload(); //Sørger for at error ikke bliver kastet for nummer 2 indtastning hvis nummer 1 er forkert
            }


            Console.WriteLine("Enter cpr..");
            string cpr2 = Console.ReadLine();
            person pers2 = (from p in DB.people where p.cpr == cpr2 select p).First();
            Console.WriteLine("Enter new postal for " + cpr2);
            string newPostal2 = Console.ReadLine();
            try
            {
                pers2.postnr = newPostal2;
                DB.SaveChanges();
            }
            catch
            {
                Console.WriteLine("Error, zip does not exist");
            }
        }

    }
}
