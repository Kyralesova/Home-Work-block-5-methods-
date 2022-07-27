using System;

namespace HomeWork5._11
{
    class Program
    {   /// <summary>
        /// Метод принимающий строку и возвращающий массив строк
        /// </summary>
        /// <param name="text">Строковая переменная, которую нужно разделить в массив</param>
        static string[] SplitWords(string text)
        {
            string[] arrayWord = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return arrayWord;
        }
        /// <summary>
        /// Метод вывода массива в консоль
        /// </summary>
        /// <param name="arrayWord">Метод вывода массива в консоль</param>
        static void Print(string[] arrayWord)
        {
            foreach (string e in arrayWord)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();

            string[] arrayWord = SplitWords(text);
            Print(arrayWord);

            Console.ReadKey();
        }
    }
}