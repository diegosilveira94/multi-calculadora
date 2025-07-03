namespace Multi_Calculadora
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            rtbAltura = new RichTextBox();
            btnInverter = new Button();
            lblConverter = new Label();
            lblVoltar = new Label();
            rtbPeso = new RichTextBox();
            label3 = new Label();
            btnApagar = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnConverter = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            rtbIMC = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAltura
            // 
            rtbAltura.BackColor = Color.Black;
            rtbAltura.Cursor = Cursors.IBeam;
            rtbAltura.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            rtbAltura.ForeColor = SystemColors.InactiveCaption;
            rtbAltura.Location = new Point(40, 111);
            rtbAltura.Multiline = false;
            rtbAltura.Name = "rtbAltura";
            rtbAltura.ScrollBars = RichTextBoxScrollBars.None;
            rtbAltura.Size = new Size(201, 47);
            rtbAltura.TabIndex = 75;
            rtbAltura.TabStop = false;
            rtbAltura.Text = "Altura";
            rtbAltura.MouseClick += rtbAltura_MouseClick;
            // 
            // btnInverter
            // 
            btnInverter.BackColor = Color.FromArgb(64, 64, 64);
            btnInverter.Cursor = Cursors.Hand;
            btnInverter.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnInverter.FlatStyle = FlatStyle.Popup;
            btnInverter.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInverter.ForeColor = Color.FromArgb(255, 128, 0);
            btnInverter.Location = new Point(178, 220);
            btnInverter.Name = "btnInverter";
            btnInverter.Size = new Size(63, 63);
            btnInverter.TabIndex = 74;
            btnInverter.Text = "⇅";
            btnInverter.UseVisualStyleBackColor = false;
            // 
            // lblConverter
            // 
            lblConverter.AutoSize = true;
            lblConverter.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblConverter.ForeColor = Color.White;
            lblConverter.Location = new Point(120, 16);
            lblConverter.Name = "lblConverter";
            lblConverter.Size = new Size(46, 24);
            lblConverter.TabIndex = 73;
            lblConverter.Text = "IMC";
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.Cursor = Cursors.Hand;
            lblVoltar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVoltar.ForeColor = Color.DarkGray;
            lblVoltar.Location = new Point(35, 13);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(24, 24);
            lblVoltar.TabIndex = 72;
            lblVoltar.Text = "↩";
            lblVoltar.Click += lblVoltar_Click_1;
            lblVoltar.MouseLeave += lblVoltar_MouseLeave;
            lblVoltar.MouseMove += lblVoltar_MouseMove;
            // 
            // rtbPeso
            // 
            rtbPeso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rtbPeso.BackColor = Color.Black;
            rtbPeso.Cursor = Cursors.IBeam;
            rtbPeso.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            rtbPeso.ForeColor = SystemColors.InactiveCaption;
            rtbPeso.Location = new Point(40, 58);
            rtbPeso.Multiline = false;
            rtbPeso.Name = "rtbPeso";
            rtbPeso.ScrollBars = RichTextBoxScrollBars.None;
            rtbPeso.Size = new Size(201, 47);
            rtbPeso.TabIndex = 71;
            rtbPeso.TabStop = false;
            rtbPeso.Text = "Peso";
            rtbPeso.MouseClick += rtbPeso_MouseClick;
            rtbPeso.TextChanged += rtbPeso_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(38, 562);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 70;
            label3.Text = "© Diego Silveira";
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(64, 64, 64);
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            btnApagar.ForeColor = Color.FromArgb(255, 128, 0);
            btnApagar.Location = new Point(40, 492);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(63, 63);
            btnApagar.TabIndex = 69;
            btnApagar.Text = "CE";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Arial", 20F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(40, 288);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 63);
            btn7.TabIndex = 68;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Arial", 20F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(109, 288);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 63);
            btn8.TabIndex = 67;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Arial", 20F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(178, 288);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 63);
            btn9.TabIndex = 66;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Arial", 20F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(40, 355);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 63);
            btn4.TabIndex = 65;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Arial", 20F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(109, 355);
            btn5.Name = "btn5";
            btn5.Size = new Size(63, 63);
            btn5.TabIndex = 64;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Arial", 20F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(178, 355);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 63);
            btn6.TabIndex = 63;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Arial", 20F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(40, 423);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 63);
            btn1.TabIndex = 62;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Arial", 20F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(178, 423);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 63);
            btn3.TabIndex = 61;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Arial", 20F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(109, 423);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 63);
            btn2.TabIndex = 60;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.DarkOrange;
            btnConverter.Cursor = Cursors.Hand;
            btnConverter.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnConverter.FlatStyle = FlatStyle.Popup;
            btnConverter.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.ForeColor = SystemColors.ButtonHighlight;
            btnConverter.Location = new Point(40, 220);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(132, 63);
            btnConverter.TabIndex = 59;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Arial", 20F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(109, 492);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 63);
            btn0.TabIndex = 58;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(64, 64, 64);
            btnVirgula.Cursor = Cursors.Hand;
            btnVirgula.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Arial", 20F);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(178, 492);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(63, 63);
            btnVirgula.TabIndex = 57;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // rtbIMC
            // 
            rtbIMC.BackColor = Color.Black;
            rtbIMC.Cursor = Cursors.IBeam;
            rtbIMC.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            rtbIMC.ForeColor = SystemColors.InactiveCaption;
            rtbIMC.Location = new Point(40, 164);
            rtbIMC.Multiline = false;
            rtbIMC.Name = "rtbIMC";
            rtbIMC.ScrollBars = RichTextBoxScrollBars.None;
            rtbIMC.Size = new Size(201, 47);
            rtbIMC.TabIndex = 76;
            rtbIMC.TabStop = false;
            rtbIMC.Text = "IMC";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(277, 590);
            Controls.Add(rtbIMC);
            Controls.Add(rtbAltura);
            Controls.Add(btnInverter);
            Controls.Add(lblConverter);
            Controls.Add(lblVoltar);
            Controls.Add(rtbPeso);
            Controls.Add(label3);
            Controls.Add(btnApagar);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnConverter);
            Controls.Add(btn0);
            Controls.Add(btnVirgula);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            FormClosed += Form4_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbAltura;
        private Button btnInverter;
        private Label lblConverter;
        private Label lblVoltar;
        private RichTextBox rtbPeso;
        private Label label3;
        private Button btnApagar;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btnConverter;
        private Button btn0;
        private Button btnVirgula;
        private RichTextBox rtbIMC;
    }
}