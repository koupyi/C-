namespace Formato_longo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateLabel1.Value.ToString("dd/MM/yyyy"));
        }

        private void dateLabel2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
