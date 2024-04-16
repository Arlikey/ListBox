namespace ListBox
{
    partial class MainTask
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
            TextDataListBox = new System.Windows.Forms.ListBox();
            DataTextBox = new TextBox();
            TransferDataButton = new Button();
            ToListTextBox = new TextBox();
            AddToListButton = new Button();
            SuspendLayout();
            // 
            // TextDataListBox
            // 
            TextDataListBox.FormattingEnabled = true;
            TextDataListBox.ItemHeight = 15;
            TextDataListBox.Location = new Point(265, 71);
            TextDataListBox.Name = "TextDataListBox";
            TextDataListBox.Size = new Size(120, 94);
            TextDataListBox.TabIndex = 0;
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(548, 71);
            DataTextBox.Multiline = true;
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(166, 94);
            DataTextBox.TabIndex = 1;
            // 
            // TransferDataButton
            // 
            TransferDataButton.Location = new Point(413, 199);
            TransferDataButton.Name = "TransferDataButton";
            TransferDataButton.Size = new Size(75, 23);
            TransferDataButton.TabIndex = 2;
            TransferDataButton.Text = "Transfer";
            TransferDataButton.UseVisualStyleBackColor = true;
            TransferDataButton.Click += TransferDataButton_Click;
            // 
            // ToListTextBox
            // 
            ToListTextBox.Location = new Point(114, 71);
            ToListTextBox.Name = "ToListTextBox";
            ToListTextBox.Size = new Size(100, 23);
            ToListTextBox.TabIndex = 3;
            // 
            // AddToListButton
            // 
            AddToListButton.Location = new Point(125, 115);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.Size = new Size(75, 23);
            AddToListButton.TabIndex = 4;
            AddToListButton.Text = "Add to List";
            AddToListButton.UseVisualStyleBackColor = true;
            AddToListButton.Click += AddToListButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddToListButton);
            Controls.Add(ToListTextBox);
            Controls.Add(TransferDataButton);
            Controls.Add(DataTextBox);
            Controls.Add(TextDataListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox TextDataListBox;
        private TextBox DataTextBox;
        private Button TransferDataButton;
        private TextBox ToListTextBox;
        private Button AddToListButton;
    }
}
