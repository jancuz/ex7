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
        static bool NextSet(ref int[] arr, int n, int k)
        {
            int j = k - 1;  // позиция элемента
            while (j >= 0 && arr[j] == n) j--;
            if (j < 0) return false;
            arr[j]++;
            if (j == k - 1) return true;
            for (int i = j + 1; i < k; i++)
                arr[i] = arr[j];
            return true;
        }

        // печать подмножества
        static int num = 1;
        static void Print(int[] arr, int k)
        {
            Console.Write("{0}: ", num);
            num++;
            for (int i = 0; i < k; i++)
                Console.Write(arr[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n, k;
            int[] arr;
            Console.WriteLine("Сочетания из N по K с повторениями:");
            n = AskData.ReadIntNumber("Введите N: ", 1, int.MaxValue);
            k = AskData.ReadIntNumber("Введите K: ", 1, int.MaxValue);
            Console.WriteLine();
            arr = new int[k];       // массив элементов подмножества
            for (int i = 0; i < k; i++)
                arr[i] = 1;
            Print(arr, k);
            while (NextSet(ref arr, n, k))
                Print(arr, k);

            Console.WriteLine("Для завершения работы нажмите Enter");
            Console.ReadLine();
        }
    }
}
