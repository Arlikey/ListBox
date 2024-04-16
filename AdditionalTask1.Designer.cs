namespace ListBox
{
    partial class AdditionalTask1
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
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            WeightTextBox = new TextBox();
            CountryTextBox = new TextBox();
            AddToListButton = new Button();
            NameLabel = new Label();
            AgeLabel = new Label();
            WeightLabel = new Label();
            CountryLabel = new Label();
            UsersListBox = new System.Windows.Forms.ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(76, 124);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(76, 164);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(100, 23);
            AgeTextBox.TabIndex = 1;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(76, 206);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(100, 23);
            WeightTextBox.TabIndex = 2;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(76, 245);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(100, 23);
            CountryTextBox.TabIndex = 3;
            // 
            // AddToListButton
            // 
            AddToListButton.Location = new Point(89, 287);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.Size = new Size(75, 23);
            AddToListButton.TabIndex = 4;
            AddToListButton.Text = "Добавить";
            AddToListButton.UseVisualStyleBackColor = true;
            AddToListButton.Click += AddToListButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(33, 127);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(37, 15);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Имя :";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(14, 167);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(56, 15);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Возраст :";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(38, 209);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(32, 15);
            WeightLabel.TabIndex = 5;
            WeightLabel.Text = "Вес :";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(20, 248);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(52, 15);
            CountryLabel.TabIndex = 5;
            CountryLabel.Text = "Страна :";
            // 
            // UsersListBox
            // 
            UsersListBox.Dock = DockStyle.Fill;
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(0, 0);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(600, 450);
            UsersListBox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(AgeTextBox);
            panel1.Controls.Add(CountryLabel);
            panel1.Controls.Add(WeightTextBox);
            panel1.Controls.Add(WeightLabel);
            panel1.Controls.Add(CountryTextBox);
            panel1.Controls.Add(AgeLabel);
            panel1.Controls.Add(AddToListButton);
            panel1.Controls.Add(NameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(UsersListBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 8;
            // 
            // AdditionalTask1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdditionalTask1";
            Text = "AdditionalTask1";
            Load += AdditionalTask1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private TextBox WeightTextBox;
        private TextBox CountryTextBox;
        private Button AddToListButton;
        private Label NameLabel;
        private Label AgeLabel;
        private Label WeightLabel;
        private Label CountryLabel;
        private System.Windows.Forms.ListBox UsersListBox;
        private Panel panel1;
        private Panel panel2;
    }
}