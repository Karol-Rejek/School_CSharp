
namespace FirstWinFormsApp
{
    partial class MainForm
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonHallo = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonHalloName = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(53, 249);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(237, 125);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "button";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonHallo
            // 
            this.buttonHallo.Location = new System.Drawing.Point(494, 264);
            this.buttonHallo.Name = "buttonHallo";
            this.buttonHallo.Size = new System.Drawing.Size(183, 103);
            this.buttonHallo.TabIndex = 1;
            this.buttonHallo.Text = "Hello";
            this.buttonHallo.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Cornsilk;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Navy;
            this.labelName.Location = new System.Drawing.Point(53, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(142, 37);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Podaj imie";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(332, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonHalloName
            // 
            this.buttonHalloName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonHalloName.Location = new System.Drawing.Point(53, 144);
            this.buttonHalloName.Name = "buttonHalloName";
            this.buttonHalloName.Size = new System.Drawing.Size(192, 53);
            this.buttonHalloName.TabIndex = 4;
            this.buttonHalloName.Text = "Przywitanie";
            this.buttonHalloName.UseVisualStyleBackColor = true;
            this.buttonHalloName.Click += new System.EventHandler(this.buttonHalloName_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(53, 88);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(64, 15);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Podaj wiek";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(53, 106);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(332, 23);
            this.textBoxAge.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.buttonHalloName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonHallo);
            this.Controls.Add(this.buttonFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "First Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonHallo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonHalloName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}

