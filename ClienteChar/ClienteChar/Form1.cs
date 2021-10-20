using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChar
{
    public partial class Form1 : Form
    {
        private string NomeUsuario;
        private StreamWriter stwEnivador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        private delegate void AtualizaLogCallBack(string strMensagem);

        private delegate void FechaConexaoCallBack(string strMotivo);

        private Thread mensagemThread;

        private IPAddress enderecoIP;

        private int portaHost;

        private bool conectado;

        public Form1()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit); 
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do usuário.");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 )
            {
                EnviaMensagem();
            }
        }

        private void InicializaConexao()
        {
            try
            {
                enderecoIP = IPAddress.Parse(txtIp.Text);
                portaHost = (int)nPort.Value;
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);

                conectado = true;

                NomeUsuario = txtVisitante.Text;

                txtIp.Enabled = false;
                nPort.Enabled = false;
                txtVisitante.Enabled = false;
                textB.Enabled = true;
                btnEnviar.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                stwEnivador = new StreamWriter(tcpServidor.GetStream());
                stwEnivador.Write(txtVisitante.Text);
                stwEnivador.Flush();

                mensagemThread = new Thread(new ThreadStart(ReceberMensagem));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                label1.Invoke(new Action(() => {
                    label1.ForeColor = Color.Green;
                    label1.Text = $"Conectado ao servidor de char {enderecoIP}:{portaHost}";

                }));

            }
            catch(Exception ex)
            {
                label1.Invoke(new Action(()=> {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Erro na conexão com servidor : \n" + ex.Message;
                }));
            }
        }

        private void ReceberMensagem()
        {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine(); // aque tem um erro


            if(ConResposta[0] == '1')
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else
            {
                string Motivo = "Não conectado: ";
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                this.Invoke(new FechaConexaoCallBack(this.AtualizaLog), new object[] { Motivo });
                return;
            }

            while (conectado)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });

            }
        }

        private void AtualizaLog(string strMensagem)
        {
            txtLog.AppendText(strMensagem + "\r\n");
        }

        private void EnviaMensagem()
        {
            if (textB.Lines.Length >= 1)
            {
                stwEnivador.WriteLine(textB.Text);
                stwEnivador.Flush();
                textB.Lines = null;

            }

            textB.Text = "";
        }

        private void FechaConexao(string Motivo)
        {
            txtLog.AppendText(Motivo + "\r\n");

            txtIp.Enabled = true;
            nPort.Enabled = true;
            txtVisitante.Enabled = true;
            textB.Enabled = false;
            btnEnviar.Enabled = true;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "Conectar";

            conectado = false;
            stwEnivador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            label1.Invoke(new Action(() => {
                label1.ForeColor = Color.Green;
                label1.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost} ";
            }));


        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (conectado)
            {
                conectado = false;
                stwEnivador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                label1.Invoke(new Action(() => {
                    label1.ForeColor = Color.Green;
                    label1.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost} ";
                }));
            }
        }
    }
}
