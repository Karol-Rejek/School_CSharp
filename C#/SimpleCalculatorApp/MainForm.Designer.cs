
namespace SimpleCalculatorApp
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
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelSecoundNumber = new System.Windows.Forms.Label();
            this.textBoxFitstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNamber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(35, 26);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(74, 15);
            this.labelFirstNumber.TabIndex = 0;
            this.labelFirstNumber.Text = "First number";
            // 
            // labelSecoundNumber
            // 
            this.labelSecoundNumber.AutoSize = true;
            this.labelSecoundNumber.Location = new System.Drawing.Point(159, 26);
            this.labelSecoundNumber.Name = "labelSecoundNumber";
            this.labelSecoundNumber.Size = new System.Drawing.Size(98, 15);
            this.labelSecoundNumber.TabIndex = 1;
            this.labelSecoundNumber.Text = "Secound number";
            // 
            // textBoxFitstNumber
            // 
            this.textBoxFitstNumber.Location = new System.Drawing.Point(35, 54);
            this.textBoxFitstNumber.Name = "textBoxFitstNumber";
            this.textBoxFitstNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxFitstNumber.TabIndex = 2;
            // 
            // textBoxSecondNamber
            // 
            this.textBoxSecondNamber.Location = new System.Drawing.Point(159, 54);
            this.textBoxSecondNamber.Name = "textBoxSecondNamber";
            this.textBoxSecondNamber.Size = new System.Drawing.Size(100, 23);
            this.textBoxSecondNamber.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(35, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(128, 105);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(220, 105);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 6;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(314, 105);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(35, 145);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSecondNamber);
            this.Controls.Add(this.textBoxFitstNumber);
            this.Controls.Add(this.labelSecoundNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.Name = "MainForm";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecoundNumber;
        private System.Windows.Forms.TextBox textBoxFitstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNamber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label labelResult;
    }
}

