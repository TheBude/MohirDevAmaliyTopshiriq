//3-misol hafta kunini tarjima 
Console.WriteLine("Assalomu allaykum men hafta kunlarini ingliz tiliga tarjima qiluvchi dasturman");

Console.Write("Iltimos hafta kunini birinchi harfini katta bilan bo'lsin\nQaysi hafta kunini tarjima qilish kerak.\nKirting: ");
string weekday = Console.ReadLine();

string result = weekday switch
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
    _ => "Iltimos hafta kunini tug'ri kiriting"
};
Console.WriteLine(result);