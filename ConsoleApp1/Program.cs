var name = "EWA";
var age = 30;
var sex = "KOBIETA";

if (age < 30 && sex == "KOBIETA")
{
    Console.WriteLine("KOBIETA PONIZEJ 30 LAT.");
}
else if (name == "EWA" && age == 30)
{
    Console.WriteLine("EWA, LAT 30");
}
else if (!(sex == "KOBIETA") && age < 18)
{
   Console.WriteLine("NIEPELNOLETNI MEZCZYZNA");
}
else 
{
    Console.WriteLine("Nie znaleziono");
}

