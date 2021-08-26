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
    public partial class UCAddBook : UserControl
    {
        MainController mainController = new MainController();

        public UCAddBook()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SaveBook(txtNaziv, txtISBN, txtZanr, cbAutor, txtGodStampe, txtIzdavac);
        }

        private void UCAddBook_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBoxAutor(cbAutor);
        }
    }
}
