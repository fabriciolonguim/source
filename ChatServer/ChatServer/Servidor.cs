using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //Etse delegate é necessário para especificar os parametros que estamos passando com o nosso evento
    public delegate void StatusChangedEventHandler(object sender, StatusChahgedEventArgs e);
    class Servidor
    {
        //Esta hash table armazena os usuários e as conexões (acessando/consultado por usuário)
        public static Hashtable htUsuarios = new Hashtable(30); // 30 usuários é o limite definido

        //Esta hash table armazena os usuários e as conexões (acessada/consultada por conexão)
        public static Hashtable htConexoes = new Hashtable(30); // 2o usuários é o limite definido

        // armazena o endereço IP passado
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpCliente;

        public static event StatusChangedEventHandler StatusChanged;

        private static StatusChahgedEventArgs e;

        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }

        private Thread thrListener;

        private TcpListener tlsCliente;

        bool ServRodando = false;

        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
        {
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
        }

        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            if (htConexoes[tcpUsuario] != null)
            {
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");

                //Remove o usuário da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);


            }
        }

        public static void OnStatusChanged(StatusChahgedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;

            if(statusHandler != null)
            {
                statusHandler(null, e);
            }
        }

        public static void EnviaMensagemAdmin(string Mensagem)
        {
            StreamWriter swSenderSender;

            e = new StatusChahgedEventArgs("Administrador: " + Mensagem);
            OnStatusChanged(e);

            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            for(int i = 0; i < tcpClientes.Length; i++)
            {
                try
                {
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());

                    swSenderSender.WriteLine("Administrador: " + Mensagem);

                    swSenderSender.Flush();

                    swSenderSender = null;

                }
                catch
                {
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        // envia mensagens de um usuário para todos os outros usuários
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            e = new StatusChahgedEventArgs(Origem + " disse : " + Mensagem);
            OnStatusChanged(e);

            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);
            for (int i = 0; i < tcpClientes.Length; i ++)
            {
                try
                {
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());

                    swSenderSender.WriteLine("Administrador: " + Mensagem);

                    swSenderSender.Flush();

                    swSenderSender = null;

                }
                catch
                {
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }  


        public void IniciaAtendimento()
        {
            try
            {
                IPAddress ipLocal = enderecoIP;
                int portaLocal = portaHost;

                tlsCliente = new TcpListener(ipLocal, portaLocal);

                tlsCliente.Start();

                ServRodando = true;

                thrListener = new Thread(MantemAtendimento);

                thrListener.IsBackground = true;

                thrListener.Start();

            }
            catch(Exception e)
            {

            }
        }

        private void MantemAtendimento()
        {
            while(ServRodando)
            {
                tcpCliente = tlsCliente.AcceptTcpClient();

                Conexao newConnection = new Conexao(tcpCliente);

            }
        }

    }

   
}
