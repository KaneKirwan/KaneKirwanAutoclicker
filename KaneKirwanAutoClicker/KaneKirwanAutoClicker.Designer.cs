namespace KaneKirwanAutoClicker
{
    partial class KaneKirwanAutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaneKirwanAutoClicker));
            this.AutoClicker = new System.Windows.Forms.Label();
            this.ClickInterval = new System.Windows.Forms.Label();
            this.ClickOptions = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LeftClick = new System.Windows.Forms.RadioButton();
            this.RightClick = new System.Windows.Forms.RadioButton();
            this.MiddleClick = new System.Windows.Forms.RadioButton();
            this.Interval = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AutoClicker
            // 
            this.AutoClicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoClicker.AutoSize = true;
            this.AutoClicker.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoClicker.Location = new System.Drawing.Point(175, 10);
            this.AutoClicker.Margin = new System.Windows.Forms.Padding(0);
            this.AutoClicker.Name = "AutoClicker";
            this.AutoClicker.Size = new System.Drawing.Size(154, 32);
            this.AutoClicker.TabIndex = 0;
            this.AutoClicker.Text = "AutoClicker";
            this.AutoClicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickInterval
            // 
            this.ClickInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickInterval.AutoSize = true;
            this.ClickInterval.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickInterval.Location = new System.Drawing.Point(10, 70);
            this.ClickInterval.Margin = new System.Windows.Forms.Padding(0);
            this.ClickInterval.Name = "ClickInterval";
            this.ClickInterval.Size = new System.Drawing.Size(87, 16);
            this.ClickInterval.TabIndex = 0;
            this.ClickInterval.Text = "Click Interval";
            this.ClickInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickOptions
            // 
            this.ClickOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickOptions.AutoSize = true;
            this.ClickOptions.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickOptions.Location = new System.Drawing.Point(10, 130);
            this.ClickOptions.Margin = new System.Windows.Forms.Padding(0);
            this.ClickOptions.Name = "ClickOptions";
            this.ClickOptions.Size = new System.Drawing.Size(90, 16);
            this.ClickOptions.TabIndex = 0;
            this.ClickOptions.Text = "Click Options";
            this.ClickOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Location = new System.Drawing.Point(100, 250);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 50);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stop.Location = new System.Drawing.Point(300, 250);
            this.Stop.Margin = new System.Windows.Forms.Padding(0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 50);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LeftClick
            // 
            this.LeftClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftClick.AutoSize = true;
            this.LeftClick.Checked = true;
            this.LeftClick.Location = new System.Drawing.Point(10, 150);
            this.LeftClick.Margin = new System.Windows.Forms.Padding(0);
            this.LeftClick.Name = "LeftClick";
            this.LeftClick.Size = new System.Drawing.Size(83, 20);
            this.LeftClick.TabIndex = 0;
            this.LeftClick.TabStop = true;
            this.LeftClick.Text = "Left Click";
            this.LeftClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftClick.UseVisualStyleBackColor = true;
            // 
            // RightClick
            // 
            this.RightClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightClick.AutoSize = true;
            this.RightClick.Location = new System.Drawing.Point(10, 170);
            this.RightClick.Margin = new System.Windows.Forms.Padding(0);
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(92, 20);
            this.RightClick.TabIndex = 0;
            this.RightClick.Text = "Right Click";
            this.RightClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightClick.UseVisualStyleBackColor = true;
            // 
            // MiddleClick
            // 
            this.MiddleClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiddleClick.AutoSize = true;
            this.MiddleClick.Location = new System.Drawing.Point(10, 190);
            this.MiddleClick.Margin = new System.Windows.Forms.Padding(0);
            this.MiddleClick.Name = "MiddleClick";
            this.MiddleClick.Size = new System.Drawing.Size(100, 20);
            this.MiddleClick.TabIndex = 0;
            this.MiddleClick.Text = "Middle Click";
            this.MiddleClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiddleClick.UseVisualStyleBackColor = true;
            // 
            // Interval
            // 
            this.Interval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Interval.BackColor = System.Drawing.Color.White;
            this.Interval.ForeColor = System.Drawing.Color.Black;
            this.Interval.Location = new System.Drawing.Point(10, 90);
            this.Interval.Margin = new System.Windows.Forms.Padding(0);
            this.Interval.MaxLength = 1000;
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(100, 23);
            this.Interval.TabIndex = 0;
            this.Interval.Text = "1";
            // 
            // KaneKirwanAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.MiddleClick);
            this.Controls.Add(this.RightClick);
            this.Controls.Add(this.LeftClick);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ClickOptions);
            this.Controls.Add(this.ClickInterval);
            this.Controls.Add(this.AutoClicker);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KaneKirwanAutoClicker";
            this.Text = "KaneKirwanAutoClicker";
            this.Load += new System.EventHandler(this.KaneKirwanAutoClicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AutoClicker;
        private Label ClickInterval;
        private Label ClickOptions;
        private Button Start;
        private Button Stop;
        private RadioButton LeftClick;
        private RadioButton RightClick;
        private RadioButton MiddleClick;
        private TextBox Interval;
    }
}