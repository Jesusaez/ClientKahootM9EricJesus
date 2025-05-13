using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientKahootM9EricJesus.CLASSES
{
    internal class ClSocket
    {
        string Socket;
        FrmMain Fmain;
        ClXerraire xerraire;
        ClXafarder xafarder;
        string ip;
        int port;
        public ClSocket(FrmMain xFmain, string xIp, string xPort)
        {
            ip = xIp;
            port = Int32.Parse(xPort);
            xerraire = new ClXerraire(Fmain, ip, port);
            xafarder = new ClXafarder(Fmain, port);
            xerraire.ConnectarXerraire();
            Fmain = xFmain;
        }
        public ClSocket(FrmMain xFmain, string xIp, int xPort)
        {
            ip = xIp;
            port = xPort;
            xerraire = new ClXerraire(Fmain, ip, port);
            //xafarder = new ClXafarder(Fmain, port);
            xerraire.ConnectarXerraire();
            Fmain = xFmain;
        }
        public void EnviarSocket(string op)
        {
            string msg = "";
            switch(op)
            {
                case "LOGIN": msg = $"LOGIN;{Fmain.nick};{conseguirIp()}";
                break;
                case "RESPOSTA": msg = $"RESPOSTA;{Fmain.numResposta}";
                break;
                //case 3: msg = "c";
                //break;
                //case 4: msg = "d";
                //break;
                //case 5: msg = "e";
                //break;
            }
            xerraire.enviarMissatge(msg);
        }

        private string conseguirIp()
        {
            // Obtener el nombre del host
            string hostName = Dns.GetHostName();

            // Obtener todas las direcciones IP asociadas al host
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);

            // Buscar la primera dirección IPv4
            IPAddress firstIPv4 = ipEntry.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            return firstIPv4.ToString();
        }
    }
}
