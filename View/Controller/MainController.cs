using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.Controller
{
    class MainController
    {
        internal void OpenUCAddBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddBook());
        }

        internal void OpenUCAddIzdanje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddIzdanje());
        }

        internal void OpenUCSearchBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSearchBook());
        }

        internal void OpenUCDeleteBook(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteBook());
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

        List<Autor> autori = new List<Autor>();

        internal void LoadComboBoxAutor(ComboBox cbAutor)
        {
            getAutor(cbAutor);
            cbAutor.SelectedIndex = -1;
            cbAutor.Text = "Izaberite autora...";
        }

        internal void getAutor(ComboBox cbAutor)
        {
            cbAutor.DataSource = Communication.Communication.Instance.GetAutor();
            autori = (List<Autor>)Communication.Communication.Instance.GetAutor();
        }

        List<Knjiga> knjige = new List<Knjiga>();

        internal void LoadComboBoxKnjiga(ComboBox cbKnjiga)
        {
            getKnjiga(cbKnjiga);
            cbKnjiga.SelectedIndex = -1;
            cbKnjiga.Text = "Izaberite knjigu...";
        }

        internal void getKnjiga(ComboBox cbKnjiga)
        {
            cbKnjiga.DataSource = Communication.Communication.Instance.GetKnjiga();
            knjige = (List<Knjiga>)Communication.Communication.Instance.GetKnjiga();
        }

        List<Clan> clanovi = new List<Clan>();

        internal void LoadComboBoxClan(ComboBox cbClan)
        {
            getClan(cbClan);
            cbClan.SelectedIndex = -1;
            cbClan.Text = "Izaberite clana...";
        }

        internal void getClan(ComboBox cbClan)
        {
            cbClan.DataSource = Communication.Communication.Instance.GetClan();
            clanovi = (List<Clan>)Communication.Communication.Instance.GetClan();
        }

        private BindingList<StavkaIznajmljivanja> stavkeBinding = new BindingList<StavkaIznajmljivanja>();

        internal void InitDgvStavke(DataGridView dgvStavke)
        {
            dgvStavke.DataSource = stavkeBinding;
        }

        internal void LoadDgvKnjiga(DataGridView dgvKnjige)
        {
            dgvKnjige.DataSource = new BindingList<Knjiga>((List<Knjiga>)Communication.Communication.Instance.GetKnjiga());
        }

        internal void LoadDgvIznajmljivanje(DataGridView dgvIznajmljivanja)
        {
            dgvIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>((List<Iznajmljivanje>)Communication.Communication.Instance.GetIznajmljivanje());
        }

        internal void LoadDgvClan(DataGridView dgvClanovi)
        {
            dgvClanovi.DataSource = new BindingList<Clan>((List<Clan>)Communication.Communication.Instance.GetClan());
        }

        internal void GetKnjigaWithCondition(TextBox txtFilter, DataGridView dgvKnjige)
        {
            Knjiga k = new Knjiga();
            k.Uslov = $"k.Naziv like '{txtFilter.Text}%' or k.Zanr like '{txtFilter.Text}%'";
            List<Knjiga> listKnjiga = Communication.Communication.Instance.GetKnjigaWithCondition(k);

            if(listKnjiga.Count == 0)
            {
                MessageBox.Show("Nema takvih knjiga!");
                dgvKnjige.DataSource = listKnjiga;
            } else
            {
                dgvKnjige.DataSource = listKnjiga;
                MessageBox.Show("Pronadjene su knjige.");
            }
        }

        internal void GetIznajmljivanjeWithCondition(TextBox txtFilter, DataGridView dgvIznajmljivanja)
        {
            Iznajmljivanje iz = new Iznajmljivanje();
            iz.Uslov = $"c.Ime like '{txtFilter.Text}%' or c.Prezime like '{txtFilter.Text}%'";
            List<Iznajmljivanje> listIznajmljivanje = Communication.Communication.Instance.GetIznajmljivanjeWithCondition(iz);

            if(listIznajmljivanje.Count == 0)
            {
                MessageBox.Show("Nema takvih iznajmljivanja!");
                dgvIznajmljivanja.DataSource = listIznajmljivanje;
            } else
            {
                dgvIznajmljivanja.DataSource = listIznajmljivanje;
                MessageBox.Show("Pronadjena su iznajmljivanja.");
            }
        }

        internal void GetClanWithCondition(TextBox txtFilter, DataGridView dgvClanovi)
        {
            Clan c = new Clan();
            c.Uslov = $"c.Ime like '{txtFilter.Text}%' or c.Prezime like '{txtFilter.Text}%'";
            List<Clan> listClan = Communication.Communication.Instance.GetClanWithCondition(c);

            if (listClan.Count == 0)
            {
                MessageBox.Show("Nema takvih clanova!");
                dgvClanovi.DataSource = listClan;
            } else
            {
                dgvClanovi.DataSource = listClan;
                MessageBox.Show("Pronadjeni su clanovi.");
            }
        }

        internal void GetOneKnjiga(DataGridView dgvKnjige, TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr, Label lblNaslov)
        {
            if(dgvKnjige.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije izabrana ni jedna knjiga!");
                return;
            }

            Knjiga k = new Knjiga();
            k.Uslov = $"Id={((Knjiga)dgvKnjige.SelectedRows[0].DataBoundItem).Id}";
            k = Communication.Communication.Instance.GetOneKnjiga(k);

            if(k == null)
            {
                MessageBox.Show("Nije pronadjena trazena knjiga!");
            } else
            {
                MessageBox.Show("Trazena knjiga je pronadjena!");
                txtNaziv.Text = k.Naziv;
                txtISBN.Text = k.ISBN;
                txtZanr.Text = k.Zanr;
                lblNaslov.Text += $" {k.Naziv}";
            }

        }

        internal void GetOneIznajmljivanje(DataGridView dgvIznajmljivanja, TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja, TextBox txtClan, DataGridView dgvStavke)
        {
            if(dgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije izabrano ni jedno iznajmljivanje!");
                return;
            }

            Iznajmljivanje iz = new Iznajmljivanje();
            iz.Uslov = $"iz.Id={((Iznajmljivanje)dgvIznajmljivanja.SelectedRows[0].DataBoundItem).Id}";
            iz = Communication.Communication.Instance.GetOneIznajmljivanje(iz);

            if(iz == null)
            {
                MessageBox.Show("Trazeno iznajmljivanje nije pronadjeno!");
            } else
            {
                MessageBox.Show("Trazeno iznajmljivanje je pronadjeno.");
                txtDatIznajmljivanja.Text = iz.DatumIznajmljivanja.ToString();
                txtRokRazduzivanja.Text = iz.RokZaRazduzivanje.ToString();
                txtClan.Text = iz.Clan.ToString();
                dgvStavke.DataSource = iz.Stavke;
            }
        }

        internal void GetOneClan(DataGridView dgvClanovi, TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            if (dgvClanovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije izabran ni jedan clan!");
                return;
            }

            Clan c = new Clan();
            c.Uslov = $"Id={((Clan)dgvClanovi.SelectedRows[0].DataBoundItem).Id}";
            c = Communication.Communication.Instance.GetOneClan(c);

            if (c == null)
            {
                MessageBox.Show("Trazeni clan nije pronadjen!");
            }
            else
            {
                MessageBox.Show("Clan je pronadjen!");
                txtIme.Text = c.Ime;
                txtPrezime.Text = c.Prezime;
                txtDatRodjenja.Text = c.DatumRodjenja.ToString();
                txtKontakt.Text = c.Kontakt;
            }
        }

        internal void AddStavka(ComboBox cbKnjiga, TextBox txtKolicina, DataGridView dgvStavke)
        {
            if(cbKnjiga.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali knjigu!");
                return;
            }
            if (!Helpers.UserControlHelpers.EmptyFieldValidation(txtKolicina) | !Helpers.UserControlHelpers.IntValidation(txtKolicina))
            {
                MessageBox.Show("Niste uneli kolicinu u odgovarajucem formatu");
                return;
            }

            if(stavkeBinding.Any(s => s.Knjiga == (Knjiga)cbKnjiga.SelectedItem))
            {
                stavkeBinding.First<StavkaIznajmljivanja>(s => s.Knjiga == (Knjiga)cbKnjiga.SelectedItem).Kolicina += int.Parse(txtKolicina.Text);
            } else
            {
                StavkaIznajmljivanja st = new StavkaIznajmljivanja
                {
                    RedniBroj = stavkeBinding.Count + 1,
                    Iznajmljivanje = new Iznajmljivanje(),
                    Knjiga = (Knjiga)cbKnjiga.SelectedItem,
                    Kolicina = int.Parse(txtKolicina.Text)
                };
                stavkeBinding.Add(st);
            }
            MessageBox.Show("Uspesno ste dodali stavku iznajmljivanja!");
            dgvStavke.Refresh();
            txtKolicina.Text = "";
            LoadComboBoxKnjiga(cbKnjiga);
        }

        internal void RemoveStavka(DataGridView dgvStavke)
        {
            foreach (DataGridViewRow row in dgvStavke.SelectedRows)
            {
                StavkaIznajmljivanja st = (StavkaIznajmljivanja)row.DataBoundItem;
                stavkeBinding.Remove(st);
            }
            int i = 1;
            foreach(StavkaIznajmljivanja stavka in stavkeBinding)
            {
                stavka.RedniBroj = i;
                i++;
            }
        }

        internal void SaveKnjiga(TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtNaziv) | !UserControlHelpers.EmptyFieldValidation(txtISBN) | !UserControlHelpers.EmptyFieldValidation(txtZanr))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
                return;
            }

            if (!UserControlHelpers.AllNumberValidation(txtISBN))
            {
                MessageBox.Show("ISBN je u losem formatu!");
                return;
            }

            try
            {
                Knjiga k = new Knjiga
                {
                    Naziv = txtNaziv.Text,
                    ISBN = txtISBN.Text,
                    Zanr = txtZanr.Text
                };
                Communication.Communication.Instance.SaveKnjiga(k);
                MessageBox.Show("Knjiga uspesno sacuvana!");
                // kako prebaciti na ucIzdanje?
                txtNaziv.Text = "";
                txtISBN.Text = "";
                txtZanr.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SaveIzdanje(ComboBox cbKnjige, ComboBox cbAutori, TextBox txtGodStampe, TextBox txtIzdavac)
        {
            if (cbKnjige.SelectedIndex == -1)
            {
                MessageBox.Show("Nije odabrana knjiga!");
                return;
            }

            if (cbAutori.SelectedIndex == -1)
            {
                MessageBox.Show("Nije odabran autor!");
                return;
            }

            if (!UserControlHelpers.EmptyFieldValidation(txtGodStampe) | !UserControlHelpers.EmptyFieldValidation(txtIzdavac))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
                return;
            }

            if (!UserControlHelpers.AllNumberValidation(txtGodStampe))
            {
                MessageBox.Show("Godina stampe je u losem formatu!");
                return;
            }

            try
            {
                Izdanje iz = new Izdanje
                {
                    Knjiga = (Knjiga)cbKnjige.SelectedItem,
                    Autor = (Autor)cbAutori.SelectedItem,
                    GodinaStampe = txtGodStampe.Text,
                    Izdavac = txtIzdavac.Text
                };
                Communication.Communication.Instance.SaveIzdanje(iz);
                MessageBox.Show("Izdanje uspesno sacuvano!");
                LoadComboBoxAutor(cbAutori);
                LoadComboBoxKnjiga(cbKnjige);
                txtGodStampe.Text = "";
                txtIzdavac.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SaveIznajmljivanje(ComboBox cbClan, DataGridView dgvStavke, TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja)
        {
            if (cbClan.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati clana!");
                return;
            }

            try
            {
                Iznajmljivanje iz = new Iznajmljivanje
                {
                    DatumIznajmljivanja = DateTime.Now,
                    RokZaRazduzivanje = DateTime.Now.AddDays(14),
                    Clan = (Clan)cbClan.SelectedItem
                };
                iz.Stavke = stavkeBinding.ToList();
                Communication.Communication.Instance.SaveIznajmljivanje(iz);
                MessageBox.Show("Iznajmljivanje sacuvano!");
                stavkeBinding.Clear();
                LoadComboBoxClan(cbClan);
                dgvStavke.Refresh();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Iznajmljivanje nije sacuvano.\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Iznajmljivanje nije sacuvano.\n" + ex.Message);
            }
        }

        internal void SaveClan(TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtIme) | !UserControlHelpers.EmptyFieldValidation(txtPrezime) | !UserControlHelpers.EmptyFieldValidation(txtDatRodjenja) | !UserControlHelpers.EmptyFieldValidation(txtKontakt))
            {
                MessageBox.Show("Niste popunili sva polja!");
                return;
            }
            if (!UserControlHelpers.DateTimeValidation(txtDatRodjenja))
            {
                MessageBox.Show("Datum rodjenja u losem formatu!");
                return;
            }
            if (!UserControlHelpers.AllNumberValidation(txtKontakt))
            {
                MessageBox.Show("Kontakt u losem formatu!");
                return;
            }

            try
            {
                Clan c = new Clan
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = DateTime.Parse(txtDatRodjenja.Text),
                    Kontakt = txtKontakt.Text
                };
                Communication.Communication.Instance.SaveClan(c);
                MessageBox.Show("Clan uspesno sacuvan!");
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtDatRodjenja.Text = "";
                txtKontakt.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateClan(TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt, DataGridView dgvClanovi)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtIme) | !UserControlHelpers.EmptyFieldValidation(txtPrezime) | !UserControlHelpers.EmptyFieldValidation(txtDatRodjenja) | !UserControlHelpers.EmptyFieldValidation(txtKontakt))
            {
                MessageBox.Show("Niste popunili sva polja!");
                return;
            }
            if (!UserControlHelpers.DateTimeValidation(txtDatRodjenja))
            {
                MessageBox.Show("Datum rodjenja u losem formatu!");
                return;
            }
            if (!UserControlHelpers.AllNumberValidation(txtKontakt))
            {
                MessageBox.Show("Kontakt u losem formatu!");
                return;
            }
            if (dgvClanovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da odaberete clana!");
                return;
            }

            try
            {
                Clan c = new Clan
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = DateTime.Parse(txtDatRodjenja.Text),
                    Kontakt = txtKontakt.Text
                };
                Communication.Communication.Instance.UpdateClan(c);
                MessageBox.Show("Clan uspesno izmenjen!");
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtDatRodjenja.Text = "";
                txtKontakt.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteKnjiga(DataGridView dgvKnjige, TextBox txtNaziv, TextBox txtISBN, TextBox txtZanr)
        {
            if(dgvKnjige.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati knjige!");
                return;
            }

            try
            {
                Communication.Communication.Instance.DeleteKnjiga((Knjiga)dgvKnjige.SelectedRows[0].DataBoundItem);
                MessageBox.Show("Uspesno obrisana knjiga!");
                dgvKnjige.Refresh();
                txtNaziv.Text = "";
                txtISBN.Text = "";
                txtZanr.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteIznajmljivanje(DataGridView dgvIznajmljivanja, TextBox txtDatIznajmljivanja, TextBox txtRokRazduzivanja, TextBox txtClan, DataGridView dgvStavke)
        {
            if(dgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati iznajmljivanje!");
                return;
            }

            try
            {
                Iznajmljivanje iznajmljivanje = (Iznajmljivanje)dgvIznajmljivanja.SelectedRows[0].DataBoundItem;
                Communication.Communication.Instance.DeleteIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Uspesno obrisano iznajmljivanje!");
                dgvIznajmljivanja.Refresh();
                dgvStavke.Refresh();
                txtDatIznajmljivanja.Text = "";
                txtRokRazduzivanja.Text = "";
                txtClan.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteClan(DataGridView dgvClanovi, TextBox txtIme, TextBox txtPrezime, TextBox txtDatRodjenja, TextBox txtKontakt)
        {
            if (dgvClanovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati clana!");
                return;
            }

            try
            {
                Communication.Communication.Instance.DeleteClan((Clan)dgvClanovi.SelectedRows[0].DataBoundItem);
                MessageBox.Show("Clan je uspesno obrisan!");
                dgvClanovi.Refresh();
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtDatRodjenja.Text = "";
                txtKontakt.Text = "";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
