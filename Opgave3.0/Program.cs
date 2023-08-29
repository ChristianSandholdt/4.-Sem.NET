
using Opgave3;

Shape s1 = new Rectangle(1, 1, 4, 7);
Shape s2 = new Circle(5, 5, 5);

List<Shape> list = new List<Shape>();
list.Add(s1);
list.Add(s2);

foreach (Shape s in list)
{
    Console.WriteLine(s.ToString());
    Console.WriteLine(s.area());
}