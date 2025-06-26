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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void rtbTemp1_TextChanged(object sender, EventArgs e)
        {
            rtbTemp2.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            rtbTemp1.Clear();
            rtbTemp2.Clear();
            rtbTemp1.Text += "0";
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            Form converter = new Form2();
            converter.Show();
            this.Visible = false;
        }

        private void lblVoltar_MouseMove(object sender, MouseEventArgs e)
        {
            // Muda o forecolor ao passar o mouse
            lblVoltar.ForeColor = Color.White;
        }

        private void lblVoltar_MouseLeave(object sender, EventArgs e)
        {
            // Muda o forecolor a cor anterior mouse sair
            lblVoltar.ForeColor = Color.DarkGray;
        }
    }
}
