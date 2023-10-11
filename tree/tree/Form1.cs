using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            bool a1,b1,c1;
            Double a,b,c;
            a1 = Double.TryParse(at.Text, out a);
            b1 = Double.TryParse(bt.Text, out b);
            c1 = Double.TryParse(ct.Text, out c);
            if ((a1 && b1 && c1 ) == true)
            {
                if (a<1 ||  b<1 || c<1)
                {
                    MessageBox.Show("Число должно быть больше 0!");
                }
                else
                {
                    if (a==b && a==c)
                    {
                        MessageBox.Show("Треугольник равносторонний");
                    }
                    else if (a==b ||  a==c || b==c)
                    {
                        MessageBox.Show("Треугольник равнобедренный");
                    }
                    else
                    {
                        MessageBox.Show("Треугольник разносторонний");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введено не число!");
            }
        }
    }
}
