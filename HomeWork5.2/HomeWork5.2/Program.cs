using System;

namespace HomeWork5._2
{
    class Program
    {
        /// <summary>
        /// Метод разделяющий слова в предложении
        /// </summary>
        /// <param name="text">Строковая переменная, которую нужно разделить в массив</param>
        /// <returns></returns>
        static string SplitWords(string text)
        {
            string[] arrayWord = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var e in arrayWord)
            {
                Console.WriteLine(e);
            }
            string newText = ReverseWords(arrayWord);
            return newText;
        }
        /// <summary>
        /// Метод меняющий слова местами
        /// </summary>
        /// <param name="text">Массив строк, который нужно реверсировать</param>
        /// <returns></returns>
        static string ReverseWords(string[] text)
        {
            Array.Reverse(text);
            string newString = string.Join(" ", text);
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string inputPhrase = Console.ReadLine();

            inputPhrase = SplitWords(inputPhrase);
            Console.WriteLine(inputPhrase);

            Console.ReadKey();
        }
    }
}
