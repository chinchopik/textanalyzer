using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CountLib;

namespace task
{


    public partial class FormUserInput : Form
    {
        
        public FormUserInput()
        {
            InitializeComponent();
        }

        private void FormUserInputLoad(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        /// <summary>
        /// При нажатии кнопки вызываются 2 метода из библиотеки CountLib
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnalyze_Click(object sender, EventArgs e)
        {
            TextAnalyzer buttonAnalyze = new TextAnalyzer();
            string text = richTextBox1.Text;

            buttonAnalyze.GetText(text);
            buttonAnalyze.Print(text);
        }

        /// <summary>
        /// Открывает главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormMenu buttonBack = new FormMenu();
            buttonBack.Show();
        }

        /// <summary>
        /// При нажатии крестика на панели формы закрывает программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUserInputFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
