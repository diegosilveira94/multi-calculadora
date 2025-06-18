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
            btnMoeda = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblConverter
            // 
            lblConverter.AutoSize = true;
            lblConverter.Cursor = Cursors.Hand;
            lblConverter.Font = new Font("Montserrat", 14.25F, FontStyle.Bold);
            lblConverter.ForeColor = Color.White;
            lblConverter.Location = new Point(145, 29);
            lblConverter.Name = "lblConverter";
            lblConverter.Size = new Size(111, 30);
            lblConverter.TabIndex = 23;
            lblConverter.Text = "Converter";
            lblConverter.Click += lblConverter_Click;
            // 
            // lblCalcular
            // 
            lblCalcular.AutoSize = true;
            lblCalcular.Cursor = Cursors.Hand;
            lblCalcular.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcular.ForeColor = Color.DarkGray;
            lblCalcular.Location = new Point(38, 29);
            lblCalcular.Name = "lblCalcular";
            lblCalcular.Size = new Size(95, 30);
            lblCalcular.TabIndex = 22;
            lblCalcular.Text = "Calcular";
            lblCalcular.Click += lblCalcular_Click;
            // 
            // btnMoeda
            // 
            btnMoeda.AccessibleRole = AccessibleRole.Animation;
            btnMoeda.AutoSize = true;
            btnMoeda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMoeda.FlatAppearance.BorderColor = Color.White;
            btnMoeda.FlatAppearance.BorderSize = 0;
            btnMoeda.Image = Properties.Resources.moeda;
            btnMoeda.Location = new Point(16, 118);
            btnMoeda.Margin = new Padding(0);
            btnMoeda.Name = "btnMoeda";
            btnMoeda.Size = new Size(78, 78);
            btnMoeda.TabIndex = 24;
            btnMoeda.UseVisualStyleBackColor = true;
            btnMoeda.Click += btnMoeda_Click;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Animation;
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Image = Properties.Resources.temperatura;
            button1.Location = new Point(107, 118);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(78, 78);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Animation;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(198, 118);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(78, 78);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(292, 542);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMoeda);
            Controls.Add(lblConverter);
            Controls.Add(lblCalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Calculadora";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConverter;
        private Label lblCalcular;
        private Button btnMoeda;
        private Button button1;
        private Button button2;
    }
}