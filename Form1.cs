using FormasGeometricas.Entidades;
using System;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class Form1 : Form
    {
        private bool formaConfirmada = false;

        public Form1()
        {
            InitializeComponent();
            lblValor1.Visible = false;
            txtValor1.Visible = false;
            lblValor2.Visible = false;
            txtValor2.Visible = false;
            lblValor3.Visible = false;
            txtValor3.Visible = false;

            lblResultado.Text = "";
            btnCalcular.Enabled = false;


            comboFiguras.Items.Add("Quadrado");
            comboFiguras.Items.Add("Ret�ngulo");
            comboFiguras.Items.Add("Tri�ngulo");
            comboFiguras.Items.Add("C�rculo");
            comboFiguras.Items.Add("Pent�gono");
            comboFiguras.Items.Add("Hex�gono");
            comboFiguras.Items.Add("Oct�gono");

            comboFiguras.SelectedIndex = 0;
            AtualizarCampos();
            comboFiguras.SelectedIndexChanged += comboFiguras_SelectedIndexChanged;
            btnCalcular.Click += btnCalcular_Click;

            textBox1.ReadOnly = true;
        }

        private void comboFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            lblValor1.Visible = txtValor1.Visible = false;
            lblValor2.Visible = txtValor2.Visible = false;
            lblValor3.Visible = txtValor3.Visible = false;

            txtValor1.Enabled = false;
            txtValor2.Enabled = false;
            txtValor3.Enabled = false;
            btnCalcular.Enabled = false;
            btnConfirmar.Enabled = true;
            comboFiguras.Enabled = true;
            formaConfirmada = false;

            string forma = comboFiguras.SelectedItem.ToString();

            switch (forma)
            {
                case "Quadrado":
                case "C�rculo":
                    lblValor1.Visible = txtValor1.Visible = true;
                    lblValor1.Text = forma == "Quadrado" ? "Lado:" : "Raio:";
                    break;

                case "Ret�ngulo":
                    lblValor1.Visible = txtValor1.Visible = true;
                    lblValor2.Visible = txtValor2.Visible = true;
                    lblValor1.Text = "Largura:";
                    lblValor2.Text = "Altura:";
                    break;

                case "Tri�ngulo":
                    lblValor1.Visible = txtValor1.Visible = true;
                    lblValor2.Visible = txtValor2.Visible = true;
                    lblValor3.Visible = txtValor3.Visible = true;
                    lblValor1.Text = "Lado A:";
                    lblValor2.Text = "Lado B:";
                    lblValor3.Text = "Lado C:";
                    break;

                case "Pent�gono":
                case "Hex�gono":
                case "Oct�gono":
                    lblValor1.Visible = txtValor1.Visible = true;
                    lblValor1.Text = "Lado:";
                    break;
            }

            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            lblResultado.Text = "";

            // Foco no primeiro campo vis�vel
            if (txtValor1.Visible) txtValor1.Focus();
            else if (txtValor2.Visible) txtValor2.Focus();
            else if (txtValor3.Visible) txtValor3.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!formaConfirmada)
            {
                MessageBox.Show("Confirme a forma antes de inserir os valores.");
                return;
            }

            try
            {
                Forma forma = null;
                string nome = comboFiguras.SelectedItem.ToString();

                switch (nome)
                {
                    case "Quadrado":
                        if (!double.TryParse(txtValor1.Text, out double ladoQ))
                            throw new FormatException();
                        forma = new Quadrado(ladoQ);
                        break;

                    case "Ret�ngulo":
                        if (!double.TryParse(txtValor1.Text, out double largura) ||
                            !double.TryParse(txtValor2.Text, out double altura))
                            throw new FormatException();
                        forma = new Retangulo(largura, altura);
                        break;

                    case "Tri�ngulo":
                        if (!double.TryParse(txtValor1.Text, out double ladoA) ||
                            !double.TryParse(txtValor2.Text, out double ladoB) ||
                            !double.TryParse(txtValor3.Text, out double ladoC))
                            throw new FormatException();
                        forma = new Triangulo(ladoA, ladoB, ladoC);
                        break;

                    case "C�rculo":
                        if (!double.TryParse(txtValor1.Text, out double raio))
                            throw new FormatException();
                        forma = new Circulo(raio);
                        break;

                    case "Pent�gono":
                        if (!double.TryParse(txtValor1.Text, out double ladoP))
                            throw new FormatException();
                        forma = new Pentagono(ladoP);
                        break;

                    case "Hex�gono":
                        if (!double.TryParse(txtValor1.Text, out double ladoH))
                            throw new FormatException();
                        forma = new Hexagono(ladoH);
                        break;

                    case "Oct�gono":
                        if (!double.TryParse(txtValor1.Text, out double ladoO))
                            throw new FormatException();
                        forma = new Octogono(ladoO);
                        break;
                }

                if (forma != null)
                {
                    lblResultado.Text = $"{forma.Name}:\n�rea = {forma.CalcularArea():F2}\nPer�metro = {forma.CalcularPerimetro():F2}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas n�meros v�lidos.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            formaConfirmada = true;

            // Habilita os campos necess�rios para a figura selecionada
            if (txtValor1.Visible) txtValor1.Enabled = true;
            if (txtValor2.Visible) txtValor2.Enabled = true;
            if (txtValor3.Visible) txtValor3.Enabled = true;

            btnCalcular.Enabled = true;
            //btnConfirmar.Enabled = false;
            //comboFiguras.Enabled = false;
        }
    }
}
