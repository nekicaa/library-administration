using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
    public partial class UCDeleteMember : UserControl
    {
        MainController mainController = new MainController();

        public UCDeleteMember()
        {
            InitializeComponent();
            btnObrisi.Enabled = false;
        }

        private void UCDeleteMember_Load(object sender, EventArgs e)
        {
            mainController.LoadDgvClan(dgvClanovi);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetClanWithCondition(txtFilter, dgvClanovi);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneClan(dgvClanovi, txtIme, txtPrezime, txtDatRodjenja, txtKontakt);
            btnObrisi.Enabled = true;

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            mainController.RemoveClan(dgvClanovi, txtIme, txtPrezime, txtDatRodjenja, txtKontakt);
        }
    }
}
