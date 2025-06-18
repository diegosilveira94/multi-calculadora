namespace Multi_Calculadora
{
    public partial class Form1 : Form
    {
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

        private void btnSoma_Click(object sender, EventArgs e)
        {
            /* Esse método é chamado quando o usuário clica no botão de soma.
             * Ele verifica se o campo de resultado não está vazio, converte o texto para decimal,
             * e adiciona o valor ao histórico e ao resultado.
             */
            string somar = "+";
            rtbHistorico.AppendText(somar + rtbResultado.Text);
            rtbResultado.Clear();
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

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
