// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void FindPalindrop (int p)
{
    string a = p.ToString();
    Console.WriteLine(a);
    char[] b = a.ToCharArray();
    char[] revers_b = a.Reverse().ToArray();
    string c =  String.Concat<char>(revers_b);
    Console.WriteLine(c);

    if(a == c)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
    FindPalindrop(12321);