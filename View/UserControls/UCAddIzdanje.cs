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
    public partial class UCAddIzdanje : UserControl
    {
        MainController mainController = new MainController();

        public UCAddIzdanje()
        {
            InitializeComponent();
        }

        private void UCAddIzdanje_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBoxAutor(cbAutori);
            mainController.LoadComboBoxKnjiga(cbKnjige);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SaveIzdanje(cbKnjige, cbAutori, txtGodStampe, txtIzdavac);
        }
    }
}
