using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientKahootM9EricJesus.CLASSES
{
    internal class ClXerraire
    {
        TcpClient xerraire;
        Thread thXerraire;
        string ip, nick;
        int port;
        FrmMain Fmain;
        public ClXerraire(FrmMain xFmain,string xIp, int xPort)
        {
            ip = xIp;
            port = xPort;
            Fmain = xFmain;
        }

        public async Task ConnectarXerraire()
        {
            Boolean xb = false;
            try
            {
                xerraire = new TcpClient();
                await xerraire.ConnectAsync(ip, port);
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ AL CONNECTAR AMB LA IP REMOTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
        }

        public void enviarMissatge(string msg)
        {
            if (msg.Trim() != "")
            {
                if (xerraire.GetStream().CanWrite)
                {
                    try
                    {
                        xerraire.GetStream().Write(System.Text.Encoding.Default.GetBytes(msg), 0, msg.Length);
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show(excp.Message, "EXCEPCIÓ EN L'ENVIAMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No puc escriure", "ERROR A L'INTENTAR ENVIAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
