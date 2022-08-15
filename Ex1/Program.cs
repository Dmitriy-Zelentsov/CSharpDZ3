// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void FindPalindrom (int p)
{
    string a = p.ToString();
    Console.WriteLine($"{a} - исходное число");
    char[] b = a.ToCharArray();
    char[] revers_b = a.Reverse().ToArray();
    string c =  String.Concat<char>(revers_b);
    Console.WriteLine($"{c} - число реверс");

    if(a == c)
    {
        Console.WriteLine("Да, палиндром");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
    FindPalindrom(12321);