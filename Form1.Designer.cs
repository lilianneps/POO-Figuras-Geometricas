namespace FormasGeometricas
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
            comboFiguras = new ComboBox();
            textBox1 = new TextBox();
            lblValor1 = new Label();
            txtValor1 = new TextBox();
            lblValor2 = new Label();
            txtValor2 = new TextBox();
            lblValor3 = new Label();
            txtValor3 = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // comboFiguras
            // 
            comboFiguras.BackColor = SystemColors.Info;
            comboFiguras.Font = new Font("Segoe UI", 12F);
            comboFiguras.FormattingEnabled = true;
            comboFiguras.Location = new Point(144, 69);
            comboFiguras.Name = "comboFiguras";
            comboFiguras.RightToLeft = RightToLeft.No;
            comboFiguras.Size = new Size(305, 36);
            comboFiguras.TabIndex = 0;
            comboFiguras.Text = "Escolha uma forma geométrica";
            comboFiguras.SelectedIndexChanged += comboFiguras_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(175, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 38);
            textBox1.TabIndex = 1;
            textBox1.Text = "Formas Geométricas";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new Font("Segoe UI", 12F);
            lblValor1.Location = new Point(43, 135);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(73, 28);
            lblValor1.TabIndex = 2;
            lblValor1.Text = "Valor 1";
            // 
            // txtValor1
            // 
            txtValor1.Font = new Font("Segoe UI", 12F);
            txtValor1.Location = new Point(26, 166);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(106, 34);
            txtValor1.TabIndex = 3;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new Font("Segoe UI", 12F);
            lblValor2.Location = new Point(220, 135);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(73, 28);
            lblValor2.TabIndex = 4;
            lblValor2.Text = "Valor 2";
            // 
            // txtValor2
            // 
            txtValor2.Font = new Font("Segoe UI", 12F);
            txtValor2.Location = new Point(206, 166);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(106, 34);
            txtValor2.TabIndex = 5;
            // 
            // lblValor3
            // 
            lblValor3.AutoSize = true;
            lblValor3.Font = new Font("Segoe UI", 12F);
            lblValor3.Location = new Point(407, 135);
            lblValor3.Name = "lblValor3";
            lblValor3.Size = new Size(73, 28);
            lblValor3.TabIndex = 6;
            lblValor3.Text = "Valor 3";
            // 
            // txtValor3
            // 
            txtValor3.Font = new Font("Segoe UI", 12F);
            txtValor3.Location = new Point(391, 166);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(106, 34);
            txtValor3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.Location = new Point(572, 160);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(136, 40);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(291, 264);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmar.Location = new Point(477, 69);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 40);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(btnConfirmar);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor3);
            Controls.Add(lblValor3);
            Controls.Add(txtValor2);
            Controls.Add(lblValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblValor1);
            Controls.Add(textBox1);
            Controls.Add(comboFiguras);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboFiguras;
        private TextBox textBox1;
        private Label lblValor1;
        private TextBox txtValor1;
        private Label lblValor2;
        private TextBox txtValor2;
        private Label lblValor3;
        private TextBox txtValor3;
        private Button btnCalcular;
        private Label lblResultado;
        private Button btnConfirmar;
    }
}
