namespace Multi_Calculadora
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblConverter = new Label();
            lblCalcular = new Label();
            ptbMoeda = new PictureBox();
            ptbTemperatura = new PictureBox();
            ptbImc = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbMoeda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbImc).BeginInit();
            SuspendLayout();
            // 
            // lblConverter
            // 
            lblConverter.AutoSize = true;
            lblConverter.Cursor = Cursors.Hand;
            lblConverter.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblConverter.ForeColor = Color.White;
            lblConverter.Location = new Point(145, 29);
            lblConverter.Name = "lblConverter";
            lblConverter.Size = new Size(101, 24);
            lblConverter.TabIndex = 23;
            lblConverter.Text = "Converter";
            lblConverter.Click += lblConverter_Click;
            // 
            // lblCalcular
            // 
            lblCalcular.AutoSize = true;
            lblCalcular.Cursor = Cursors.Hand;
            lblCalcular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcular.ForeColor = Color.DarkGray;
            lblCalcular.Location = new Point(38, 29);
            lblCalcular.Name = "lblCalcular";
            lblCalcular.Size = new Size(86, 24);
            lblCalcular.TabIndex = 22;
            lblCalcular.Text = "Calcular";
            lblCalcular.Click += lblCalcular_Click;
            // 
            // ptbMoeda
            // 
            ptbMoeda.Cursor = Cursors.Hand;
            ptbMoeda.Image = Properties.Resources.moeda;
            ptbMoeda.Location = new Point(23, 120);
            ptbMoeda.Name = "ptbMoeda";
            ptbMoeda.Size = new Size(79, 76);
            ptbMoeda.TabIndex = 27;
            ptbMoeda.TabStop = false;
            ptbMoeda.Click += ptbMoeda_Click;
            // 
            // ptbTemperatura
            // 
            ptbTemperatura.Cursor = Cursors.Hand;
            ptbTemperatura.Image = Properties.Resources.temperatura;
            ptbTemperatura.Location = new Point(108, 120);
            ptbTemperatura.Name = "ptbTemperatura";
            ptbTemperatura.Size = new Size(79, 76);
            ptbTemperatura.TabIndex = 28;
            ptbTemperatura.TabStop = false;
            ptbTemperatura.Click += ptbTemperatura_Click;
            // 
            // ptbImc
            // 
            ptbImc.Cursor = Cursors.Hand;
            ptbImc.Image = Properties.Resources.IMC;
            ptbImc.Location = new Point(193, 120);
            ptbImc.Name = "ptbImc";
            ptbImc.Size = new Size(79, 76);
            ptbImc.TabIndex = 29;
            ptbImc.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(292, 542);
            Controls.Add(ptbImc);
            Controls.Add(ptbTemperatura);
            Controls.Add(ptbMoeda);
            Controls.Add(lblConverter);
            Controls.Add(lblCalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Calculadora";
            ((System.ComponentModel.ISupportInitialize)ptbMoeda).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbImc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConverter;
        private Label lblCalcular;
        private PictureBox ptbMoeda;
        private PictureBox ptbTemperatura;
        private PictureBox ptbImc;
    }
}