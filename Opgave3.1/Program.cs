using Opgave3._1;

List<Medarbejder> vaerkstedet = new();

CprNr cpr1 = new CprNr("25/10/1997", "2510979737");
CprNr cpr2 = new CprNr("16/1/2000", "1601001313");
CprNr cpr3 = new CprNr("22/9/2003", "2209037765");
CprNr cpr4 = new CprNr("12/8/1995", "1208954531");
CprNr cpr5 = new CprNr("29/4/1973", "2904739797");


Medarbejder m1 = new Mekaniker(cpr1,"Mohammed Salah", "Anfield Road",2005,285);
Medarbejder m2 = new Mekaniker(cpr2,"Alisson", "Træningsanlægget", 2012, 290);
Medarbejder m3 = new Vaerkfoerer(cpr3,"Darwin", "Træningsbanen", 2011, 250, 2022, 3000);
Medarbejder m4 = new Vaerkfoerer(cpr4, "Trent", "Højre back", 2010, 270, 2020, 6000);
Medarbejder m5 = new Synsmand(cpr5,"Jürgen", "Kontoret", 2000, 400, 15);

Adresse a1 = new Adresse("Edwin Rahrs vej",10);
Adresse a2 = new Adresse("BazarVestVej", 1);

Firma f1 = new Firma("DSV", a1);
Firma f2 = new Firma("Hos Bilal", a2);


vaerkstedet.Add(m1);
vaerkstedet.Add(m2);
vaerkstedet.Add(m3);
vaerkstedet.Add(m4);
vaerkstedet.Add(m5);

Console.WriteLine("Alle medarbejdere");
foreach (var m in vaerkstedet)
{
    Console.WriteLine(m.ToString());   
}

Console.WriteLine();
Console.WriteLine("Generic");

var medarbejderCollection = new Collection<CprNr>();
medarbejderCollection.addElement(m1.Cpr, m1); //Adds Salah
medarbejderCollection.addElement(m2.Cpr, m2); // Adds Alisson
medarbejderCollection.addElement(m3.Cpr, m3); // Adds Darwin

//Printer den foreløbige størrelse på listen
Console.WriteLine(medarbejderCollection.size()); // 3

//Tilføjer en allerede eksisterende som fanges af metoden
medarbejderCollection.addElement(m1.Cpr, m1); //Adds Salah again

//Størrelsen er stadig 3
Console.WriteLine(medarbejderCollection.size()); // 3

//Tager medarbejderen med m2.Cpr og returnerer dens toString().
Console.WriteLine(medarbejderCollection.Get(m2.Cpr));

Console.WriteLine();

Console.WriteLine("Test med Firma og Medarbejdere");
var firmaMedarbejderCol = new Collection<Adresse>();
firmaMedarbejderCol.addElement(f1.Adresse, f1);
firmaMedarbejderCol.addElement(f2.Adresse, f2);
