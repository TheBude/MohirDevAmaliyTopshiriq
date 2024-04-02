Console.Write("string kiriting: ");

string str = Console.ReadLine();

Console.Write("Soni Kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > str.Length)
{
    Console.WriteLine(str.ToUpper());
}
else
{
    Console.WriteLine(str.ToLower());
}