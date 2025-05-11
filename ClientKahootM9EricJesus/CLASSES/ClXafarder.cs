using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientKahootM9EricJesus.CLASSES
{
    internal class ClXafarder
    {
        Thread ThXafarder;
        int port;
        const Int32 MAX_BUFFER = 4096;


        ClXafarder(int xPort)
        {
            port = xPort;
            ConnectarXafarder();
        }

        private void ConnectarXafarder()
        {
            ThXafarder = new Thread(Escoltar);

        }

        private void Escoltar()
        {
            Int32 nBytes = 0;
            String xmsg = "";
            Byte[] xbuffer = new Byte[MAX_BUFFER];                // és on deixarem les dades rebudes

            do
            {
                client_xafarder = xafarder.AcceptTcpClient();         // acceptem un client que vingui d'un altre procés                    
                while (client_xafarder.Connected)
                {
                    NetworkStream stream = client_xafarder.GetStream();   // obtenim el stream per a llegir el que ens envien
                    nBytes = stream.Read(xbuffer, 0, xbuffer.Length);
                    xmsg = Encoding.ASCII.GetString(xbuffer, 0, nBytes);
                    if (xmsg.Length != 0)
                    {
                        this.Invoke(new delegatMissatge(updText), xmsg);
                        Array.Clear(xbuffer, 0, xbuffer.Length);
                    }
                }
            } while (!(client_xafarder.Connected));
        }
    }
}
