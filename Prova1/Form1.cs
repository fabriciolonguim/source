using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome;
            double distancia, valorKm = 0,  modalidade = 0, adicional = 0, total;

            try
            {
                nome = Convert.ToString(txtFuncionario.Text);
                distancia = Convert.ToDouble(txtDistancia.Text);

            } catch (Exception erro)
            {
                MessageBox.Show("Houve um erro: " + erro);
                return;
            }

            if (rdbI.Checked == true)
            {

                modalidade = 1.50;
                valorKm = distancia * modalidade;

            } else if (rdbIi.Checked == true)
            {

                modalidade = 2.50;
                valorKm = distancia * modalidade;

            } else if (rdbIii.Checked == true)
            {

                modalidade = 3.00;
                valorKm = distancia * modalidade;

            }

            if (chkNao.Checked == true)
            {

                adicional = 0;
                

            } else if (chkSim.Checked == true)
            {

                adicional = 25 * valorKm / 100;

            } 

            if(distancia < 100 && modalidade == 3.00)
            {
                MessageBox.Show("Viagens com menos de 100 Km não pode ser feitas com a modalidade escolhida!");
            } else
            {
                total = valorKm + adicional;
                txtValorDistancia.Text = valorKm.ToString();
                txtAdicional.Text = adicional.ToString();
                txtTotal.Text = total.ToString();
            }

           
            

            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFuncionario.Text = "";
            txtDistancia.Text = "";
            rdbI.Checked = false;
            rdbIi.Checked = false;
            rdbIii.Checked = false;
            chkSim.Checked = false;
            chkNao.Checked = false;
            txtValorDistancia.Text = "";
            txtAdicional.Text = "";
            txtTotal.Text = "";
        }

       

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

     
    }
}
