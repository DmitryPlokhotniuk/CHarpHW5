/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */




Console.WriteLine("Сколько всего чисел вы хотите ввести");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

int[] FillArray (int[] arrayNumbers, int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число:");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(String.Join(",", arrayNumbers));
    return arrayNumbers;
}

void CheckArray (int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел > 0 = {count}");
}





CheckArray(FillArray(arrayNumbers, m));
