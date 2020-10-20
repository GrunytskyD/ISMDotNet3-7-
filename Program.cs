using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Відсортування масивів за спаданням значень елементів
            int A[10];
            int i, j;//Додаткові змінні
            int t;//Додаткова змінна
            //Введення масива А
            //...
            //Сортування
            for (i = 0; i < 9; i++)
                for (j = 1; j >= 0; j--)
                    if (A[j] < A[j + 1])
                    {
                        // змінити місцями А[j] і A[j+1]
                        t = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = t;
                    }
        }
    }
}
