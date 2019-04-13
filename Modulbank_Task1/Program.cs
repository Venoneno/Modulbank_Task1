using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulbank_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int count_lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int count_columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n *** ТАБЛИЦА ГОТОВА *** \n");
            for (int i = 0; i < count_lines; i++)
            {
                for (int j = 0; j < count_columns; j++)
                {
                    int x = (i + 1) * (j + 1);
                    Console.Write("{0,3} ", x);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}