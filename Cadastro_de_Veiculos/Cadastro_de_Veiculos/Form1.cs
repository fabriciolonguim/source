using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Veiculos
{
    public partial class Form1 : Form
    {
        DataTable tabVeiculo;
        DataTable tabOperacao;
        const string fileVeiculo = "Veiculo.Xml";
        const string fileOperacao = "Operacao.Xml";
        //public int id;

        public Form1()
        {
            InitializeComponent();

            tabVeiculo = new DataTable("Veiculo");
            tabOperacao = new DataTable("Operacao");

            if (System.IO.File.Exists(fileVeiculo))
            {
                tabVeiculo.ReadXml(fileVeiculo);
                tabOperacao.ReadXml(fileOperacao);
            }
            else
            {

                tabVeiculo.Columns.Add("Id", typeof(int));
                tabVeiculo.Columns.Add("Placa", typeof(string));
                tabVeiculo.Columns.Add("Descricao", typeof(string));
                tabVeiculo.Columns.Add("Marca", typeof(string));
                tabVeiculo.Columns.Add("Media", typeof(double));
                tabVeiculo.Columns.Add("Quilometragem", typeof(double));
                tabVeiculo.Columns.Add("Qta de Combustivel", typeof(double));

                tabOperacao.Columns.Add("Id", typeof(int));
                tabOperacao.Columns.Add("Placa", typeof(string));
                tabOperacao.Columns.Add("Data", typeof(string));
                tabOperacao.Columns.Add("Hora", typeof(string));
                tabOperacao.Columns.Add("Operacao", typeof(string));
                tabOperacao.Columns.Add("Combustivel", typeof(double));
                tabOperacao.Columns.Add("Quilometros Rodados", typeof(double));
            }

            dataGridView1.DataSource = tabVeiculo;
            dataGridView2.DataSource = tabOperacao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string user, date;
            user = Environment.UserName;
            date = DateTime.Now.ToLongDateString();

            lblUsuario.Text = "Bem vindo: " + user;
            lblData.Text = date;

            comboMarca.Items.Add("Chevrolet");
            comboMarca.Items.Add("Fiat");
            comboMarca.Items.Add("Ford");
            comboMarca.Items.Add("Volkswagen");
            comboMarca.Items.Add("Peugeot");
            comboMarca.Items.Add("Renault");
            comboMarca.SelectedIndex = 0;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                MessageBox.Show("O campo Placa esta vazio.");
                return;
            }

            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo Descricao esta vazio.");
                return;
            }

            if (txtMedia.Text == "")
            {
                MessageBox.Show("O campo Média esta vazio.");
                return;
            }

            if (txtQuilometragem.Text == "")
            {
                MessageBox.Show("O campo Hodômetro esta vazio.");
                return;
            }

            if (txtLtsComb.Text == "")
            {
                MessageBox.Show("O campo Qta de Combustível esta vazio.");
                return;
            }

            for (int i = 1; i < tabVeiculo.Rows.Count; i++)
            {
                if (tabVeiculo.Rows[i]["Placa"].ToString() == txtPlaca.Text)
                {
                    MessageBox.Show("Esta placa já esta cadastrada.");
                    return;

                }
            }

            DataRow linVeiculo = tabVeiculo.NewRow();

            linVeiculo["Placa"] = txtPlaca.Text;
            linVeiculo["Descricao"] = txtDescricao.Text;
            linVeiculo["Marca"] = comboMarca.Text;
            linVeiculo["Media"] = txtMedia.Text;
            linVeiculo["Quilometragem"] = txtQuilometragem.Text;
            linVeiculo["Qta de Combustivel"] = txtLtsComb.Text;

            tabVeiculo.Rows.Add(linVeiculo);
            tabVeiculo.AcceptChanges();

            tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);

            if (dataGridView1.Rows.Count > -1)
            {
                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
                    linVeiculo["Id"] = i;

                    tabVeiculo.AcceptChanges();
                    tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);

                }
            }



            txtId.Clear();
            txtPlaca.Clear();
            txtDescricao.Clear();
            comboMarca.SelectedIndex = 0;
            txtMedia.Clear();
            txtQuilometragem.Clear();
            txtLtsComb.Clear();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtPlaca.Text = dataGridView1.CurrentRow.Cells["Placa"].Value.ToString();
                txtDescricao.Text = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
                comboMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtMedia.Text = dataGridView1.CurrentRow.Cells["Media"].Value.ToString();
                txtQuilometragem.Text = dataGridView1.CurrentRow.Cells["Quilometragem"].Value.ToString();
                txtLtsComb.Text = dataGridView1.CurrentRow.Cells["Qta de Combustivel"].Value.ToString();

            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //int cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            int cod = Convert.ToInt32(txtId.Text);

            for (int i = 1; i < tabVeiculo.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == Convert.ToInt32(txtId.Text))
                {
                    tabVeiculo.Rows[i]["Placa"] = txtPlaca.Text;
                    tabVeiculo.Rows[i]["Descricao"] = txtDescricao.Text;
                    tabVeiculo.Rows[i]["Marca"] = comboMarca.Text;
                    tabVeiculo.Rows[i]["Media"] = txtMedia.Text;
                    tabVeiculo.Rows[i]["Quilometragem"] = txtQuilometragem.Text;
                    tabVeiculo.Rows[i]["Qta de Combustivel"] = txtLtsComb.Text;

                    tabVeiculo.AcceptChanges();
                    tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);

                }
            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cod;
            if (tabVeiculo.Rows != null)
            {
                cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                    {
                        tabVeiculo.Rows.RemoveAt(i);

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtAbastecimento.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtRodagem.Enabled = true;
            chkAbastecer.Checked = false;
            chkConsumir.Checked = false;
        }

        private void chkAbastecer_CheckedChanged(object sender, EventArgs e)
        {
            txtAbastecimento.Enabled = true;
            chkConsumir.Checked = false;
            chkRodagem.Checked = false;
        }

        private void chkConsumir_CheckedChanged(object sender, EventArgs e)
        {
            txtAbastecimento.Enabled = true;
            chkRodagem.Checked = false;
            chkAbastecer.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
           

           

           


            #region Abastecer
            if (chkAbastecer.Checked)
            {
                if (txtAbastecimento.Text == "")
                {
                    MessageBox.Show("O campo Abastecimento esta vazio.");
                    return;
                }

                int litros = int.Parse(txtAbastecimento.Text);
                int r = int.Parse(txtAbastecimento.Text);

                if (litros < 1)
                {
                    MessageBox.Show("Você não esta abastecendo.");
                    return;
                }

                if (dataGridView1.Rows != null)
                {
                    for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                        {
                            litros = Convert.ToInt32(tabVeiculo.Rows[i]["Qta de Combustivel"]);
                            txtPlaca.Text = tabVeiculo.Rows[i]["Placa"].ToString();

                            int res = r + litros;
                            tabVeiculo.Rows[i]["Qta de Combustivel"] = res;
                            tabVeiculo.AcceptChanges();
                            tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);



                        }

                    }
                }

            }
            #endregion

            #region Consumir
            if (chkConsumir.Checked)
            {
                if (txtAbastecimento.Text == "")
                {
                    MessageBox.Show("O campo Abastecimento esta vazio.");
                    return;
                }

                int litros = int.Parse(txtAbastecimento.Text);
                int r = int.Parse(txtAbastecimento.Text);
                for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                    {
                        litros = Convert.ToInt32(tabVeiculo.Rows[i]["Qta de Combustivel"]);

                        int res = litros - r;
                        int km = r * Convert.ToInt32(tabVeiculo.Rows[i]["Media"]);

                        if (r < 1)
                        {
                            MessageBox.Show("Você não pode consumir essa quantidade de litros");
                            return;
                        }
                        else
                        {
                            tabVeiculo.Rows[i]["Qta de Combustivel"] = res;
                            tabVeiculo.Rows[i]["Quilometragem"] = km + Convert.ToInt32(tabVeiculo.Rows[i]["Quilometragem"]);
                            tabVeiculo.AcceptChanges();
                            tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);


                            DataRow linOperacao = tabOperacao.NewRow();

                            linOperacao["Placa"] = tabVeiculo.Rows[i]["Placa"];
                            linOperacao["Data"] = DateTime.Now.ToString("dd-MM-yyyy");
                            linOperacao["Hora"] = DateTime.Now.ToString("HH:mm:ss");
                            linOperacao["Operacao"] = "Consumo";
                            linOperacao["Combustivel"] = r;
                            linOperacao["Quilometros Rodados"] = km;

                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);
                        }

                    }

                }

                for (int i = 1; i < tabOperacao.Rows.Count; i++)
                {
                    DataRow linOperacao = tabOperacao.NewRow();

                    linOperacao["Id"] = i;
                }
            }
            #endregion

            #region Rodagem
            if (chkRodagem.Checked)
            {
                int soma_km = int.Parse(txtRodagem.Text);

                if(int.TryParse(txtRodagem.Text, out soma_km) == false)
                {
                    MessageBox.Show("Digite um valor valido no campo Rodagem");
                }

                for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                    {
                        int consumo_rodagem;
                        int km = Convert.ToInt32(tabVeiculo.Rows[i]["Quilometragem"]);
                        int m = Convert.ToInt32(tabVeiculo.Rows[i]["Media"]);
                        int litros = Convert.ToInt32(tabVeiculo.Rows[i]["Qta de Combustivel"]);
                        consumo_rodagem = litros * m;
                        int div_rodagem = soma_km / m;
                        int qt_comb = litros - div_rodagem;

                        if (soma_km >= consumo_rodagem && qt_comb > litros - 1)
                        {
                            MessageBox.Show("Você não pode fazer essa viagem.");
                            return;
                        }
                        else
                        {
                            soma_km = soma_km + km;
                            tabVeiculo.Rows[i]["Quilometragem"] = soma_km;
                            tabVeiculo.Rows[i]["Qta de Combustivel"] = qt_comb;
                            

                            tabVeiculo.AcceptChanges();
                            tabVeiculo.WriteXml(fileVeiculo, XmlWriteMode.WriteSchema);
                          

                        }

                    }
                }

               
            }
            #endregion
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {

           
            DataRow linOperacao = tabOperacao.NewRow();
            int cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            

            

            //if(int.Parse(txtAbastecimento.Text, out r) == false)
            //{

            //}

            if (chkAbastecer.Checked)
            {
                if (txtAbastecimento.Text == "")
                {
                    MessageBox.Show("O campo Abastecimento esta vazio.");
                    return;
                }

                if (dataGridView1.Rows != null)
                {
                    for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                        {
                            linOperacao["Placa"] = tabVeiculo.Rows[i]["Placa"];
                            linOperacao["Data"] = DateTime.Now.ToString("dd-MM-yyyy");
                            linOperacao["Hora"] = DateTime.Now.ToString("HH:mm:ss");
                            linOperacao["Operacao"] = "Abastecimento";
                            linOperacao["Combustivel"] = txtAbastecimento.Text;
                            linOperacao["Quilometros Rodados"] = 0;

                            tabOperacao.Rows.Add(linOperacao);
                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);

                        }

                    }

                    if (dataGridView2.Rows.Count > -1)
                    {
                        for (int i = 1; i < dataGridView2.Rows.Count; i++)
                        {
                            linOperacao["Id"] = i;

                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);

                        }

                    }

                }
            }

                if (chkConsumir.Checked)
                {
                    if (txtAbastecimento.Text == "")
                    {
                        MessageBox.Show("O campo Abastecimento esta vazio.");
                        return;
                    }

                    int r = int.Parse(txtAbastecimento.Text);

                     for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                     {
                            if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                            {
                                int litros = Convert.ToInt32(tabVeiculo.Rows[i]["Qta de Combustivel"]);

                                int res = litros - r;
                                int km = r * Convert.ToInt32(tabVeiculo.Rows[i]["Media"]);

                                linOperacao["Placa"] = tabVeiculo.Rows[i]["Placa"];
                                linOperacao["Data"] = DateTime.Now.ToString("dd-MM-yyyy");
                                linOperacao["Hora"] = DateTime.Now.ToString("HH:mm:ss");
                                linOperacao["Operacao"] = "Consumo";
                                linOperacao["Combustivel"] = r;
                                linOperacao["Quilometros Rodados"] = km;

                                tabOperacao.Rows.Add(linOperacao);
                                tabOperacao.AcceptChanges();
                                tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);


                            }

                     }


                    if (dataGridView2.Rows.Count > -1)
                    {
                        for (int i = 1; i < tabOperacao.Rows.Count; i++)
                        {
                            linOperacao["Id"] = i;
                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);
                        }

                    }
                }



                if (chkRodagem.Checked)
                {
                 
                    for (int i = 0; i < tabVeiculo.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(tabVeiculo.Rows[i]["Id"]) == cod)
                        {
                            int consumo_rodagem;
                            int soma_km = int.Parse(txtRodagem.Text);
                            int km = Convert.ToInt32(tabVeiculo.Rows[i]["Quilometragem"]);
                            int m = Convert.ToInt32(tabVeiculo.Rows[i]["Media"]);
                            int litros = Convert.ToInt32(tabVeiculo.Rows[i]["Qta de Combustivel"]);
                            consumo_rodagem = litros * m;
                            int div_rodagem = soma_km / m;
                            int qt_comb = litros - div_rodagem;

                            linOperacao["Placa"] = tabVeiculo.Rows[i]["Placa"];
                            linOperacao["Data"] = DateTime.Now.ToString("dd-MM-yyyy");
                            linOperacao["Hora"] = DateTime.Now.ToString("HH:mm:ss");
                            linOperacao["Operacao"] = "Rodagem";
                            linOperacao["Combustivel"] = qt_comb;
                            linOperacao["Quilometros Rodados"] = consumo_rodagem;

                            tabOperacao.Rows.Add(linOperacao);
                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);

                        }
                    }


                    if (dataGridView2.Rows.Count > -1)
                    {
                        for (int i = 1; i < tabOperacao.Rows.Count; i++)
                        {
                            linOperacao["Id"] = i;
                            tabOperacao.AcceptChanges();
                            tabOperacao.WriteXml(fileOperacao, XmlWriteMode.WriteSchema);
                        }

                    }
                }

            MessageBox.Show("Operação cadastrada com sucesso.");


        }

       

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pl;
            pl = txtPesquisa.Text;

            for(int i = 1; i < tabOperacao.Rows.Count; i++)
            {
                if(tabOperacao.Rows[i]["Placa"].ToString() == pl)
                {
                    string[] mensagens = new string[i + 1];

                    mensagens[i] = "Placa: " + tabOperacao.Rows[i]["Placa"].ToString() + " Data: " + tabOperacao.Rows[i]["Data"].ToString()
                         + " Hora: " + tabOperacao.Rows[i]["Hora"].ToString() + " Operacao: " + tabOperacao.Rows[i]["Operacao"].ToString() +
                         " Conbustivel: " + tabOperacao.Rows[i]["Combustivel"].ToString() + " Quilometros Rodados: " + tabOperacao.Rows[i]["Quilometros Rodados"].ToString() +
                         Environment.NewLine;


                    listBox1.Items.Add(mensagens[i]);
                    

                    //MessageBox.Show(
                    //    "Placa: " + tabOperacao.Rows[i]["Placa"].ToString() + " Data: " + tabOperacao.Rows[i]["Data"].ToString()
                    //    + " Hora: " + tabOperacao.Rows[i]["Hora"].ToString() + " Operacao: " + tabOperacao.Rows[i]["Operacao"].ToString() +
                    //    " Conbustivel: " + tabOperacao.Rows[i]["Combustivel"].ToString() + " Quilometros Rodados: " + tabOperacao.Rows[i]["Quilometros Rodados"].ToString() +
                    //    Environment.NewLine
                    //    );
                }
            }
        }

        private void txtAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtRodagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtQuilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtLtsComb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }


}

