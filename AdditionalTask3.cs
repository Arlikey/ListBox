using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class AdditionalTask3 : Form
    {
        private const int rows = 3;
        private const int cols = 3;
        private const int mines = 3;
        private Button[,] grid = new Button[rows, cols];
        private bool[,] hasMine = new bool[rows, cols];
        public AdditionalTask3()
        {
            InitializeComponent();
            SetButtons();
            PlaceMines();
        }
        private void SetButtons()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button MineButton = new Button()
                    {
                        Font = new Font(Font.FontFamily, 14, FontStyle.Bold),
                        Width = (flowLayoutPanel1.Width - 20) / 3,
                        Height = (flowLayoutPanel1.Height - 20) / 3
                    };
                    MineButton.Click += MineButton_Click;
                    grid[i, j] = MineButton;
                    flowLayoutPanel1.Controls.Add(MineButton);
                }
            }
        }
        private void PlaceMines()
        {
            Random rand = new Random();
            int minesPlaced = 0;

            while (minesPlaced < mines)
            {
                int row = rand.Next(0, rows);
                int col = rand.Next(0, cols);

                if (!hasMine[row, col])
                {
                    hasMine[row, col] = true;
                    minesPlaced++;
                }
            }
        }
        private void MineButton_Click(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            int row = -1, col = -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == clickedButton)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
            }

            if (hasMine[row, col])
            {
                clickedButton!.Text = "Мина!";
                clickedButton.BackColor = Color.Red;
            }
            else
            {
                int count = CountMinesAround(row, col);
                clickedButton!.Text = count.ToString();
            }

        }

        private int CountMinesAround(int row, int col)
        {
            int count = 0;

            for (int i = Math.Max(0, row - 1); i <= Math.Min(row + 1, rows - 1); i++)
            {
                for (int j = Math.Max(0, col - 1); j <= Math.Min(col + 1, cols - 1); j++)
                {
                    if (hasMine[i, j])
                        count++;
                }
            }

            return count;
        }
    }
}
