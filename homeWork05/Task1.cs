using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace homeWork05
{
    class Task1
    {
        static void Main(string[] args)
        {
            //Task1
            WriteLine("Введите делимое число: ");
            int divident = int.Parse(ReadLine());
            WriteLine("Введите делитель: ");
            int divisor = int.Parse(ReadLine());
            try
            {
                WriteLine(Division(divident, divisor));
            }
            catch (ArgumentNullException exepction)
            {
                WriteLine(exepction.Message);
            }
            catch (ArgumentException exepction)
            {
                WriteLine(exepction.Message);
            }

            //Task2
            Random rand = new Random();

            WriteLine("Введите размер массива: ");
            int sizeOfArray = int.Parse(ReadLine());
            int[] mas = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                mas[i] = rand.Next(0, 50);
                Write(mas[i] + "\t");
            }

            Write("\n" + "Введите индекс массива: ");
            int index;
            while(!int.TryParse(ReadLine(), out index))
            {
                Clear();
                WriteLine("Ошибка ввода! Введите целое число: ");
            }
            try
            {
                WriteLine(mas[index]);
            }
            catch (IndexOutOfRangeException exeption)
            {
                WriteLine(exeption.Message);
            }
            finally
            {
                WriteLine("Обработка завершена !");
            }
           

                ReadLine();

        }

        private static double Division(double divident, double divisor)
        {
            
            if (divident == 0)
            {
                throw new ArgumentNullException();
            }
            else if(divisor ==0)
            {
                throw new ArgumentException();
            }
            WriteLine("Ответ:" );
            return divident / divisor;
        }
    }
}
