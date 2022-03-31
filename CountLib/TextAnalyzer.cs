using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CountLib
{
    public class TextAnalyzer
    {
        public int vowels;
        public int consonants;
        public int numbers;
        public int punctuation;
        public int symbols;
        /// <summary>
        /// Метод считает количество символов
        /// </summary>
        /// <param name="text"></param>
        public void GetText(string text)
        {
            vowels = Regex.Matches(text, @"[аеоуиэюыёя]", RegexOptions.IgnoreCase).Count;
            consonants = Regex.Matches(text, @"[йцкнгшщзхфвпрлджчсмтбьъ]", RegexOptions.IgnoreCase).Count;
            numbers = Regex.Matches(text, @"[0-9]").Count;
            punctuation = Regex.Matches(text, @"[.,:;!?)(–-]").Count;
            symbols = vowels + consonants + numbers + punctuation;
        }


        /// <summary>
        /// Метод выводит сообщение на экран о количестве символов
        /// </summary>
        /// <param name="text"></param>
        public void Print(string text)
        {
            if (text != null)
            {
                MessageBox.Show($"Количество гласных букв: {vowels}\nКоличество согласных букв: {consonants}\n" +
                    $"Количество цифр: {numbers}\nКоличество пунктуационных знаков: {punctuation}\n" +
                    $"Количество символов: {symbols}", "Всплывающее окно");
            }
        }
    }
}
