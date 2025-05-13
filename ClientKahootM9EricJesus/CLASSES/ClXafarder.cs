using System;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading;

namespace ClientKahootM9EricJesus.CLASSES
{
    internal class ClXafarder
    {
        private Thread ThXafarder;
        private int port;
        private const int MAX_BUFFER = 4096;
        Boolean conectado = false;

        private TcpListener xafarder;
        private TcpClient client_xafarder;

        public delegate void MissatgeRebutHandler(string missatge);
        public event MissatgeRebutHandler MissatgeRebut;

        public ClXafarder(FrmMain xFmain,int xPort)
        {
            port = xPort;
            ConnectarXafarder();
        }
        public ClXafarder(FrmMain xFmain,string xPort)
        {
            port = Int32.Parse(xPort);
            ConnectarXafarder();
        }

        private void ConnectarXafarder()
        {
            try
            {
                xafarder = new TcpListener(IPAddress.Any, port);
                xafarder.Start();
                ThXafarder = new Thread(Escoltar);
                ThXafarder.IsBackground = true;
                ThXafarder.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Escoltar()
        {
            const int MAX_BUFFER = 4096;
            byte[] xbuffer = new byte[MAX_BUFFER];

            try
            {
                while (true)
                {
                    client_xafarder = xafarder.AcceptTcpClient();
                    NetworkStream stream = client_xafarder.GetStream();

                    int nBytes;
                    while ((nBytes = stream.Read(xbuffer, 0, xbuffer.Length)) > 0)
                    {
                        string xmsg = Encoding.UTF8.GetString(xbuffer, 0, nBytes);

                        if (conectado)
                        {
                            string[] msgSocket = xmsg.Split(';');

                            if (msgSocket[1] == "PREGUNTA")
                            {
                                MissatgeRebut?.Invoke(msgSocket[2]);
                            }
                        }
                        else
                        {
                            //leer el S o la N y si es S cambiar a true y activar coso en el main para enseñar el esperando.
                            if (xmsg == "S")
                            {
                                conectado = true;
                                MissatgeRebut?.Invoke(xmsg);
                            }
                        }
                    }

                    client_xafarder.Close();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Error de socket: " + ex.Message);
            }
        }

    }
}
