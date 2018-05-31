using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ex7
{
    class Program
    {
        // получение подмножества (проверка на существование)
        // сочетание из N по K с повторениями
        static bool NextSet(ref int[] arr, int n, int m)
        {
            int j = m - 1;  // позиция элемента
            while (j >= 0 && arr[j] == n) j--;
            if (j < 0) return false;
            if (arr[j] >= n)
                j--;
            arr[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                arr[k] = arr[j];
            return true;
        }

        // печать подмножества
        static int num = 1;
        static void Print(int[] arr, int n)
        {
            Console.Write("{0}: ", num);
            num++;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n, k;
            int[] arr;
            Console.WriteLine("Сочетания из N по K с повторениями:");
            n = AskData.ReadIntNumber("Введите N: ", 1, int.MaxValue);
            k = AskData.ReadIntNumber("Введите M: ", 1, int.MaxValue);
            Console.WriteLine();
            int size = Math.Max(n, k); // если k>n, то эти значения меняются местами
            arr = new int[size];       // массив элементов подмножества
            for (int i = 0; i < size; i++)
                arr[i] = 1;
            Print(arr, k);
            while (NextSet(ref arr, n, k))
                Print(arr, k);

            Console.ReadLine();
        }
    }
}
