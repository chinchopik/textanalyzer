
namespace task
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.UserInput = new System.Windows.Forms.Button();
            this.FileInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(40, 40);
            this.UserInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.UserInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(200, 25);
            this.UserInput.TabIndex = 0;
            this.UserInput.TabStop = false;
            this.UserInput.Text = "Ввод вручную";
            this.UserInput.UseVisualStyleBackColor = true;
            this.UserInput.Click += new System.EventHandler(this.ButtonUserInput);
            // 
            // FileInput
            // 
            this.FileInput.Location = new System.Drawing.Point(40, 72);
            this.FileInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.FileInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(200, 25);
            this.FileInput.TabIndex = 1;
            this.FileInput.TabStop = false;
            this.FileInput.Text = "Открыть файл";
            this.FileInput.UseVisualStyleBackColor = true;
            this.FileInput.Click += new System.EventHandler(this.ButtonFileInput);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(40, 8);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(200, 24);
            this.Help.TabIndex = 2;
            this.Help.TabStop = false;
            this.Help.Text = "Справка";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.ButtonHelp);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.FileInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.Help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuFormClosed);
            this.Load += new System.EventHandler(this.FormMenuLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserInput;
        private System.Windows.Forms.Button FileInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Help;

    }
}

