using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {

        private delegate void AtualizaStatusCallback(string strMensagem);
        bool conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if (txtIp.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP.");
                txtIp.Focus();
                return;
            }

            try
            {
                IPAddress enderecoIP = IPAddress.Parse(txtIp.Text);
                int portaHost = (int)nPort.Value;

                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                mainServidor.IniciaAtendimento();
                listLog.Items.Add("Servidor Ativo, aguardando usuários conectarem-se...");
                listLog.SetSelected(listLog.Items.Count - 1, true);
            }
            catch(Exception ex)
            {
                listLog.Items.Add("Erro de conexão: " + ex.Message);
                listLog.SetSelected(listLog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtIp.Enabled = false;
            nPort.Enabled = false;
            button1.ForeColor = Color.Red;
            button1.Text = "Sair";

        }

        public void mainServidor_StatusChanged(object sender, StatusChahgedEventArgs e)
        {
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] {e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            listLog.Items.Add(strMensagem);
            listLog.SetSelected(listLog.Items.Count - 1, true);
        }
    }
}
