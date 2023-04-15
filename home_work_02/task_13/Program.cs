// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число --> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000){
    Console.WriteLine("Третьей цифры нет!");
}  else{
    int Checking3rdDigit (int num)
    {
    int chek = num % 10;
    return chek;
    }
    Console.WriteLine($"Третья цифра заданного числа --> {Checking3rdDigit(number)}");
}



 



