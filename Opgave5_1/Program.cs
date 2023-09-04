using System.Linq;
using System.Threading.Channels;

var data = new List<int> {1,71,3,42,5,62 };

//var predicate = new Predicate<int>()


var filteredList = data.FindAll(x => x % 2 == 0);
Console.WriteLine("Predicate");
Console.WriteLine("Med print i lambda");
filteredList.ForEach(i => Console.WriteLine(i));

Console.WriteLine("Med print i foreach");
foreach (var item in filteredList)
{
    Console.WriteLine(item);
}
Console.WriteLine("Linq");
IEnumerable<int> result = data.FindAll(x =>x % 2 == 0);
Console.WriteLine("Lige tal");
foreach (var item in result)
{
    Console.WriteLine(item);
}

result = data.Where(d => d.ToString().Length == 2);

Console.WriteLine("Numbers with 2 digits");
foreach (var item in result) {  Console.WriteLine(item); }

result = result.OrderBy(d => d);
Console.WriteLine("Sorted ascending");
foreach (var item in result) { Console.WriteLine(item); }

