using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockWinFormsApp
{
    public partial class MainForm : Form
    {
        static System.Windows.Forms.Timer clockTimer = new(); 
        static System.Windows.Forms.Timer startStopTimer = new();
        static System.Windows.Forms.Timer startStopTimerDelta = new();

        private int timeStopWatch;
        DateTime timeStart;
        private void ClockTimerEvent(Object myObject, EventArgs myEventArgs)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void startStopTimerEvent(Object myObject, EventArgs myEventArgs)
        {
            timeStopWatch++;
            labelStopWatch.Text = timeStopWatch.ToString();
        }

        private void startStopTimerDeltaEvent(Object myObject, EventArgs myEventArgs)
        {
         
            TimeSpan deltaTime = DateTime.Now - timeStart;
            labelStopWatchDelta.Text = deltaTime.Hours + ":" + deltaTime.Minutes + ":" + deltaTime.Seconds + ":" + deltaTime.Milliseconds;
        }

        public MainForm()
        {
            InitializeComponent();
            clockTimer.Tick += new EventHandler(ClockTimerEvent);
            clockTimer.Interval = 1;
            clockTimer.Start();

            startStopTimer.Tick += new EventHandler(startStopTimerEvent);
            startStopTimer.Interval = 1000;
            startStopTimerDelta.Tick += new EventHandler(startStopTimerDeltaEvent);
            startStopTimerDelta.Interval = 1;

        }

        private void buttonReadTime_Click(object sender, EventArgs e)
        {
            clockTimer.Stop();
        }

        private void buttonStopWatchStart_Click(object sender, EventArgs e)
        {
            timeStopWatch = 0;
            startStopTimer.Start();
        }

        private void buttonStopWatchStop_Click(object sender, EventArgs e)
        {
            startStopTimer.Stop();
        }

        private void buttonStopWatchDeltaStart_Click(object sender, EventArgs e)
        {
            timeStart = DateTime.Now;
            startStopTimerDelta.Start();
        }

        private void buttonStopWatchDeltaStop_Click(object sender, EventArgs e)
        {
            startStopTimerDelta.Stop();
        }
    }
}
