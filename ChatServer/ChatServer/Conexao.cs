using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ChatServer
{
    class Conexao
    {
        TcpClient tcpCliente;

        private Thread thrSender;
        private StreamReader swReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private string strResposta;

        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;
            // A thread que aceita o cliente e espera a mensagem
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;
            // A thread chama o método AceitaCliente()
            thrSender.Start();
        }

        private void FechaConexao()
        {
            tcpCliente.Close();
            swReceptor.Close();
            swEnviador.Close();
        }

        private void AceitaCliente()
        {
            swReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            usuarioAtual = swReceptor.ReadLine();

            if (usuarioAtual != "")
            {
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    swEnviador.WriteLine("0| Este nome de usuário já existe.");
                    swEnviador.Flush();
                    return;
                }
                else if (usuarioAtual == "Administrator")
                {
                    swEnviador.WriteLine("0| Este nome é reservado.");
                    swEnviador.Flush();
                    return;
                }
                else
                {
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();

                    Servidor.IncluiUsuario(tcpCliente, usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }

            try
            {
                while ((strResposta= swReceptor.ReadLine()) != "")
                {
                    if(strResposta == null)
                    {
                        Servidor.RemoveUsuario(tcpCliente);
                    }
                    else
                    {
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            }
            catch
            {
                Servidor.RemoveUsuario(tcpCliente);
            }
        }

    }
}
