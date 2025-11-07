using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Lista_C__Modo_Gráfico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado1.Text = "";
            double valor1 = Convert.ToDouble(txtParimpar.Text);
            if (valor1 % 2 == 0)
            {
                txtResultado1.Text = "O numero é: par";
            }
            else
            {
                txtResultado1.Text = "O numero é: impar";

            }
            ;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNumero1.Text);
            double valor2 = Convert.ToDouble(txtNumero2.Text);
            if (valor1 > valor2)
            {
                txtMaior.Text = "O maior numero é: " + Convert.ToString(valor1);
            }
            else
            {
                txtMaior.Text = "O maior numero é: " + Convert.ToString(valor2);

            }
            ;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtOpção.Text);
            double valor2 = Convert.ToDouble(txt1.Text);
            double valor3 = Convert.ToDouble(txt2.Text);

            if (valor1 == 1)
            {
                valor2 = valor2 + valor3;
                TxtResultado2.Text = Convert.ToString(valor2);
                TxtResultado2.Text = "O numero é: " + TxtResultado2.Text;
            }
            ;
            if (valor1 == 2)
            {
                valor2 = valor2 * valor3;
                TxtResultado2.Text = Convert.ToString(valor2);
                TxtResultado2.Text = "O numero é: " + TxtResultado2.Text;
            }
            ;
        }

        private void TxtResultado2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string genero = Convert.ToString(txtSexo.Text);
            double idade = Convert.ToDouble(txtIdade.Text);

            if (genero == "feminino" & idade < 25)
            {
                txtResultado3.Text = "Você foi: aceita " + txtNome.Text;
            }
            else
            {
                txtResultado3.Text = "Você foi: Recusado(a) ";
            }
        }

        private void txtResultado3_Click(object sender, EventArgs e)
        {

        }

        private void txtClasse_Click(object sender, EventArgs e)
        {

        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            Double idade = Convert.ToDouble(txtIdade2.Text);
            if (idade < 16)
            {
                txtClasse.Text = "Sua classe eleitoral é: não eleitor";
            }
            ;
            if (idade > 18 & idade < 65)
            {
                txtClasse.Text = "Sua classe eleitoral é: eleitor obrigatório";
            }
            ;
            if (idade > 16 & idade < 18)
            {
                txtClasse.Text = "Sua classe eleitoral é: eleitor facultativo";
            }
            ;
            if (idade > 65)
            {
                txtClasse.Text = "Sua classe eleitoral é: eleitor facultativo";
            }
            ;
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
