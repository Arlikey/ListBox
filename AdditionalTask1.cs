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
    public partial class AdditionalTask1 : Form
    {
        public class User
        {
            public string? Name { get; set; }
            public int Age { get; set; }
            public float Weight { get; set; }
            public string? Country { get; set; }
            public override string ToString()
            {
                return $"Имя - {Name}, Возраст - {Age}, Вес - {Weight}, Страна - {Country}";
            }
        }

        public AdditionalTask1()
        {
            InitializeComponent();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Name = NameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text),
                Weight = float.Parse(WeightTextBox.Text),
                Country = CountryTextBox.Text
            };

            UsersListBox.Items.Add(newUser);

            NameTextBox.Clear();
            AgeTextBox.Clear();
            WeightTextBox.Clear();
            CountryTextBox.Clear();
        }

        private void AdditionalTask1_Load(object sender, EventArgs e)
        {

        }
    }
}
