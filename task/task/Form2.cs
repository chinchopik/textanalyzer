using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace task
{


    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void ButtonAnalyze(object sender, EventArgs e)
        {
            TextAnalyzer buttonAnalyze = new TextAnalyzer();
            string text = richTextBox1.Text;

            buttonAnalyze.GetText(text);
            buttonAnalyze.Print(text);
        }

        private void ButtonBack(object sender, EventArgs e)
        {
            Hide();
            Form1 buttonBack = new Form1();
            buttonBack.Show();
        }

        public class TextAnalyzer
    {
            public int vowels, consonants, numbers, punctuation, symbols;
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

        private void Form2FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
