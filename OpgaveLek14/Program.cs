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
            //Linq 1
            //insertPerson();
            //deletePerson();
            //updatePerson();
            //printPeople();
            //printPeopleDetailed();
            //changePostalNumberUno();
            //changePostalNumberDos();
            //changePostalNumberTres();
            //Console.ReadLine();

            //Linq 2
            //findPersonFromSalary();
            //findPersonFromSalaryArray();
            //hirePersonToCompany();
            //findEmployedPeople();
            //CompaniesInPostNr();
            //AvgLoenPrStilling();
            findpplfunc();
            
        }


        //Linq 2
        public static void findPersonFromSalary()
        {
            Console.WriteLine("Enter salary...");
            int salary = Convert.ToInt32(Console.ReadLine());
            var pers = (from p in DB.people where p.loen > salary select p);
            foreach (var item in pers)
            {
                Console.WriteLine(item.navn + " " + item.loen);
            }
            Console.ReadLine();
        }

        public static void findPersonFromSalaryArray()
        {
            Console.WriteLine("Enter salary...");
            int salary = Convert.ToInt32(Console.ReadLine());
            person[] pers = (from p in DB.people
                             where p.loen > salary
                             select p).ToArray();
            foreach (var item in pers)
            {
                Console.WriteLine(item.navn + " " + item.loen);
            }
            Console.ReadLine();
        }

        public static void findEmployedPeople()
        {
            var employedPeople = from p in DB.people
                                 from f in p.firmas
                                 select new { p.navn, f.firmanavn};
            foreach (var item in employedPeople)
            {
                Console.WriteLine(item.navn + " " + item.firmanavn);
            }
            Console.ReadLine();
        }


        public static void hirePersonToCompany()
        {
            Console.WriteLine("Enter cpr of person to hire...");
            string cpr = Console.ReadLine();
            Console.WriteLine("Enter firmanr of company to hire person in");
            int firmanr = Convert.ToInt32(Console.ReadLine());
            var person = (from p in DB.people
                          where p.cpr == cpr
                          select p).First();
            var firma = (from f in DB.firmas
                         where f.firmanr == firmanr
                         select f).First();
            person.firmas.Add(firma);
            DB.SaveChanges();
        }

        public static void CompaniesInPostNr()
        {
            var postnummer = (from pn in DB.postnummers
                              where pn.firmas.Count > 0
                              select pn);

            foreach (var item in postnummer)
            {
                Console.WriteLine(item.postnr + " " + item.firmas.Count());
            }
            Console.ReadLine();
        }

        public static void AvgLoenPrStilling()
        {
            var loen = (from p in DB.people
                        group p by p.stilling into still
                        select new { still.Key, Average = still.Average(p => p.loen) });

            foreach (var item in loen)
            {
                Console.WriteLine(item.Key + " " + item.Average);
            }
            Console.ReadLine();
        }

        public static void findpplfunc()
        {
            person[] pers = DB.findppl1().ToArray();
            foreach (var item in pers)
            {
                Console.WriteLine(item.navn);
            }
            Console.ReadLine();
        }




        //Linq 1


        // Opgave 1
        public static void insertPerson()
        {
            person p = new person();
            p.cpr = "2121212121";
            p.loen = 100000;
            p.navn = "Thiago";
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
