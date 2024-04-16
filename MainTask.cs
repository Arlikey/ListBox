namespace ListBox
{
    public partial class MainTask : Form
    {
        public MainTask()
        {
            InitializeComponent();
        }

        private void TransferDataButton_Click(object sender, EventArgs e)
        {
            DataTextBox.AppendText(TextDataListBox.SelectedItem?.ToString() + Environment.NewLine);
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            TextDataListBox.Items.Add(ToListTextBox.Text);
            ToListTextBox.Clear();
        }
    }
}