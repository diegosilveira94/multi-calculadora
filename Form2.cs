using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblCalcular_Click(object sender, EventArgs e)
        {
            Form calcular = new Form1();
            calcular.Show();
            this.Visible = false;
        }

        private void lblConverter_Click(object sender, EventArgs e)
        {

        }

        private void ptbMoeda_Click(object sender, EventArgs e)
        {
            Form converter = new Form5();
            converter.Show();
            this.Visible = false;
        }

        private void ptbTemperatura_Click(object sender, EventArgs e)
        {
            Form converter = new Form3();
            converter.Show();
            this.Visible = false;
        }
    }
}
