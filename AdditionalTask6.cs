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
    public partial class AdditionalTask6 : Form
    {
        private int rows = 10;
        private int cols = 5;
        private int[,] matrix;
        public AdditionalTask6()
        {
            InitializeComponent();

        }

        private void CreateMatrix()
        {
            Random random = new Random();
            matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
        }

        private void FillDataGridView()
        {
            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1[j, i].Value = matrix[i, j];
                }
            }
        }

        private void AdditionalTask6_Load(object sender, EventArgs e)
        {
            CreateMatrix();
            FillDataGridView();
            GetColumnWithFrequentLeastValue();
        }

        private void GetColumnWithFrequentLeastValue()
        {
            int[] minCount = new int[cols];
            int min = int.MaxValue;

            for (int i = 0; i < cols; i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < rows; j++)
                {
                    int currentValue = (int)dataGridView1[i, j].Value;
                    if (currentValue < min)
                    {
                        min = currentValue;
                        minCount[i] = 1;
                    }
                    else if (currentValue == min)
                    {
                        minCount[i]++;
                    }
                }
            }

            int maxIndex = 0;
            for (int j = 1; j < minCount.Length; j++)
            {
                if (minCount[j] > minCount[maxIndex])
                {
                    maxIndex = j;
                }
            }

            MessageBox.Show($"Столбец с наименьшим значением, встречающимся чаще всего: {maxIndex + 1}");
        }
    }
}
