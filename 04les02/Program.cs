using System;
using System.IO;

namespace _04les02
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "..\\..\\data.txt";
            int summ = 0;
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        int n = int.Parse(sr.ReadLine());
                        Console.WriteLine($"Количество строк = {n}");

                        try
                        {
                            for (int i = 0; i < n; i++)
                            {
                                int a = int.Parse(sr.ReadLine());
                                summ += a;
                                count++;
                                Console.WriteLine($"{count}. Преобразовали в число {a}");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Среднее арифметическое: {(double)summ / count}");

            Console.ReadKey();
        }
    }
}
