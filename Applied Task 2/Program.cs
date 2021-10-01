using System;

namespace Applied_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Answers(Square(), Window());
        }
        /*ЗАДАЧА 2*/
        public static double Square()
        {
            Console.WriteLine("Введите длину, ширину и высоту в помещении");
            double length = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return 2 * (height * weight) + 2 * (weight * length);

        }
        public static double Window()
        {
            double Square1 = 0;
            Console.WriteLine("Введите количество окон");
            int windows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество дверей");
            int doors = int.Parse(Console.ReadLine());
            for (int i = 1; i <= windows; i++)
            {
                Console.WriteLine("Введите ширину " + i + " окна");
                double weight1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту " + i + " окна");
                double height1 = double.Parse(Console.ReadLine());
                Square1 += weight1 * height1;

            }
            for (int k = 1; k <= doors; k++)
            {
                Console.WriteLine("Введите ширину " + k + " двери");
                double weight1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту " + k + " двери");
                double height1 = double.Parse(Console.ReadLine());
                Square1 += weight1 * height1;

            }
            return Square1;

        }
        public static void Answers(double Square, double Window)
        {
            Console.WriteLine("Общая площадь покраски состовляет " + (Square - Window));
        }
    }
}
