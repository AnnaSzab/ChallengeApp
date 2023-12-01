string name = "Ewa";
var age = 33;
string gender = "mezczyzna";
if (age < 30 && gender == "kobieta")
    Console.WriteLine("Kobieta ponizej 30 lat");
else if (age == 33 && gender == "kobieta")
    Console.WriteLine("Ewa, lat 33");
else if (age < 18 && gender == "mezczyzna")
    Console.WriteLine("Niepelnoletni mezczyzna");
else Console.WriteLine("Niewiadoma");






