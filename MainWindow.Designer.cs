namespace TirtaShutdownTimer
{
    partial class MainWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.TimeLeft = new System.Windows.Forms.Label();
            this.RiseTimer = new System.Windows.Forms.Button();
            this.LowerTimer = new System.Windows.Forms.Button();
            this.MainSwitch = new System.Windows.Forms.Button();
            this.ShutdownAction = new System.Windows.Forms.RadioButton();
            this.RestartAction = new System.Windows.Forms.RadioButton();
            this.NothingAction = new System.Windows.Forms.RadioButton();
            this.TimerWatchDog = new System.ComponentModel.BackgroundWorker();
            this.TimerCountdown = new System.ComponentModel.BackgroundWorker();
            this.SecondsPerTick = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsPerTick)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 299);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 21);
            label1.TabIndex = 7;
            label1.Text = "After timer ends, Do : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(523, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 8;
            label2.Text = "Seconds per click";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(526, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 13);
            label3.TabIndex = 9;
            label3.Text = "60 S/T";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(526, 66);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 10;
            label4.Text = "50 S/T";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(526, 95);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 13);
            label5.TabIndex = 11;
            label5.Text = "40 S/T";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(526, 123);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 13);
            label6.TabIndex = 12;
            label6.Text = "30 S/T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(526, 153);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(41, 13);
            label7.TabIndex = 13;
            label7.Text = "20 S/T";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(526, 181);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(41, 13);
            label8.TabIndex = 14;
            label8.Text = "10 S/T";
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(156, 9);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(293, 86);
            this.TimeLeft.TabIndex = 0;
            this.TimeLeft.Text = "00:00:00";
            // 
            // RiseTimer
            // 
            this.RiseTimer.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiseTimer.Location = new System.Drawing.Point(199, 107);
            this.RiseTimer.Name = "RiseTimer";
            this.RiseTimer.Size = new System.Drawing.Size(85, 44);
            this.RiseTimer.TabIndex = 1;
            this.RiseTimer.Text = "/\\";
            this.RiseTimer.UseVisualStyleBackColor = true;
            this.RiseTimer.Click += new System.EventHandler(this.RiseTimer_Click);
            // 
            // LowerTimer
            // 
            this.LowerTimer.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerTimer.Location = new System.Drawing.Point(324, 107);
            this.LowerTimer.Name = "LowerTimer";
            this.LowerTimer.Size = new System.Drawing.Size(85, 44);
            this.LowerTimer.TabIndex = 2;
            this.LowerTimer.Text = "\\/";
            this.LowerTimer.UseVisualStyleBackColor = true;
            this.LowerTimer.Click += new System.EventHandler(this.LowerTimer_Click);
            // 
            // MainSwitch
            // 
            this.MainSwitch.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSwitch.Location = new System.Drawing.Point(185, 157);
            this.MainSwitch.Name = "MainSwitch";
            this.MainSwitch.Size = new System.Drawing.Size(244, 44);
            this.MainSwitch.TabIndex = 3;
            this.MainSwitch.Text = "Start Timer";
            this.MainSwitch.UseVisualStyleBackColor = true;
            this.MainSwitch.Click += new System.EventHandler(this.MainSwitch_Click);
            // 
            // ShutdownAction
            // 
            this.ShutdownAction.AutoSize = true;
            this.ShutdownAction.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ShutdownAction.Location = new System.Drawing.Point(199, 290);
            this.ShutdownAction.Name = "ShutdownAction";
            this.ShutdownAction.Size = new System.Drawing.Size(130, 34);
            this.ShutdownAction.TabIndex = 4;
            this.ShutdownAction.TabStop = true;
            this.ShutdownAction.Text = "Shutdown";
            this.ShutdownAction.UseVisualStyleBackColor = true;
            this.ShutdownAction.CheckedChanged += new System.EventHandler(this.ShutdownAction_CheckedChanged);
            // 
            // RestartAction
            // 
            this.RestartAction.AutoSize = true;
            this.RestartAction.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RestartAction.Location = new System.Drawing.Point(363, 290);
            this.RestartAction.Name = "RestartAction";
            this.RestartAction.Size = new System.Drawing.Size(100, 34);
            this.RestartAction.TabIndex = 5;
            this.RestartAction.TabStop = true;
            this.RestartAction.Text = "Restart";
            this.RestartAction.UseVisualStyleBackColor = true;
            this.RestartAction.CheckedChanged += new System.EventHandler(this.RestartAction_CheckedChanged);
            // 
            // NothingAction
            // 
            this.NothingAction.AutoSize = true;
            this.NothingAction.Checked = true;
            this.NothingAction.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NothingAction.Location = new System.Drawing.Point(502, 290);
            this.NothingAction.Name = "NothingAction";
            this.NothingAction.Size = new System.Drawing.Size(113, 34);
            this.NothingAction.TabIndex = 6;
            this.NothingAction.TabStop = true;
            this.NothingAction.Text = "Nothing";
            this.NothingAction.UseVisualStyleBackColor = true;
            this.NothingAction.CheckedChanged += new System.EventHandler(this.NothingAction_CheckedChanged);
            // 
            // TimerWatchDog
            // 
            this.TimerWatchDog.WorkerReportsProgress = true;
            this.TimerWatchDog.WorkerSupportsCancellation = true;
            this.TimerWatchDog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TimerWatchDog_DoWork);
            this.TimerWatchDog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TimerWatchDog_RunWorkerCompleted);
            // 
            // TimerCountdown
            // 
            this.TimerCountdown.WorkerReportsProgress = true;
            this.TimerCountdown.WorkerSupportsCancellation = true;
            this.TimerCountdown.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TimerCountdown_DoWork);
            this.TimerCountdown.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TimerCountdown_RunWorkerCompleted);
            // 
            // SecondsPerTick
            // 
            this.SecondsPerTick.LargeChange = 0;
            this.SecondsPerTick.Location = new System.Drawing.Point(570, 30);
            this.SecondsPerTick.Maximum = 60;
            this.SecondsPerTick.Minimum = 10;
            this.SecondsPerTick.Name = "SecondsPerTick";
            this.SecondsPerTick.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SecondsPerTick.Size = new System.Drawing.Size(45, 171);
            this.SecondsPerTick.SmallChange = 0;
            this.SecondsPerTick.TabIndex = 0;
            this.SecondsPerTick.TickFrequency = 10;
            this.SecondsPerTick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SecondsPerTick.Value = 10;
            this.SecondsPerTick.ValueChanged += new System.EventHandler(this.SecondsPerTick_ValueChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 340);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.SecondsPerTick);
            this.Controls.Add(label1);
            this.Controls.Add(this.NothingAction);
            this.Controls.Add(this.RestartAction);
            this.Controls.Add(this.ShutdownAction);
            this.Controls.Add(this.MainSwitch);
            this.Controls.Add(this.LowerTimer);
            this.Controls.Add(this.RiseTimer);
            this.Controls.Add(this.TimeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TirtaShutdownTimer";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsPerTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Button RiseTimer;
        private System.Windows.Forms.Button LowerTimer;
        private System.Windows.Forms.Button MainSwitch;
        private System.Windows.Forms.RadioButton ShutdownAction;
        private System.Windows.Forms.RadioButton RestartAction;
        private System.Windows.Forms.RadioButton NothingAction;
        private System.ComponentModel.BackgroundWorker TimerWatchDog;
        private System.ComponentModel.BackgroundWorker TimerCountdown;
        private System.Windows.Forms.TrackBar SecondsPerTick;
    }
}

