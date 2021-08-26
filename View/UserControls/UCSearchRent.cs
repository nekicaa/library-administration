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
    public partial class UCSearchRent : UserControl
    {
        MainController mainController = new MainController();

        public UCSearchRent()
        {
            InitializeComponent();
        }

        private void UCSearchRent_Load(object sender, EventArgs e)
        {
            mainController.LoadDgvIznajmljivanje(dgvIznajmljivanja);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetIznajmljivanjeWithCondition(txtFilter, dgvIznajmljivanja);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneIznajmljivanje(dgvIznajmljivanja, txtDatIznajmljivanja, txtRokRazduzivanja, txtClan, dgvStavke);
        }
    }
}
