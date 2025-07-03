namespace Multi_Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIgual = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnVirgula = new Button();
            btn0 = new Button();
            btnMudarSinal = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnPorcentagem = new Button();
            btnApagar = new Button();
            btnLimpar = new Button();
            lblCalcular = new Label();
            lblConverter = new Label();
            label3 = new Label();
            rtbResultado = new RichTextBox();
            rtbHistorico = new RichTextBox();
            SuspendLayout();
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkOrange;
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Arial", 20F);
            btnIgual.ForeColor = SystemColors.ActiveCaptionText;
            btnIgual.Location = new Point(219, 456);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(63, 63);
            btnIgual.TabIndex = 0;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(64, 64, 64);
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnSoma.FlatStyle = FlatStyle.Popup;
            btnSoma.Font = new Font("Arial", 20F);
            btnSoma.ForeColor = Color.FromArgb(255, 128, 0);
            btnSoma.Location = new Point(219, 387);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(63, 63);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.FromArgb(64, 64, 64);
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Arial", 20F);
            btnSubtracao.ForeColor = Color.FromArgb(255, 128, 0);
            btnSubtracao.Location = new Point(219, 319);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(63, 63);
            btnSubtracao.TabIndex = 2;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(64, 64, 64);
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacao.ForeColor = Color.FromArgb(255, 128, 0);
            btnMultiplicacao.Location = new Point(219, 252);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(63, 63);
            btnMultiplicacao.TabIndex = 3;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(64, 64, 64);
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Arial", 20F);
            btnDivisao.ForeColor = Color.FromArgb(255, 128, 0);
            btnDivisao.Location = new Point(219, 184);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(63, 63);
            btnDivisao.TabIndex = 4;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(64, 64, 64);
            btnVirgula.Cursor = Cursors.Hand;
            btnVirgula.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Arial", 20F);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(150, 456);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(63, 63);
            btnVirgula.TabIndex = 5;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Arial", 20F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(81, 456);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 63);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnMudarSinal
            // 
            btnMudarSinal.BackColor = Color.DarkOrange;
            btnMudarSinal.Cursor = Cursors.Hand;
            btnMudarSinal.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnMudarSinal.FlatStyle = FlatStyle.Popup;
            btnMudarSinal.Font = new Font("Arial", 20F);
            btnMudarSinal.ForeColor = SystemColors.ActiveCaptionText;
            btnMudarSinal.Location = new Point(12, 456);
            btnMudarSinal.Name = "btnMudarSinal";
            btnMudarSinal.Size = new Size(63, 63);
            btnMudarSinal.TabIndex = 7;
            btnMudarSinal.Text = "+/-";
            btnMudarSinal.UseVisualStyleBackColor = false;
            btnMudarSinal.Click += btnMudarSinal_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Arial", 20F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(81, 387);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 63);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Arial", 20F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(150, 387);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 63);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Arial", 20F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 387);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 63);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Arial", 20F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(150, 319);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 63);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Arial", 20F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(81, 319);
            btn5.Name = "btn5";
            btn5.Size = new Size(63, 63);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Arial", 20F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(12, 319);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 63);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Arial", 20F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(150, 252);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 63);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Arial", 20F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(81, 252);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 63);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Arial", 20F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 252);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 63);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.FromArgb(64, 64, 64);
            btnPorcentagem.Cursor = Cursors.Hand;
            btnPorcentagem.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnPorcentagem.FlatStyle = FlatStyle.Popup;
            btnPorcentagem.Font = new Font("Arial", 20F);
            btnPorcentagem.ForeColor = Color.FromArgb(255, 128, 0);
            btnPorcentagem.Location = new Point(150, 184);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.RightToLeft = RightToLeft.No;
            btnPorcentagem.Size = new Size(63, 63);
            btnPorcentagem.TabIndex = 17;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(64, 64, 64);
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            btnApagar.ForeColor = Color.FromArgb(255, 128, 0);
            btnApagar.Location = new Point(81, 184);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(63, 63);
            btnApagar.TabIndex = 18;
            btnApagar.Text = "CE";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.FromArgb(255, 128, 0);
            btnLimpar.Location = new Point(12, 184);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(63, 63);
            btnLimpar.TabIndex = 19;
            btnLimpar.Text = "AC";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblCalcular
            // 
            lblCalcular.AutoSize = true;
            lblCalcular.Cursor = Cursors.Hand;
            lblCalcular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblCalcular.ForeColor = Color.White;
            lblCalcular.Location = new Point(39, 23);
            lblCalcular.Name = "lblCalcular";
            lblCalcular.Size = new Size(86, 24);
            lblCalcular.TabIndex = 20;
            lblCalcular.Text = "Calcular";
            // 
            // lblConverter
            // 
            lblConverter.AutoSize = true;
            lblConverter.Cursor = Cursors.Hand;
            lblConverter.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblConverter.ForeColor = Color.DarkGray;
            lblConverter.Location = new Point(147, 24);
            lblConverter.Name = "lblConverter";
            lblConverter.Size = new Size(101, 24);
            lblConverter.TabIndex = 21;
            lblConverter.Text = "Converter";
            lblConverter.Click += lblConverter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 523);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 22;
            label3.Text = "© Diego Silveira";
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = Color.Black;
            rtbResultado.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbResultado.ForeColor = SystemColors.Window;
            rtbResultado.Location = new Point(12, 96);
            rtbResultado.Multiline = false;
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.RightToLeft = RightToLeft.Yes;
            rtbResultado.ScrollBars = RichTextBoxScrollBars.None;
            rtbResultado.Size = new Size(268, 82);
            rtbResultado.TabIndex = 24;
            rtbResultado.TabStop = false;
            rtbResultado.Text = "";
            rtbResultado.TextChanged += rtbResultado_TextChanged;
            // 
            // rtbHistorico
            // 
            rtbHistorico.BackColor = Color.Black;
            rtbHistorico.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbHistorico.ForeColor = SystemColors.Window;
            rtbHistorico.Location = new Point(12, 64);
            rtbHistorico.Multiline = false;
            rtbHistorico.Name = "rtbHistorico";
            rtbHistorico.ReadOnly = true;
            rtbHistorico.RightToLeft = RightToLeft.No;
            rtbHistorico.ScrollBars = RichTextBoxScrollBars.None;
            rtbHistorico.Size = new Size(268, 26);
            rtbHistorico.TabIndex = 25;
            rtbHistorico.TabStop = false;
            rtbHistorico.Text = "";
            rtbHistorico.TextChanged += rtbHistorico_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(292, 542);
            Controls.Add(rtbHistorico);
            Controls.Add(rtbResultado);
            Controls.Add(label3);
            Controls.Add(lblConverter);
            Controls.Add(lblCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(btnApagar);
            Controls.Add(btnPorcentagem);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnMudarSinal);
            Controls.Add(btn0);
            Controls.Add(btnVirgula);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Calculadora";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIgual;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnVirgula;
        private Button btn0;
        private Button btnMudarSinal;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnPorcentagem;
        private Button btnApagar;
        private Button btnLimpar;
        private Label lblCalcular;
        private Label lblConverter;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox rtbResultado;
        private RichTextBox rtbHistorico;
    }
}
