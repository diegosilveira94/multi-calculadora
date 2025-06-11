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
    }
}
