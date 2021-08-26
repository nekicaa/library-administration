using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
    public partial class FrmMain : Form
    {
        MainController mainController = new MainController();

        public FrmMain()
        {
            InitializeComponent();
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void dodajNovuKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddBook(this);
        }

        private void pretraziKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSearchBook(this);
        }

        private void obrisiKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteBook(this);
        }

        private void dodajNovogClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddMember(this);
        }

        private void izmeniClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCChangeMember(this);
        }

        private void obrisiClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteMember(this);
        }

        private void napraviNovoIznajmljivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddRent(this);
        }

        private void pretragaIznajmljenihKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSearchRent(this);
        }

        private void razduzivanjeKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteRent(this);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
