using System.Drawing;

namespace Multi_Calculadora
{

    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; } // Propriedade para armazenar o resultado da operação
        private decimal Valor { get; set; } // Propriedade para armazenar o primeiro valor da operação
        private Operacao OperacaoSelecionada { get; set; } // Propriedade para armazenar a operação selecionada pelo usuário

        enum Operacao // Enumeração para definir as operações disponíveis na calculadora
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                // Aciona o botão 7 quando a tecla 7 é pressionada
                btn7.PerformClick();
            }
        }

        private void btn7_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbResultado.Clear();
            rtbHistorico.Clear();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "8";
        }

        private void rtbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConverter_Click(object sender, EventArgs e)
        {
            /* Esse método é chamado quando o usuário clica no rótulo "Converter" na interface do usuário.
             * Ele cria uma nova instância do Form2 (que é a janela de conversão) e a exibe, ocultando a janela atual.
             */

            Form converter = new Form2();
            converter.Show();
            this.Visible = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            rtbResultado.Text += "0";
        }

        private void btnMudarSinal_Click(object sender, EventArgs e)
        {
            string texto = rtbResultado.Text;

            if (decimal.TryParse(texto, out decimal numero))
            {
                numero *= -1; // Inverte o sinal do número
                rtbResultado.Text = numero.ToString();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Coloca o último número digitado para o histórico
            rtbHistorico.AppendText(rtbResultado.Text + " = ");
            switch (OperacaoSelecionada) //Verifica qual operação foi selecinada
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(rtbHistorico.Text); // Realiza a adição
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(rtbHistorico.Text); // Realiza a subtração
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(rtbHistorico.Text); // Realiza a muliplicação
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(rtbHistorico.Text); // Realiza a divisão
                    break;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao; //Guarda a operação selecionada como subtração na propriedade OperacaoSelecionada
            Valor = Convert.ToDecimal(rtbResultado.Text); // Converte o texto do campo de resultado para decimal e armazena na propriedade Valor
            rtbHistorico.AppendText(rtbResultado.Text + " - "); // Add o texto do campo de resultado ao histórico com o sinal de subtração
            rtbResultado.Text = ""; // Limpa o campo de resultado
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

            OperacaoSelecionada = Operacao.Multiplicacao; //Guarda a operação selecionada como multiplicação na propriedade OperacaoSelecionada
            Valor = Convert.ToDecimal(rtbResultado.Text); // Converte o texto do campo de resultado para decimal e armazena na propriedade Valor
            rtbResultado.Text = ""; // Limpa o campo de resultado
            rtbHistorico.AppendText(rtbResultado.Text + " * "); // Add o texto do campo de resultado ao histórico com o sinal de multiplicação
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao; // Guarda a operação selecionada como divisão na propriedade OperacaoSelecionada
            Valor = Convert.ToDecimal(rtbResultado.Text); // Converte o texto do campo de resultado para decimal e armazena na propriedade Valor
            rtbHistorico.AppendText(rtbResultado.Text + " / "); // Add o texto do campo de resultado ao histórico com o sinal de divisão
            rtbResultado.Text = ""; // Limpa o campo de resultado
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao; //Guarda a operação selecionada como multiplicação na propriedade OperacaoSelecionada
            Valor = Convert.ToDecimal(rtbResultado.Text); // Converte o texto do campo de resultado para decimal e armazena na propriedade Valor
            rtbHistorico.AppendText(rtbResultado.Text + " + "); // Add o texto do campo de resultado ao histórico com o sinal de adição
            rtbResultado.Text = ""; // Limpa o campo de resultado
            
            //string somar = "+";
            //rtbHistorico.AppendText(somar + rtbResultado.Text);
            //rtbResultado.Clear();
        }

        private void rtbHistorico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
