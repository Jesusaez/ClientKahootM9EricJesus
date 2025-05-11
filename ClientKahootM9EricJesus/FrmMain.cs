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

        int portEscolta = 6001;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btEscoltar_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
