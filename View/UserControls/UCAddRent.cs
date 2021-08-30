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
    public partial class UCAddRent : UserControl
    {
        MainController mainController = new MainController();

        public UCAddRent()
        {
            InitializeComponent();
            mainController.InitDgvStavke(dgvStavke);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SaveIznajmljivanje(cbClan, dgvStavke, txtDatIznajmljivanja, txtRokRazduzivanja);
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            mainController.AddStavka(cbKnjiga, txtKolicina, dgvStavke);
        }

        private void btnObrisiStavke_Click(object sender, EventArgs e)
        {
            mainController.RemoveStavka(dgvStavke);
        }

        private void UCAddRent_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBoxClan(cbClan);
            mainController.LoadComboBoxKnjiga(cbKnjiga);
            txtDatIznajmljivanja.Text = DateTime.Now.ToString();
            txtRokRazduzivanja.Text = DateTime.Now.AddDays(14).ToString();
        }
    }
}
