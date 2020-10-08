using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TirtaShutdownTimer
{
    public partial class MainWindow : Form
    {
        private int SPT = 10; //Seconds per Tick of button.
        private TimeSpan a; //Configured Time Target
        private TimeSpan b; //Timer current progress

        public MainWindow()
        {
            InitializeComponent();
            a.Add(TimeSpan.FromSeconds(0));
        }





        /* Start of Action Command */
        /// <summary>
        /// Force Shutdown the system in 3 seconds
        /// </summary>
        private void Shutdown()
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("shutdown", "/s /f /t 3 /c \"TirtaShutdown Timer is Triggered\"")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            System.Diagnostics.Process.Start(psi);
        }
        /// <summary>
        /// Force Restart the system in 3 seconds
        /// </summary>
        private void Restart()
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("shutdown", "/r /f /t 3 /c \"TirtaShutdown Timer is Triggered\"")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            System.Diagnostics.Process.Start(psi);
        }




        /* End of Executable shutdown */
        /// <summary>
        /// Update the User Interface to display Configured time.
        /// </summary>
        private void UpdateTimerDisplay()
        {
            TimeLeft.Text = a.ToString(@"hh\:mm\:ss");
        }

        private void RiseTimer_Click(object sender, EventArgs e)
        {
            a += TimeSpan.FromSeconds(SPT);
            UpdateTimerDisplay();
        }

        private void LowerTimer_Click(object sender, EventArgs e)
        {
            if (((a.TotalSeconds - SPT) < 0)) { return; }
            a -= TimeSpan.FromSeconds(SPT);
            UpdateTimerDisplay();
        }

        private void SecondsPerTick_ValueChanged(object sender, EventArgs e)
        {
            SPT = SecondsPerTick.Value;
        }

        private void MainSwitch_Click(object sender, EventArgs e)
        {
            if (MainSwitch.Text == "Stop Timer") { TimerState = State.Aborted; return; }
            QuickMarkCheckBox(false);
            StopWatchDog = false;
            RiseTimer.Enabled = false;
            LowerTimer.Enabled = false;
            MainSwitch.Text = "Stop Timer";
            TimerWatchDog.RunWorkerAsync();
            TimerCountdown.RunWorkerAsync();
            return;
        }

        /* TIMER BACKGROUND WORKER */
        private bool StopWatchDog = false;
        private State TimerState = State.NullBenedException;
        enum State {Running, Stopped, Aborted, Complete, Error, NullBenedException};

        private void TimerCountdown_DoWork(object sender, DoWorkEventArgs e)
        {
            TimerState = State.Running;
            while (b.TotalSeconds <= a.TotalSeconds)
            {
                if (TimerState == State.Aborted) { break; }
                System.Threading.Thread.Sleep(200);
                b += TimeSpan.FromMilliseconds(200);
            }
            if (TimerState == State.Running) { TimerState = State.Complete; }
            e.Result = true;
            return;
        }

        private void TimerCountdown_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (TimerState == State.Complete)
            {
                b -= b;
                StopWatchDog = true;
                ThreadSafe.Invoke(this, RiseTimer, true, ThreadSafe.InvokeProperty.Enabled, ThreadSafe.InvokeMethod.SET);
                ThreadSafe.Invoke(this, LowerTimer, true, ThreadSafe.InvokeProperty.Enabled, ThreadSafe.InvokeMethod.SET);
                ThreadSafe.Invoke(this, MainSwitch, "Start Timer", ThreadSafe.InvokeProperty.Text, ThreadSafe.InvokeMethod.SET);
                //Selesai waktunya shutdown
                Console.WriteLine("REEE TIME");
                if (TimerAction == Action.ShutDown) { Shutdown(); }
                if (TimerAction == Action.Restart) { Restart(); }
                if (TimerAction == Action.Nothing) { return; }
            }
            else
            {
                b -= b;
                StopWatchDog = true;
                ThreadSafe.Invoke(this, RiseTimer, true, ThreadSafe.InvokeProperty.Enabled, ThreadSafe.InvokeMethod.SET);
                ThreadSafe.Invoke(this, LowerTimer, true, ThreadSafe.InvokeProperty.Enabled, ThreadSafe.InvokeMethod.SET);
                ThreadSafe.Invoke(this, MainSwitch, "Start Timer", ThreadSafe.InvokeProperty.Text, ThreadSafe.InvokeMethod.SET);
                return;
            }   
        }

        /* Timer Watchdog */
        private void TimerWatchDog_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            TimeSpan abc = TimeSpan.FromSeconds(a.TotalSeconds - b.TotalSeconds);
            if (abc.TotalSeconds < 61) {
                ThreadSafe.Invoke(this, TimeLeft, Color.Red, ThreadSafe.InvokeProperty.ForeColor, ThreadSafe.InvokeMethod.SET);
            }
            ThreadSafe.Invoke(this, TimeLeft, abc.ToString(@"hh\:mm\:ss"), ThreadSafe.InvokeProperty.Text, ThreadSafe.InvokeMethod.SET);
            e.Result = true;
            return;
        }

        private void TimerWatchDog_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (StopWatchDog) { QuickMarkCheckBox(true);  ThreadSafe.Invoke(this, TimeLeft, Color.Black, ThreadSafe.InvokeProperty.ForeColor, ThreadSafe.InvokeMethod.SET);  return; }
            TimerWatchDog.RunWorkerAsync();
        }

        /* Action of Timer Chooser */
        private Action TimerAction = Action.Nothing;
        enum Action {ShutDown, Restart, Nothing}
        private bool StopCheckBoxUpdate = false;
        private void ShutdownAction_CheckedChanged(object sender, EventArgs e)
        {
            if (StopCheckBoxUpdate) { return; }
            if (ShutdownAction.Checked) {
                StopCheckBoxUpdate = true;
                RestartAction.Checked = false;
                NothingAction.Checked = false;
                TimerAction = Action.ShutDown;
                StopCheckBoxUpdate = false;
            }
        }

        private void RestartAction_CheckedChanged(object sender, EventArgs e)
        {
            if (StopCheckBoxUpdate) { return; }
            if (RestartAction.Checked)
            {
                StopCheckBoxUpdate = true;
                ShutdownAction.Checked = false;
                NothingAction.Checked = false;
                TimerAction = Action.Restart;
                StopCheckBoxUpdate = false;
            }
        }

        private void NothingAction_CheckedChanged(object sender, EventArgs e)
        {
            if (StopCheckBoxUpdate) { return; }
            if (NothingAction.Checked)
            {
                StopCheckBoxUpdate = true;
                RestartAction.Checked = false;
                ShutdownAction.Checked = false;
                TimerAction = Action.Nothing;
                StopCheckBoxUpdate = false;
            }
        }
        /// <summary>
        /// Set Enable of the Action Checkbox quickly
        /// </summary>
        /// <param name="a">True or False (Enabled / Disabled)</param>
        private void QuickMarkCheckBox(bool a)
        {
            ShutdownAction.Enabled = a;
            RestartAction.Enabled = a;
            NothingAction.Enabled = a;
        }
    }
}
