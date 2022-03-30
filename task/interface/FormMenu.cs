using System;
using System.Windows.Forms;
using System.IO;

namespace task
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открывает подчинённую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUserInput_Click(object sender, EventArgs e)
        {
            Hide();
            FormUserInput buttonInput = new FormUserInput();
            buttonInput.ShowDialog();
            
        }

        /// <summary>
        /// Открывает файл, читает его текст и вызывает 2 метода из библиотеки CountLib для работы с ним
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonFileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)| *.txt";
            string line = "";

            CountLib.TextAnalyzer buttonFileInput = new CountLib.TextAnalyzer();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text = "";   
                StreamReader sr = new StreamReader(ofd.FileName);
            
                while (line != null)
                {
                   line = sr.ReadLine();
                    text = text + line;
                }
                buttonFileInput.GetText(text);
                buttonFileInput.Print(text);
                sr.Close();      
            }

        }

        private void FormMenuLoad(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
        }

        /// <summary>
        /// При нажатии крестика на панели формы закрывает программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// При нажатии кнопки на экран выводится справочная информация о программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для анализа текста на русском языке.\n" +
                "Она считает количество гласных и согласных букв, цифр и пунктуационных знаков.\n" +
                "Ввод текста обеспечивается вручную или из файла по желанию пользователя.", "Всплывающее окно");
        }

    }
}
