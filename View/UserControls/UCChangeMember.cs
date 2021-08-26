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
using Domain;

namespace View.UserControls
{
    public partial class UCChangeMember : UserControl
    {
        MainController mainController = new MainController();

        public UCChangeMember()
        {
            InitializeComponent();
            btnIzmeni.Enabled = false;
        }

        private void UCChangeMember_Load(object sender, EventArgs e)
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
            btnIzmeni.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateClan(txtIme, txtPrezime, txtDatRodjenja, txtKontakt, dgvClanovi);
        }
    }
}
