using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            do
            {
                Console.WriteLine("Введите число:");
                try
                {
                    flag = false;
                    int a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Неверный формат данных");
                    Console.WriteLine(ex.Message);
                    flag = true;
                    //throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Неправильно введли данные");
                    Console.WriteLine(ex.Message);
                    flag = true;
                }
                finally
                {
                    Console.WriteLine("finally");
                }
            } while (flag);
        }
    }
}
