using Opgave5_3;
using System.Collections.Generic;

List<Person> people1 = new List<Person>();
void Exercise1()
{
    try
    {
        //people1 = Person.ReadCSVFile("C:\\Users\\45416\\source\\repos\\4. Sem\\Opgave5_3\\data1.csv"); //laptop
        people1 = Person.ReadCSVFile("C:\\Users\\cks24\\source\\repos\\4.-Sem.NET\\Opgave5_3\\data1.csv"); //stationær
    }
    catch (Exception ex)
    {
        Console.WriteLine("EXCEPTION: " + ex.Message);
        Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile (method to something on your disk!");
    }
}

Exercise1();
//Console.WriteLine("Scores under 2");
//List<Person> scoreUnder2 = people1.FindAll(x => x.Score < 2);
//foreach (Person person in scoreUnder2)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine("Equal number scores");
//List<Person> equalScoreNumbers = people1.FindAll(x => x.Score % 2 == 0 && x.Weight > 60);
//foreach (Person person in equalScoreNumbers)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine("Equal score and over 60kg");
//List<Person> equalScoreNumbersAndOver60Kg = people1.FindAll(x => x.Score % 2 == 0 && x.Weight > 60);
//foreach (Person person in equalScoreNumbersAndOver60Kg)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine("Weight divisable by 3");
//List<Person> divisableByThree = people1.FindAll(x => x.Weight % 3 == 0);
//foreach (Person person in divisableByThree)
//{
//    Console.WriteLine(person);
//}

//Console.WriteLine();

//foreach (Person p in people1)
//{
//    Console.WriteLine(p);
//}

//Console.WriteLine("FindIndex opgaver");
//Console.WriteLine("Person med en score på præcis 3: " + people1.FindIndex(x => x.Score == 3));
//Console.WriteLine("Person med en score på præcis 3: " + people1.FindIndex(x => x.Score == 3 && x.Age < 10));
//Console.WriteLine("Liste af folk på listen med en alder under 10 og score på præcis 3");
//List<Person> underAgeOfTenAndScoreThree = people1.FindAll(x => x.Score == 3 && x.Age < 10);
//foreach (Person p in underAgeOfTenAndScoreThree)
//{
//    Console.WriteLine(p);
//}

//Console.WriteLine("Person med alder under 8 en score på præcis 3: " + people1.FindIndex(x => x.Score == 3 && x.Age < 8));
////Return value på ovenstående opgave er -1 da ingen i listen lever op til det.

//people1.SetAccepted(x => x.Age <= 20);
//Console.WriteLine("Personer med accepted sat til true");
//foreach(Person p in people1)
//{
//    Console.WriteLine(p);
//}


//Console.WriteLine("Order by score and age");
//List<Person> orderByScoreAndAge = people1.OrderByDescending(x => x.Score).ThenByDescending(x => x.Age).ToList();
//foreach(Person p in orderByScoreAndAge)
//{
//    Console.WriteLine(p);
//}


//Console.WriteLine("Ascnding order");
//Console.WriteLine("Order by score and age");
//List<Person> orderByScoreAndAgeAsc = people1.OrderByDescending(x => x.Score).ThenBy(x => x.Age).ToList();
//foreach (Person p in orderByScoreAndAgeAsc)
//{
//    Console.WriteLine(p);
//}

//5.8
//int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };
//IEnumerable<int> intsAscending = numbers.Where(numbers => numbers.ToString().Length == 2);
//intsAscending.OrderBy(i => i).ToList().ForEach(Console.WriteLine);

//Console.WriteLine("/////////");

//IEnumerable<int> intsDescending = numbers.Where(numbers => numbers.ToString().Length == 2);
//intsDescending.OrderByDescending(i => i).ToList().ForEach(Console.WriteLine);

//IEnumerable<String> evenOrOdd = numbers
//    .Where(i => i.ToString().Length == 2)
//    .OrderBy(i => i)
//    .Select(i => i % 2 == 0 ? i + " even" : i + " uneven");
//foreach(String s in evenOrOdd)
//{
//    Console.WriteLine(s);
//}

//5.10
Console.WriteLine("List with random ints");
Console.WriteLine();
Random random = new Random();
List<int> randomInts = new List<int>();
for (int i = 0; i < 100; i++)
{
    randomInts.Add(random.Next(1, 50));
}
Console.WriteLine("Amount of unevens in list");
int amountOfUneven = randomInts.Where(x => x % 2 == 1).Count();
Console.WriteLine(amountOfUneven);


Console.WriteLine("Amount of distinct in list");
int distinct = randomInts.Distinct().Count();
Console.WriteLine(distinct);

IEnumerable<int> list = randomInts.Where(i => i % 2 != 0).Take(3);
Console.WriteLine("Show first three unevens");
foreach (int i in list)
{
    Console.WriteLine(i);
}

IEnumerable<int> list1 = randomInts.Distinct().Where(i => i % 2 != 0);
Console.WriteLine("Show distinct uneven numbers in list");
foreach (int i in list1)
{
    Console.WriteLine(i);
}

//5.11
var groupByInitial = from person in people1 group person by person.Name[0];
foreach (var personGroup in groupByInitial)
{
    Console.WriteLine($"Key: {personGroup.Key}");
    foreach (var person in personGroup)
    {
        Console.WriteLine(person.Name);
    }        
}


