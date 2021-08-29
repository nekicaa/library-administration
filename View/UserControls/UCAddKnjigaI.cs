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
    public partial class UCAddKnjigaI : UserControl
    {
        MainController mainController = new MainController();

        public UCAddKnjigaI()
        {
            InitializeComponent();
            mainController.InitDgvIzdanja(dgvIzdanja);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SaveKnjiga(txtNaziv, txtISBN, txtZanr, dgvIzdanja);
        }

        private void UCAddKnjigaI_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBoxAutor(cbAutor);
        }

        private void btnDodajIzdanje_Click(object sender, EventArgs e)
        {
            mainController.AddIzdanje(cbAutor, txtGodStampe, txtIzdavac, dgvIzdanja);
        }

        private void btnObrisiIzdanje_Click(object sender, EventArgs e)
        {
            mainController.RemoveIzdanje(dgvIzdanja);
        }
    }
}
