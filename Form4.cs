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
    public partial class Form4 : Form
    {
        private string campoSelecionado = "peso"; // valor padrão

        bool limparPeso = true; // Variável para controlar se o texto deve ser limpo ao inserir um novo número
        bool limparAltura = true; // Variável para controlar se o texto deve ser limpo ao inserir um novo número
        bool botaoInverter = false; // Variável para controlar o estado do botão de trocar sinal
        double altura; // Variável para armazenar a altura do usuário
        double peso; // Variável para armazenar o peso do usuário



        public Form4()
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
            btnVirgula.Click += BotaoNumero_Click;
        }

        private void rtbTemp1_TextChanged(object sender, EventArgs e)
        {
            rtbPeso.Clear();
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
            Button botao = (Button)sender;

            if (campoSelecionado == "peso")
            {
                rtbPeso.Text += botao.Text;

            }
            if (campoSelecionado == "altura")
            {
                rtbAltura.Text += botao.Text;

            }


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
            rtbPeso.Clear();
            rtbAltura.Clear();
            rtbIMC.Clear();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            peso = double.Parse(rtbPeso.Text); // Converte o texto do campo de entrada para decimal
            altura = double.Parse(rtbAltura.Text); // Converte o texto do campo de entrada para decimal 
            double resultado = (peso / (altura * altura)); // calculo do IMC
            if (resultado < 18.5)
            {
                rtbIMC.Text = "Abaixo do peso";
            }
            else if (resultado >= 18.5 && resultado <= 24.9)
            {
                rtbIMC.Text = "Peso normal";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                rtbIMC.Text = "Sobrepeso";
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                rtbIMC.Text = "Obesidade grau I";
            }
            else if (resultado >= 35 && resultado <= 39.9)
            {
                rtbIMC.Text = "Obesidade grau II";
            }
            else
            {
                rtbIMC.Text = "Obesidade grau III";
            }
        }

        private void rtbAltura_MouseClick(object sender, MouseEventArgs e)
        {
            campoSelecionado = "altura";
            if (limparAltura)
            {
                rtbAltura.Clear();
                limparAltura = false;
            }
        }

        private void rtbPeso_MouseClick(object sender, MouseEventArgs e)
        {
            campoSelecionado = "peso";
            if (limparPeso)
            {
                rtbPeso.Clear();
                limparPeso = false;
            }
        }

        private void lblVoltar_Click_1(object sender, EventArgs e)
        {
            Form converter = new Form2();
            converter.Show();
            this.Visible = false;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação quando o formulário é fechado
        }

        private void rtbPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

        }
    }
}
