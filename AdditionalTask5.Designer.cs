namespace ListBox
{
    partial class AdditionalTask5
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
            components = new System.ComponentModel.Container();
            TimeFormatGroupBox = new GroupBox();
            Hours24RadioButton = new RadioButton();
            Hours12RadioButton = new RadioButton();
            TimeFormatLabel = new Label();
            TimeGroupBox = new GroupBox();
            CurrentTimeLabel = new Label();
            TimeTextLabel = new Label();
            PeriodNumericUpDown = new NumericUpDown();
            PeriodLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            TimeFormatGroupBox.SuspendLayout();
            TimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PeriodNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TimeFormatGroupBox
            // 
            TimeFormatGroupBox.Controls.Add(Hours24RadioButton);
            TimeFormatGroupBox.Controls.Add(Hours12RadioButton);
            TimeFormatGroupBox.Controls.Add(TimeFormatLabel);
            TimeFormatGroupBox.Dock = DockStyle.Right;
            TimeFormatGroupBox.Location = new Point(221, 0);
            TimeFormatGroupBox.Name = "TimeFormatGroupBox";
            TimeFormatGroupBox.Size = new Size(203, 126);
            TimeFormatGroupBox.TabIndex = 0;
            TimeFormatGroupBox.TabStop = false;
            // 
            // Hours24RadioButton
            // 
            Hours24RadioButton.AutoSize = true;
            Hours24RadioButton.Checked = true;
            Hours24RadioButton.Location = new Point(19, 77);
            Hours24RadioButton.Name = "Hours24RadioButton";
            Hours24RadioButton.Size = new Size(37, 19);
            Hours24RadioButton.TabIndex = 2;
            Hours24RadioButton.TabStop = true;
            Hours24RadioButton.Text = "24";
            Hours24RadioButton.UseVisualStyleBackColor = true;
            // 
            // Hours12RadioButton
            // 
            Hours12RadioButton.AutoSize = true;
            Hours12RadioButton.Location = new Point(19, 52);
            Hours12RadioButton.Name = "Hours12RadioButton";
            Hours12RadioButton.Size = new Size(37, 19);
            Hours12RadioButton.TabIndex = 1;
            Hours12RadioButton.Text = "12";
            Hours12RadioButton.UseVisualStyleBackColor = true;
            // 
            // TimeFormatLabel
            // 
            TimeFormatLabel.AutoSize = true;
            TimeFormatLabel.Location = new Point(6, 19);
            TimeFormatLabel.Name = "TimeFormatLabel";
            TimeFormatLabel.Size = new Size(107, 15);
            TimeFormatLabel.TabIndex = 0;
            TimeFormatLabel.Text = "Формат времени :";
            // 
            // TimeGroupBox
            // 
            TimeGroupBox.Controls.Add(CurrentTimeLabel);
            TimeGroupBox.Controls.Add(TimeTextLabel);
            TimeGroupBox.Controls.Add(PeriodNumericUpDown);
            TimeGroupBox.Controls.Add(PeriodLabel);
            TimeGroupBox.Dock = DockStyle.Fill;
            TimeGroupBox.Location = new Point(0, 0);
            TimeGroupBox.Name = "TimeGroupBox";
            TimeGroupBox.Size = new Size(221, 126);
            TimeGroupBox.TabIndex = 1;
            TimeGroupBox.TabStop = false;
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CurrentTimeLabel.Location = new Point(92, 86);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(0, 21);
            CurrentTimeLabel.TabIndex = 3;
            // 
            // TimeTextLabel
            // 
            TimeTextLabel.AutoSize = true;
            TimeTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TimeTextLabel.Location = new Point(12, 86);
            TimeTextLabel.Name = "TimeTextLabel";
            TimeTextLabel.Size = new Size(65, 20);
            TimeTextLabel.TabIndex = 2;
            TimeTextLabel.Text = "Время : ";
            // 
            // PeriodNumericUpDown
            // 
            PeriodNumericUpDown.Location = new Point(114, 39);
            PeriodNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PeriodNumericUpDown.Name = "PeriodNumericUpDown";
            PeriodNumericUpDown.Size = new Size(101, 23);
            PeriodNumericUpDown.TabIndex = 1;
            PeriodNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PeriodNumericUpDown.ValueChanged += PeriodNumericUpDown_ValueChanged;
            // 
            // PeriodLabel
            // 
            PeriodLabel.AutoSize = true;
            PeriodLabel.Location = new Point(12, 41);
            PeriodLabel.Name = "PeriodLabel";
            PeriodLabel.Size = new Size(103, 15);
            PeriodLabel.TabIndex = 0;
            PeriodLabel.Text = "Периодичность : ";
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // AdditionalTask5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 126);
            Controls.Add(TimeGroupBox);
            Controls.Add(TimeFormatGroupBox);
            Name = "AdditionalTask5";
            Text = "AdditionalTask5";
            Load += AdditionalTask5_Load;
            TimeFormatGroupBox.ResumeLayout(false);
            TimeFormatGroupBox.PerformLayout();
            TimeGroupBox.ResumeLayout(false);
            TimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PeriodNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TimeFormatGroupBox;
        private GroupBox TimeGroupBox;
        private Label TimeFormatLabel;
        private RadioButton Hours24RadioButton;
        private RadioButton Hours12RadioButton;
        private NumericUpDown PeriodNumericUpDown;
        private Label PeriodLabel;
        private Label CurrentTimeLabel;
        private Label TimeTextLabel;
        private System.Windows.Forms.Timer Timer;
    }
}