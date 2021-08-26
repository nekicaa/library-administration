using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.UserControls;

namespace View.Controller
{
    class MainController
    {
        internal void OpenUCAddBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddBook());
        }

        internal void OpenUCSearchBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSearchBook());
        }

        internal void InitDataGridView(DataGridView dataGridView1)
        {
            //throw new NotImplementedException();
        }

        internal void LoadDgvIznajmljivanje(DataGridView dgvIznajmljivanja)
        {
            //throw new NotImplementedException();
        }

        internal void GetIznajmljivanjeWithCondition(TextBox txtFilter, DataGridView dgvIznajmljivanja)
        {
            //throw new NotImplementedException();
        }

        internal void GetOneKnjigaDel(DataGridView dgvKnjige, TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr)
        {
            //throw new NotImplementedException();
        }

        internal void RemoveKnjiga(DataGridView dgvKnjige, TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr)
        {
            //throw new NotImplementedException();
        }

        internal void RemoveIznajmljivanje(DataGridView dgvIznajmljivanja, TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja, TextBox txtClan, DataGridView dgvStavke)
        {
            //throw new NotImplementedException();
        }

        internal void RemoveClan(DataGridView dgvClanovi, TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            //throw new NotImplementedException();
        }

        internal void GetOneIznajmljivanje(DataGridView dgvIznajmljivanja, TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja, TextBox txtClan, DataGridView dgvStavke)
        {
            //throw new NotImplementedException();
        }

        internal void LoadDgvKnjiga(DataGridView dgvKnjige)
        {
            //throw new NotImplementedException();
        }

        internal void GetKnjigaWithCondition(TextBox txtFilter, DataGridView dgvKnjige)
        {
            //throw new NotImplementedException();
        }

        internal void GetOneKnjiga(DataGridView dgvKnjige, TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr, TextBox txtAutor, TextBox txtGodStampe, TextBox txtIzdavac)
        {
            //throw new NotImplementedException();
        }

        internal void OpenUCDeleteBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteBook());
        }

        internal void LoadDgvClan(DataGridView dgvClanovi)
        {
            //throw new NotImplementedException();
        }

        internal void GetClanWithCondition(TextBox txtFilter, DataGridView dgvClanovi)
        {
            //throw new NotImplementedException();
        }

        internal void GetOneClan(DataGridView dgvClanovi, TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            //throw new NotImplementedException();
        }

        internal void UpdateClan(TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt, DataGridView dgvClanovi)
        {
            //throw new NotImplementedException();
        }

        internal void SaveIznajmljivanje(TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja, ComboBox cbClan)
        {
            //throw new NotImplementedException();
        }

        internal void AddStavka(ComboBox cbKnjiga, TextBox txtKolicina, DataGridView dgvStavke)
        {
            //throw new NotImplementedException();
        }

        internal void RemoveStavka(DataGridView dgvStavke)
        {
            //throw new NotImplementedException();
        }

        internal void SaveBook(TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr, ComboBox cbAutor, TextBox txtGodStampe, TextBox txtIzdavac)
        {
            //throw new NotImplementedException();
        }

        internal void SaveMember(TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            //throw new NotImplementedException();
        }

        internal void LoadComboBoxKnjiga(ComboBox cbKnjiga)
        {
            //throw new NotImplementedException();
        }

        internal void LoadComboBoxClan(ComboBox cbClan)
        {
            //throw new NotImplementedException();
        }

        internal void LoadComboBoxAutor(ComboBox cbAutor)
        {
            //throw new NotImplementedException();
        }

        internal void OpenUCAddMember(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddMembers());
        }

        internal void OpenUCChangeMember(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCChangeMember());
        }

        internal void OpenUCDeleteMember(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteMember());
        }

        internal void OpenUCAddRent(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddRent());
        }

        internal void OpenUCSearchRent(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSearchRent());
        }

        internal void OpenUCDeleteRent(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteRent());
        }
    }
}
