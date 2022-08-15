// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите числа");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > count)
    {
      sum ++;
    }
}
Console.WriteLine($"Чисел больше нуля: {sum}");

