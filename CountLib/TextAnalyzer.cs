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
        public void GetText(string text)
        {
            vowels = Regex.Matches(text, @"[аеоуиэюыёя]", RegexOptions.IgnoreCase).Count;
            consonants = Regex.Matches(text, @"[йцкнгшщзхфвпрлджчсмтб]", RegexOptions.IgnoreCase).Count;
            numbers = Regex.Matches(text, @"[0-9]").Count;
            punctuation = Regex.Matches(text, @"[.,:;!?)(–-]").Count;
            symbols = vowels + consonants + numbers + punctuation;
        }


        public void Print(string text)
        {
            if (text != null)
            {
                MessageBox.Show($"Количество гласных: {vowels}\nКоличество согласных: {consonants}\nКоличество цифр: {numbers}\nКоличество пункуационных знаков: {punctuation}\nКоличество символов: {symbols}", "Всплывающее окно");
            }
        }
    }
}
