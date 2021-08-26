﻿using System;
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
    public partial class UCDeleteBook : UserControl
    {
        MainController mainController = new MainController();

        public UCDeleteBook()
        {
            InitializeComponent();
            btnObrisi.Enabled = false;
        }

        private void UCDeleteBook_Load(object sender, EventArgs e)
        {
            mainController.LoadDgvKnjiga(dgvKnjige);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetKnjigaWithCondition(txtFilter, dgvKnjige);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneKnjigaDel(dgvKnjige, txtNaziv, txtISBN, txtZanr);
            btnObrisi.Enabled = true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            mainController.RemoveKnjiga(dgvKnjige, txtNaziv, txtISBN, txtZanr);
        }
    }
}
