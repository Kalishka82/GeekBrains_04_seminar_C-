// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.

Console.Write("Input number N: ");
int number = int.Parse(Console.ReadLine()!);

int count = 0;
while (number > 0) {
    number = number / 10; //оставить все, кроме последней цифры
    count = count + 1;
}
Console.WriteLine(count);