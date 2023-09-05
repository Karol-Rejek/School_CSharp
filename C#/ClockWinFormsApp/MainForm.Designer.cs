
namespace ClockWinFormsApp
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
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonReadTime = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonStopWatchStart = new System.Windows.Forms.Button();
            this.buttonStopWatchStop = new System.Windows.Forms.Button();
            this.buttonStopWatchDeltaStop = new System.Windows.Forms.Button();
            this.buttonStopWatchDeltaStart = new System.Windows.Forms.Button();
            this.labelStopWatchDelta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClock.Location = new System.Drawing.Point(61, 39);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(90, 37);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "label1";
            // 
            // buttonReadTime
            // 
            this.buttonReadTime.Location = new System.Drawing.Point(61, 97);
            this.buttonReadTime.Name = "buttonReadTime";
            this.buttonReadTime.Size = new System.Drawing.Size(75, 59);
            this.buttonReadTime.TabIndex = 1;
            this.buttonReadTime.Text = "Zatrzymaj czas";
            this.buttonReadTime.UseVisualStyleBackColor = true;
            this.buttonReadTime.Click += new System.EventHandler(this.buttonReadTime_Click);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopWatch.Location = new System.Drawing.Point(213, 39);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(157, 30);
            this.labelStopWatch.TabIndex = 2;
            this.labelStopWatch.Text = "labelStopWatch";
            // 
            // buttonStopWatchStart
            // 
            this.buttonStopWatchStart.Location = new System.Drawing.Point(213, 83);
            this.buttonStopWatchStart.Name = "buttonStopWatchStart";
            this.buttonStopWatchStart.Size = new System.Drawing.Size(79, 59);
            this.buttonStopWatchStart.TabIndex = 3;
            this.buttonStopWatchStart.Text = "Start";
            this.buttonStopWatchStart.UseVisualStyleBackColor = true;
            this.buttonStopWatchStart.Click += new System.EventHandler(this.buttonStopWatchStart_Click);
            // 
            // buttonStopWatchStop
            // 
            this.buttonStopWatchStop.Location = new System.Drawing.Point(312, 83);
            this.buttonStopWatchStop.Name = "buttonStopWatchStop";
            this.buttonStopWatchStop.Size = new System.Drawing.Size(76, 59);
            this.buttonStopWatchStop.TabIndex = 4;
            this.buttonStopWatchStop.Text = "Stop";
            this.buttonStopWatchStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchStop.Click += new System.EventHandler(this.buttonStopWatchStop_Click);
            // 
            // buttonStopWatchDeltaStop
            // 
            this.buttonStopWatchDeltaStop.Location = new System.Drawing.Point(312, 226);
            this.buttonStopWatchDeltaStop.Name = "buttonStopWatchDeltaStop";
            this.buttonStopWatchDeltaStop.Size = new System.Drawing.Size(76, 59);
            this.buttonStopWatchDeltaStop.TabIndex = 7;
            this.buttonStopWatchDeltaStop.Text = "Stop";
            this.buttonStopWatchDeltaStop.UseVisualStyleBackColor = true;
            this.buttonStopWatchDeltaStop.Click += new System.EventHandler(this.buttonStopWatchDeltaStop_Click);
            // 
            // buttonStopWatchDeltaStart
            // 
            this.buttonStopWatchDeltaStart.Location = new System.Drawing.Point(213, 226);
            this.buttonStopWatchDeltaStart.Name = "buttonStopWatchDeltaStart";
            this.buttonStopWatchDeltaStart.Size = new System.Drawing.Size(79, 59);
            this.buttonStopWatchDeltaStart.TabIndex = 6;
            this.buttonStopWatchDeltaStart.Text = "Start";
            this.buttonStopWatchDeltaStart.UseVisualStyleBackColor = true;
            this.buttonStopWatchDeltaStart.Click += new System.EventHandler(this.buttonStopWatchDeltaStart_Click);
            // 
            // labelStopWatchDelta
            // 
            this.labelStopWatchDelta.AutoSize = true;
            this.labelStopWatchDelta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStopWatchDelta.Location = new System.Drawing.Point(213, 182);
            this.labelStopWatchDelta.Name = "labelStopWatchDelta";
            this.labelStopWatchDelta.Size = new System.Drawing.Size(206, 30);
            this.labelStopWatchDelta.TabIndex = 5;
            this.labelStopWatchDelta.Text = "labelStopWatchDelta";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStopWatchDeltaStop);
            this.Controls.Add(this.buttonStopWatchDeltaStart);
            this.Controls.Add(this.labelStopWatchDelta);
            this.Controls.Add(this.buttonStopWatchStop);
            this.Controls.Add(this.buttonStopWatchStart);
            this.Controls.Add(this.labelStopWatch);
            this.Controls.Add(this.buttonReadTime);
            this.Controls.Add(this.labelClock);
            this.Name = "MainForm";
            this.Text = "Zegar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonReadTime;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStopWatchStart;
        private System.Windows.Forms.Button buttonStopWatchStop;
        private System.Windows.Forms.Button buttonStopWatchDeltaStop;
        private System.Windows.Forms.Button buttonStopWatchDeltaStart;
        private System.Windows.Forms.Label labelStopWatchDelta;
    }
}

