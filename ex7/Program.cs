using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
