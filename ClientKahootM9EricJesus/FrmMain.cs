using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientKahootM9EricJesus.CLASSES;

namespace ClientKahootM9EricJesus
{
    public partial class FrmMain : Form
    {
        ClXerraire xerraire;
        ClXafarder xafarder;
        ClSocket socket;
        public string nick;

        int portEscolta = 5555;
        public int numResposta = 0;
        int nSegons = 0;

        Timer tm;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btEscoltar_Click(object sender, EventArgs e)
        {
            nick = tbNick.Text;
            socket = new ClSocket(this,tbIp.Text,portEscolta);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            xafarder = new ClXafarder(this,portEscolta);
            xafarder.MissatgeRebut += (missatge) =>
            {
                this.Invoke(new Action(() => comencarPartida(missatge)));
            };

        }

        private void comencarPartida(string missatge)
        {
            lbIp.Visible = false;
            tbIp.Visible = false;
            btEscoltar.Visible = false;

            lbEsperant.Visible = true;
            iniTimer();
        }

        private void iniTimer()
        {
            tm = new Timer();
            
        }

        private void segonsPasats()
        {
            nSegons++;
            if (nSegons == 10) mostrarPreguntas();
        }

        private void mostrarPreguntas()
        {

        }
        
    }
}
