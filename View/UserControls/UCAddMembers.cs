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
    public partial class UCAddMembers : UserControl
    {
        MainController mainController = new MainController();

        public UCAddMembers()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            mainController.SaveMember(txtIme, txtPrezime, txtDatRodjenja, txtKontakt);
        }
    }
}
