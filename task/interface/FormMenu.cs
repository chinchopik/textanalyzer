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

        private void ButtonUserInput(object sender, EventArgs e)
        {
            Hide();
            FormUserInput buttonInput = new FormUserInput();
            buttonInput.ShowDialog();
            
        }

        public void ButtonFileInput(object sender, EventArgs e)
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

        private void FormMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для анализа текста на русском языке.\nОна считает количество гласных и согласных букв, цифр и пунктуационных знаков.\nВвод текста обеспечивается вручную или из файла по желанию пользователя.", "Всплывающее окно");
        }
    }
}
