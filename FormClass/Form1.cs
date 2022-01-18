using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double metros = double.Parse(txtMetros.Text);

            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pulgadas / 3;
                 
            lstR.Items.Add(" |||||| Resumen de Conversiones |||||||");
            lstR.Items.Add("---------------------------------------------");
            lstR.Items.Add("Medida en Metros: "+metros.ToString("0.00"));
            lstR.Items.Add("Medida en Centimetros: "+centimetros.ToString("0.00"));
            lstR.Items.Add("Medida en Pulgadas: " + pulgadas.ToString("0.00"));
            lstR.Items.Add("Medida en Pies: " + pies.ToString("0.00"));
            lstR.Items.Add("Medida en Yardas: " + yardas.ToString("0.00"));

            lstR.Items.Add("");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Medidas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes){
                this.Close();
            }
                
        }
    }
}
