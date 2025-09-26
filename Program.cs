using System;

class Program
{
    // 7.4: Вычисляет максимальное значение из cos²(a+b), sin(a+b) и a/b
    static double MaxExpression(double a, double b)
    {
        double x = Math.Pow(Math.Cos(a + b), 2);  // cos²(a+b)
        double y = Math.Sin(a + b);                // sin(a+b)
        double z = a / b;                          // a/b
        return Math.Max(x, Math.Max(y, z));        // возвращаем максимум из трёх значений
    }

    // 7.9: Подсчитывает, сколько раз число n встречается в массиве arr
    static int CountOccurrences(int[] arr, int n)
    {
        int count = 0;
        foreach (int el in arr)
            if (el == n) count++;
        return count;
    }

    // 7.10: Подсчитывает количество вхождений символа c в строку text
    static int CountChar(string text, char c)
    {
        int count = 0;
        foreach (char ch in text)
            if (ch == c) count++;
        return count;
    }

    // 7.11: Находит максимум и количество его повторений в массиве arr
    static (int maxValue, int count) MaxAndCount(int[] arr)
    {
        int max = arr[0];
        foreach (int el in arr)
            if (el > max) max = el;

        int count = 0;
        foreach (int el in arr)
            if (el == max) count++;

        return (max, count);
    }

    // 7.16: Заменяет элементы главной диагонали квадратной матрицы на 0
    static void ReplaceDiagonalWithZeros(int[,] matrix)
    {
        int n = matrix.GetLength(0);  // размер квадратной матрицы (число строк)
        for (int i = 0; i < n; i++)
            matrix[i, i] = 0;         // замена диагонального элемента на 0
    }

    // 7.17: Заменяет все отрицательные элементы матрицы на 1
    static void ReplaceNegativesWithOnes(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (matrix[i, j] < 0)
                    matrix[i, j] = 1;
    }

    // 7.18: Считает сумму минимальных элементов каждой строки матрицы
    static int SumOfRowMins(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            int min = matrix[i, 0];      // начинаем с первого элемента строки
            for (int j = 1; j < cols; j++)
                if (matrix[i, j] < min) min = matrix[i, j];
            sum += min;                  // добавляем минимальный элемент строки к общей сумме
        }
        return sum;
    }

    // 7.21: Возвращает обратную строку
    static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();   // преобразуем строку в массив символов
        Array.Reverse(arr);                // меняем порядок элементов массива на обратный
        return new string(arr);            // создаём новую строку из перевёрнутого массива
    }

    // 7.22: Добавляет префикс "++++-----" к строке
    static string AddPrefix(string str)
    {
        return "++++-----" + str;
    }

    // 7.23: Повторяет символ c k раз и возвращает полученную строку
    static string RepeatChar(char c, int k)
    {
        return new string(c, k);
    }

    // 7.24: Суммирует первые n элементов массива arr (если n > длина, суммирует все)
    static int SumFirstN(int[] arr, int n)
    {
        int sum = 0;
        for (int i = 0; i < n && i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Выберите номер задачи (например: 7.4, 7.9, 7.10, 7.11, 7.16, 7.17, 7.18, 7.21, 7.22, 7.23, 7.24):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "7.4":
                Console.Write("Введите a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + MaxExpression(a, b));
                break;

            case "7.9":
                int[] arr79 = { 1, 2, 3, 2, 2, 5, 6, 2, 7, 2 };
                Console.Write("Введите число n: ");
                int n79 = int.Parse(Console.ReadLine());
                Console.WriteLine("Повторяется: " + CountOccurrences(arr79, n79) + " раз(а)");
                break;

            case "7.10":
                Console.Write("Введите строку: ");
                string text = Console.ReadLine();
                Console.Write("Введите символ: ");
                char c = Console.ReadLine()[0];  // берем первый символ введённой строки
                Console.WriteLine("Символ встречается: " + CountChar(text, c) + " раз(а)");
                break;

            case "7.11":
                int[] arr711 = { 1, 5, 3, 5, 2, 5 };
                var (max, count) = MaxAndCount(arr711);
                Console.WriteLine($"Максимум = {max}, встречается {count} раз(а)");
                break;

            case "7.16":
                int[,] matrix716 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                ReplaceDiagonalWithZeros(matrix716);
                Console.WriteLine("Матрица после замены диагонали:");
                PrintMatrix(matrix716);
                break;

            case "7.17":
                int[,] matrix717 = { { -1, 2 }, { -3, -4 } };
                ReplaceNegativesWithOnes(matrix717);
                Console.WriteLine("Матрица после замены отрицательных чисел:");
                PrintMatrix(matrix717);
                break;

            case "7.18":
                int[,] matrix718 = { { 3, 2, 1 }, { 9, 5, 6 }, { 7, 8, 4 } };
                Console.WriteLine("Сумма минимальных элементов по строкам: " + SumOfRowMins(matrix718));
                break;

            case "7.21":
                Console.Write("Введите строку: ");
                string s21 = Console.ReadLine();
                Console.WriteLine("Новая строка: " + ReverseString(s21));
                break;

            case "7.22":
                Console.Write("Введите строку: ");
                string s22 = Console.ReadLine();
                Console.WriteLine("Результат: " + AddPrefix(s22));
                break;

            case "7.23":
                Console.Write("Введите символ: ");
                char c23 = Console.ReadLine()[0];
                Console.Write("Введите k: ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + RepeatChar(c23, k));
                break;

            case "7.24":
                int[] arr724 = { 1, 2, 3, 4, 5 };
                Console.Write("Введите n: ");
                int n724 = int.Parse(Console.ReadLine());
                Console.WriteLine("Сумма первых n элементов: " + SumFirstN(arr724, n724));
                break;

            default:
                Console.WriteLine("Такой задачи нет.");
                break;
        }
    }

    // Вспомогательная функция для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}