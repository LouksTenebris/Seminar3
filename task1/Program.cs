//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Введите порядок цифр или предложение: ");
System.Console.WriteLine("5 символов");
string offer = Console.ReadLine();
int i = offer.Length;

if (i == 5)
{
    if (offer[0] == offer[4] && offer[1] == offer[3])
    {
        Console.WriteLine($"{offer} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{offer} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"{offer} - не 5 символов");
}