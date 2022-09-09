// Задача 24: Напишите программу, которая принимает на вход число (А) и
//  выдаёт сумму чисел от 1 до А.

Console.Write("Input any number: ");
int max = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = 1; i <= max; i++) // 1 2 3 4 5 
    sum = sum + i;
Console.WriteLine(sum);


// Console.Write("Input any number: ");
// int n = int.Parse(Console.ReadLine()!);

// while (n > 0) {
//     int digit = n % 10; // достать последнюю цифру
//     Console.WriteLine(digit);
//     n = n / 10; //оставить все, кроме последней цифры
// }