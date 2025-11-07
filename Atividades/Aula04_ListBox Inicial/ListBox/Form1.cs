using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPosLista.Text = lstLista.SelectedIndex.ToString();

            int soma = 0;

            foreach (var item in lstLista.SelectedItems)
            {
                soma = soma + 1;
            }
            lblTotal.Text = Convert.ToString(soma);

             lblTextoSel.Text = lstLista.SelectedItems.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstLista.SelectedItems.ToString() != "")
            {
                lstLista.Items.Remove(lstLista.SelectedItem.ToString());
            }
            return;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string texto = txtPalavra.Text;
            lstLista.Items.Insert(i, texto);
            i = i + 1;
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPosLista_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimparList_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
        }
    }
}
