
namespace task
{
    partial class FormUserInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInput));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtonAnalyze = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 200);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // ButtonAnalyze
            // 
            this.ButtonAnalyze.Location = new System.Drawing.Point(56, 231);
            this.ButtonAnalyze.Name = "ButtonAnalyze";
            this.ButtonAnalyze.Size = new System.Drawing.Size(238, 23);
            this.ButtonAnalyze.TabIndex = 2;
            this.ButtonAnalyze.Text = "Провести анализ";
            this.ButtonAnalyze.UseVisualStyleBackColor = true;
            this.ButtonAnalyze.Click += new System.EventHandler(this.ButtonAnalyze_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(300, 231);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAnalyze);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 320);
            this.MinimumSize = new System.Drawing.Size(450, 320);
            this.Name = "FormUserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод текста вручную";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserInputFormClosed);
            this.Load += new System.EventHandler(this.FormUserInputLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButtonAnalyze;
        private System.Windows.Forms.Button ButtonBack;
    }
}