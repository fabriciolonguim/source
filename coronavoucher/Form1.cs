using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coronavoucher
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double rendaFamiliar = 0;
            
            try
            {
                rendaFamiliar = double.Parse(txtRendaf.Text);
              

            } catch (Exception erro)
            {
                MessageBox.Show("Houve um erro: " + erro);
                return;
              
            }
           

            if (rendaFamiliar > 2000)
            {
                MessageBox.Show("Você não tem direito ao beneficio.");
                return;
               
            }  else
            {
                grpCampos.Enabled = true;
                grpCampos.Visible = true;
            }
        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {

            if(txtRendaf.Text != "")
            {
                int renda;
                if (int.TryParse(txtRendaf.Text, out renda) == false)
                {
                    e.Cancel = true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double porcCrianca,porcCron,porcIdoso,porcLg,porQuantidade = 0, total;
            double porRegiao;
            double rendaFamiliar = double.Parse(txtRendaf.Text);
            int quantidade = 0;
            try
            {
                quantidade = int.Parse(txtQpessoas.Text);
            } catch (Exception erro)
            {
                MessageBox.Show("Houve um  eerro: " + erro);
                return;
            }
            
            string msg = "";

            
                       
            #region Porentagem Criança
            if (rdbTres.Checked == true)
            {
                porcCrianca = rendaFamiliar * 10 / 100;
                msg = "10%";
                lblCrianca.Visible = true;
                txtPcrianca.Visible = true;
                txtTcrianca.Visible = true;

            } else if(rdbAteSeis.Checked == true)
            {
                porcCrianca = rendaFamiliar * 20 / 100;
                msg = "20%";
                lblCrianca.Visible = true;
                txtPcrianca.Visible = true;
                txtTcrianca.Visible = true;

            } else if(rdbMaisSeis.Checked == true)
            {
                porcCrianca = rendaFamiliar * 25 / 100;
                msg = "25%";
                lblCrianca.Visible = true;
                txtPcrianca.Visible = true;
                txtTcrianca.Visible = true;

            } else
            {
                porcCrianca = 0;
            }
            #endregion

            #region Condições Especiais
            if (chkCron.Checked == true)
            {
                porcCron = rendaFamiliar * 5 / 100;
                msg = "5%";
                txtPdoente.Text = msg;
                lblDoente.Visible = true;
                txtPdoente.Visible = true;
                txtTdoente.Visible = true;
            } else
            {
                porcCron = 0;
                
            }

            if (chkIdosos.Checked == true)
            {
                porcIdoso = rendaFamiliar * 5 / 100;
                msg = "5%";
                txtPidoso.Text = msg;
                lbldoso.Visible = true;
                txtPidoso.Visible = true;
                txtTidoso.Visible = true;
            } else
            {
                porcIdoso = 0;
                
            }
            if (chkLg.Checked == true)
            {
                porcLg = rendaFamiliar * 5 / 100;
                msg = "5%";
                txtPlac.Text = msg;
                lblGestante.Visible = true;
                txtPlac.Visible = true;
                txtTlac.Visible = true;
            } else
            {
                porcLg = 0;
            }


            #endregion


            #region Região

            if (rdbNorte.Checked == true)
            {
                porRegiao = 0;
                msg = "0%";
                txtPnivel.Text = msg;
                lblNivelamento.Visible = true;
                txtPnivel.Visible = true;
                txtTnivel.Visible = true;

            } else if (rdbCentro.Checked == true)
            {
                porRegiao = rendaFamiliar * 5 / 100;
                msg = "5%";
                txtPnivel.Text = msg;
                lblNivelamento.Visible = true;
                txtPnivel.Visible = true;
                txtTnivel.Visible = true;

            } else if (rdbSul.Checked == true)
            {
                porRegiao = rendaFamiliar * 10 / 100;
                msg = "10%";
                txtPnivel.Text = msg;
                lblNivelamento.Visible = true;
                txtPnivel.Visible = true;
                txtTnivel.Visible = true;

            } else
            {
                porRegiao = rendaFamiliar * 15 / 100;
                msg = "15%";
                txtPnivel.Text = msg;
                lblNivelamento.Visible = true;
                txtPnivel.Visible = true;
                txtTnivel.Visible = true;
            }

            #endregion(


            #region Quantidade Pessoas
           
            if (quantidade > 0 && quantidade <= 5)
            {
                porQuantidade = rendaFamiliar * 5 / 100;
                msg = "5%";
                txtPpessoas.Text = msg;
                lblTpessoas.Visible = true;
                txtPpessoas.Visible = true;
                txtTpessoas.Visible = true;

            } else 
            {

                porQuantidade = rendaFamiliar * 10 / 100;
                msg = "10%";
                txtPpessoas.Text = msg;
                lblTpessoas.Visible = true;
                txtPpessoas.Visible = true;
                txtTpessoas.Visible = true;
            }  

            #endregion

            #region Verificação
            if (quantidade <= 5 && rdbMaisSeis.Checked == true)
            {
                MessageBox.Show("Você não tem direito ao beneficio," +
                    " a quantdade de crianças é maior que o total da familia");
                this.Close();

            } else if (quantidade <= 5 && rdbTres.Checked == true && chkCron.Checked == true && chkIdosos.Checked == true)
            {
                MessageBox.Show("Você não tem direito ao beneficio");
                grpCampos.Visible = false;
                this.Close();

            } else if (quantidade <= 5 && rdbTres.Checked == true && chkCron.Checked == true && chkLg.Checked == true)
            {
                MessageBox.Show("Você não tem direito ao beneficio");
                grpCampos.Visible = false;
                this.Close();
            } else if (quantidade <= 5 && rdbTres.Checked == true && chkIdosos.Checked == true && chkLg.Checked == true)
            {
                MessageBox.Show("Você não tem direito ao beneficio");
                this.Close();
            }
            #endregion


            total = porcCrianca + porcCron + porcIdoso + porcLg + porRegiao 
                + porQuantidade;

            txtRt.Text = txtRendaf.Text;
            txtTotal.Text = total.ToString("n");
            txtPcrianca.Text = msg;
            txtTcrianca.Text = porcCrianca.ToString("n");
            txtTdoente.Text = porcCron.ToString("n");
            txtTidoso.Text = porcIdoso.ToString("n");
            txtTlac.Text = porcLg.ToString("n");
            txtTpessoas.Text = porQuantidade.ToString("n");
            txtTnivel.Text = porRegiao.ToString("n");

        }
       
        private void chkCriancas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkCriancas.Checked == true)
            {
                grpCriancas.Enabled = true;
            }
        }

        #region Botao de Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRendaf.Text = "";
            txtRt.Text = "";
            txtTotal.Text = "";
            txtPcrianca.Text = "";
            txtTcrianca.Text = "";
            txtTdoente.Text = "";
            txtTidoso.Text = "";
            txtTlac.Text = "";
            txtTpessoas.Text = "";
            txtTnivel.Text = "";
            txtQpessoas.Text = "";
            txtPlac.Text = "";
            txtPnivel.Text = "";
            txtPpessoas.Text = "";
            txtPdoente.Text = "";
            txtPcrianca.Text = "";
            txtPidoso.Text = "";
            chkCriancas.Checked = false;
            rdbAteSeis.Checked = false;
            rdbMaisSeis.Checked = false;
            rdbTres.Checked = false;
            rdbNorte.Checked = false;
            rdbCentro.Checked = false;
            rdbSul.Checked = false;
            rdbSudeste.Checked = false;
            chkCron.Checked = false;
            chkLg.Checked = false;
            chkIdosos.Checked = false;
        }

        #endregion


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRendaf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtQpessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtRendaf_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }