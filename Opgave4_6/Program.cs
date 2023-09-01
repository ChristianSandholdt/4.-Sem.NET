using Opgave4_6;
using static Opgave4_6.Person;

Person p1 = new Person("Martin", 11, 48);
Person p2 = new Person("Hans", 12, 47);
Person p3 = new Person("Jens", 13, 41);
Person p4 = new Person("Ib", 14, 42);
Person p5 = new Person("Victor", 15, 43.5);
Person p6 = new Person("Anders", 13, 43.4);

List<Person> list = new List<Person>();

list.Add(p1);
list.Add(p2);
list.Add(p3);
list.Add(p4);
list.Add(p5);
list.Add(p6);

list.Sort(new ByAgeSorter());
Console.WriteLine("Sorted by age");
printList(list);

list.Sort(new ByNameSorter());
Console.WriteLine("Sorted by name");
printList(list);

list.Sort(new ByWeightSorter());
Console.WriteLine("Sorted by weight");
printList(list);





