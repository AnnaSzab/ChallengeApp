string name = "Ewa";
var age = 33;
bool Women = true;
if (age < 30 && Women)
    Console.WriteLine("Kobieta ponizej 30 lat");
else if (age == 33 && Women && name == "Ewa")
    Console.WriteLine("Ewa, lat 33");
else if (age < 18 && !Women)
    Console.WriteLine("Niepelnoletni mezczyzna");

else Console.WriteLine("Za malo danych");






