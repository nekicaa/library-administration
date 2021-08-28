using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class LoginController
    {
        internal void Login(TextBox txtKorisnickoIme, TextBox txtSifra, FrmLogin frmLogin)
        {
            if (!UserControlHelpers.
                EmptyFieldValidation(txtKorisnickoIme)
                | !UserControlHelpers.EmptyFieldValidation(txtSifra))
            {
                return;
            }
            try
            {
                Administrator a = Communication.Communication.Instance.Login(txtKorisnickoIme.Text, txtSifra.Text);

                if (a != null)
                {
                    if (a.StatusUlogovan)
                    {
                        throw new SystemNotFoundException("Administrator je već ulogovan!");
                    }
                    FrmMain frmMain = new FrmMain(a);
                    MessageBox.Show($"Administrator {a.Ime} {a.Prezime} se uspešno prijavio!");
                    frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
                    frmLogin.Visible = false;
                    frmMain.ShowDialog();
                }
                else throw new SystemNotFoundException();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                return false;
            }
        }
    }
}
