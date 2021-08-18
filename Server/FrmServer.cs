using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtStanjeServera.Text = "Server je pokrenut";
                txtStanjeServera.BackColor = Color.LightGreen;
            }
            catch (SocketException ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Neuspesno pokretanje servera! " + ex.Message);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }
    }
}
