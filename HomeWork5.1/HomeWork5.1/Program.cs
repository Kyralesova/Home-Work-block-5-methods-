using System;

namespace HomeWork5._1
{
    class Program
    {
        /// <summary>
        /// Метод принимающий строку, возвращающий массив строк и выводящий в консоль
        /// </summary>
        /// <param name="text">Строковая переменная, которую нужно разделить в массив</param>
        static void SplitWords(string text)
        {
            string[] arrayWord = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var e in arrayWord)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();

            SplitWords(text);

            Console.ReadKey();
        }
    }
}
