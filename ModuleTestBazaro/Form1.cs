using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleTestBazaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelSquare.Text = string.Empty + " m2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            try
            {
                int n = Convert.ToInt32(textBox1.Text);

                Animal[] animals = new Animal[n * 4];

                for (int i = 0; i < animals.Length; i += 4)
                {
                    animals[i] = new Animal($"Звір", new Enclosure(3, 4));
                    animals[i + 1] = new Animal($"Буйвол", new Enclosure(5, 6)); 
                    animals[i + 2] = new Animal($"Бегемот", new LakeEnclosure(6, 7)); 
                    animals[i + 3] = new Animal($"Екзотична тварина", new ExoticEnclosure(10, 5, 3, 3));
                }

                double totalArea = 0;
                foreach (var animal in animals)
                {
                    listBox1.Items.Add(animal.Show());
                    totalArea += animal.Enclosure.Area;
                }

                labelSquare.Text = totalArea.ToString() + " m2";
            }
            catch (FormatException)
            {
                throw new Exception("\"Некоректне введення. Будь ласка, введіть ціле число.\"");
            }
            catch (Exception ex)
            {
                throw new Exception($"\"Помилка: {ex.Message}\"");
            }
        }

    }
}
