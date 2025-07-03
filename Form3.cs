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
        bool limparTexto = true; // Variável para controlar se o texto deve ser limpo ao inserir um novo número
        bool botaoInverter = false; // Variável para controlar o estado do botão de trocar sinal

        public decimal Resultado { get; private set; }

        public Form3()
        {
            InitializeComponent();
            btn0.Click += BotaoNumero_Click;
            btn1.Click += BotaoNumero_Click;
            btn2.Click += BotaoNumero_Click;
            btn3.Click += BotaoNumero_Click;
            btn4.Click += BotaoNumero_Click;
            btn5.Click += BotaoNumero_Click;
            btn6.Click += BotaoNumero_Click;
            btn7.Click += BotaoNumero_Click;
            btn8.Click += BotaoNumero_Click;
            btn9.Click += BotaoNumero_Click;
        }

        private void rtbTemp1_TextChanged(object sender, EventArgs e)
        {
            rtbTemp2.Clear();
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

        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            if (limparTexto)
            {
                rtbTemp1.Clear();
                limparTexto = false;
            }

            Button botao = (Button)sender;
            rtbTemp1.Text += botao.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            rtbTemp1.Clear();
            rtbTemp2.Clear();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Resultado = Convert.ToDecimal(rtbTemp1.Text); // Converte o texto do campo de entrada para decimal
            Resultado = (Resultado * 9 / 5) + 32; // Converte Celsius para Fahrenheit
            rtbTemp2.Text = Resultado.ToString("F1"); // Exibe o resultado formatado com duas casas decimais
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            botaoInverter = true; // Ativa o estado do botão de trocar sinal
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação quando o formulário é fechado
        }
    }
}

