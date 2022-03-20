using System;
using System.Windows.Forms;
using System.IO;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonUserInput(object sender, EventArgs e)
        {
            Hide();
            Form2 buttonInput = new Form2();
            buttonInput.ShowDialog();
            
        }

        public void ButtonFileInput(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)| *.txt";
            string line = "";

            Form2.TextAnalyzer buttonFileInput = new Form2.TextAnalyzer();

            
            

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

        private void Form1Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
        }

        private void Form1FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для анализа текста на русском языке.\nОна считает количество гласных и согласных букв, цифр и пунктуационных знаков.\nВвод текста обеспечивается вручную или из файла по желанию пользователя.", "Всплывающее окно");
        }
    }
}
