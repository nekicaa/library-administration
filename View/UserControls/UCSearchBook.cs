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
    public partial class UCSearchBook : UserControl
    {
        MainController mainController = new MainController();

        public UCSearchBook()
        {
            InitializeComponent();
        }

        private void UCSearchBook_Load(object sender, EventArgs e)
        {
            mainController.LoadDgvKnjiga(dgvKnjige);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetKnjigaWithCondition(txtFilter, dgvKnjige);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneKnjiga(dgvKnjige, txtNaziv, txtISBN, txtZanr, lblNaslov);
        }
    }
}
