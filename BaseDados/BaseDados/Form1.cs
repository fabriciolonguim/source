using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQl Region CE
            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados +"; Password = 'Peraltinha' ";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{
            //    conexao.Open();

            //    lblResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = "Erro ao conectar Sql Server CE\n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            
            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}


            //SQLiteConnection conexao = new SQLiteConnection(strConection);
           

            //try
            //{
            //    conexao.Open();

            //    lblResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = "Erro ao conectar SQLite\n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql

            string strConnection = "server=127.0.0.1;User Id=root;password=";
            //string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";
            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";

            MySqlConnection conexao = new MySqlConnection(strConnection);
            //conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                lblResultado.Text = "Conectado MySQL";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS cursocsharp_db";

                comando.ExecuteNonQuery();
                lblResultado.Text = "Base dados criada com sucesso.";
                comando.Dispose();

            }
            catch(Exception ex)
            {
                lblResultado.Text = "Erro ao Conectar MySQL \n + ex";
            }
            finally
            { 

                conexao.Close();
            }



            #endregion

        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SQLServerCE
            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = 'Peraltinha' ";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INT nOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Tabela Criada SqlCe";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}



            #endregion


            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Tabela Criada SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql


            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection2);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                comando.ExecuteNonQuery();

                lblResultado.Text = "Tabela Criada MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


            #region SQLServerCe

            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = 'Peraltinha' ";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", ' " + nome + " ', ' " + email + " ')";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro inserido com sucesso Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion


            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();

            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", ' " + nome + " ', ' " + email + " ')";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro inserido com sucesso SqlLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region Mysql

            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";
           // string strConnection2 = "server=127.0.0.1;User Id=root;database=arcos;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection2);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", ' " + nome + " ', ' " + email + " ')";
                //comando.CommandText = "INSERT INTO teste VALUES (" + id + ", ' " + nome + " ', ' " + email + " ')";
                comando.ExecuteNonQuery();
               
                lblResultado.Text = "Registro inserido com sucesso MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }


            #endregion


        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            dataLista.Rows.Clear();

            #region SQLServerCe

            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = 'Peraltinha' ";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable();

            //    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        dataLista.Rows.Add(linha.ItemArray);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    dataLista.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}


            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable();

            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        dataLista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    dataLista.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql

            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";

            MySqlConnection conexao = new MySqlConnection(strConnection2);
            

            try
            {
                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection2);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataLista.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception ex)
            {
                //dataLista.Rows.Clear();
                lblResultado.Text = ex.Message;
                MessageBox.Show("Cadastrao não encontrado!");
            }
            finally
            {
                conexao.Close();
            }

            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            #region SQLServerCe

            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = 'Peraltinha' ";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);



            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    int id = (int)dataLista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = ' " + id + " ' ";

            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro excludio do Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion


            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();

            //    comando.Connection = conexao;

            //    int id = (int)dataLista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = ' " + id + " ' ";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro excluido do SqlLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region Mysql

            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection2);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;

                int id = (int)dataLista.SelectedRows[0].Cells[0].Value;


                comando.CommandText = "DELETE FROM pessoas WHERE id = ' " + id + " ' ";
                comando.ExecuteNonQuery();

                lblResultado.Text = "Registro excluido do MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }


            #endregion

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SQLServerCe

            //string baseDados = Application.StartupPath + @"\db\SBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = 'Peraltinha' ";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);



            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    int id = (int)dataLista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    string chamar = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

            //    comando.CommandText = chamar;


            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro atualizado do Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion


            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();

            //    comando.Connection = conexao;

            //    int id = (int)dataLista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    string chamar = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

            //    comando.CommandText = chamar;


            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro atualizado do SqlLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region Mysql

            string strConnection2 = "server=127.0.0.1;User Id=root;database=cursocsharp_db;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection2);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;

                int id = (int)dataLista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                string chamar = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                comando.CommandText = chamar;

                comando.ExecuteNonQuery();

                lblResultado.Text = "Registro atualizado do MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }


            #endregion
        }
    }
}
