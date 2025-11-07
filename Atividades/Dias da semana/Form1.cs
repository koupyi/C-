using System.Linq.Expressions;

namespace Dias_da_semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo que é o 1° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Segunda-feira":
                    MessageBox.Show("Você escolheu Segunda que é o 2° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Terça-feira":
                    MessageBox.Show("Você escolheu Terça que é o 3° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Quarta-feira":
                    MessageBox.Show("Você escolheu Quarta que é o 4° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Você escolheu Quinta que é o 5° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sexta-feira":
                    MessageBox.Show("Você escolheu Sexta que é o 6° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sábado":
                    MessageBox.Show("Você escolheu Sábado que é o 7° Dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
