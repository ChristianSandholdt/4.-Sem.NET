using Opgave4._2;


PowerPlant p1 = new PowerPlant();

p1.setWarning(warningToConsole);
p1.addWarning(warningToConsoleWithRizz);

for (int i = 0; i < 10; i++)
{
    p1.heatUp();
}
Console.ReadLine();


static void warningToConsole(int x)
{
    Console.WriteLine("Advarsel temperatur er på " + x);
}
static void warningToConsoleWithRizz(int x)
{
    Console.WriteLine("Too hot just like your mom");
}
