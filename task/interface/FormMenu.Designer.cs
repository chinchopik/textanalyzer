
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
            this.ButtonUserInput = new System.Windows.Forms.Button();
            this.ButtonFileInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUserInput
            // 
            this.ButtonUserInput.Location = new System.Drawing.Point(40, 40);
            this.ButtonUserInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.ButtonUserInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.ButtonUserInput.Name = "ButtonUserInput";
            this.ButtonUserInput.Size = new System.Drawing.Size(200, 25);
            this.ButtonUserInput.TabIndex = 0;
            this.ButtonUserInput.TabStop = false;
            this.ButtonUserInput.Text = "Ввод вручную";
            this.ButtonUserInput.UseVisualStyleBackColor = true;
            this.ButtonUserInput.Click += new System.EventHandler(this.ButtonUserInput_Click);
            // 
            // ButtonFileInput
            // 
            this.ButtonFileInput.Location = new System.Drawing.Point(40, 72);
            this.ButtonFileInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.ButtonFileInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.ButtonFileInput.Name = "ButtonFileInput";
            this.ButtonFileInput.Size = new System.Drawing.Size(200, 25);
            this.ButtonFileInput.TabIndex = 1;
            this.ButtonFileInput.TabStop = false;
            this.ButtonFileInput.Text = "Открыть файл";
            this.ButtonFileInput.UseVisualStyleBackColor = true;
            this.ButtonFileInput.Click += new System.EventHandler(this.ButtonFileInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(40, 8);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(200, 24);
            this.ButtonHelp.TabIndex = 2;
            this.ButtonHelp.TabStop = false;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.ButtonFileInput);
            this.Controls.Add(this.ButtonUserInput);
            this.Controls.Add(this.ButtonHelp);
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

        private System.Windows.Forms.Button ButtonUserInput;
        private System.Windows.Forms.Button ButtonFileInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonHelp;

    }
}

