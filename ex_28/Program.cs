// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

Console.Write("Input any number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindProduce());

int FindProduce()
{
    int produce = 1;
    for (int i = 1; i <= number; i++)
    {
        produce = produce * i;
    }
    return produce;
}
