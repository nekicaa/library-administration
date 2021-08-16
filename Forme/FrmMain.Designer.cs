namespace Forme
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iznajmljivanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziClanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napraviNovoIznajmljivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIznajmljenihKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razduzivanjeKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.lblWelcome);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(800, 426);
            this.pnlMainContainer.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(277, 164);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(153, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.clanoviToolStripMenuItem,
            this.iznajmljivanjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovuKnjiguToolStripMenuItem,
            this.izmeniKnjiguToolStripMenuItem,
            this.obrisiKnjiguToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // clanoviToolStripMenuItem
            // 
            this.clanoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogClanaToolStripMenuItem,
            this.pretraziClanoveToolStripMenuItem,
            this.obrisiClanaToolStripMenuItem});
            this.clanoviToolStripMenuItem.Name = "clanoviToolStripMenuItem";
            this.clanoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clanoviToolStripMenuItem.Text = "Clanovi";
            // 
            // iznajmljivanjaToolStripMenuItem
            // 
            this.iznajmljivanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napraviNovoIznajmljivanjeToolStripMenuItem,
            this.pretragaIznajmljenihKnjigaToolStripMenuItem,
            this.razduzivanjeKnjigaToolStripMenuItem});
            this.iznajmljivanjaToolStripMenuItem.Name = "iznajmljivanjaToolStripMenuItem";
            this.iznajmljivanjaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.iznajmljivanjaToolStripMenuItem.Text = "Iznajmljivanja";
            // 
            // dodajNovuKnjiguToolStripMenuItem
            // 
            this.dodajNovuKnjiguToolStripMenuItem.Name = "dodajNovuKnjiguToolStripMenuItem";
            this.dodajNovuKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNovuKnjiguToolStripMenuItem.Text = "Dodaj novu knjigu";
            // 
            // izmeniKnjiguToolStripMenuItem
            // 
            this.izmeniKnjiguToolStripMenuItem.Name = "izmeniKnjiguToolStripMenuItem";
            this.izmeniKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izmeniKnjiguToolStripMenuItem.Text = "Izmeni knjigu";
            // 
            // obrisiKnjiguToolStripMenuItem
            // 
            this.obrisiKnjiguToolStripMenuItem.Name = "obrisiKnjiguToolStripMenuItem";
            this.obrisiKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrisiKnjiguToolStripMenuItem.Text = "Obrisi knjigu";
            // 
            // dodajNovogClanaToolStripMenuItem
            // 
            this.dodajNovogClanaToolStripMenuItem.Name = "dodajNovogClanaToolStripMenuItem";
            this.dodajNovogClanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNovogClanaToolStripMenuItem.Text = "Dodaj novog clana";
            // 
            // pretraziClanoveToolStripMenuItem
            // 
            this.pretraziClanoveToolStripMenuItem.Name = "pretraziClanoveToolStripMenuItem";
            this.pretraziClanoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretraziClanoveToolStripMenuItem.Text = "Pretrazi clanove";
            // 
            // obrisiClanaToolStripMenuItem
            // 
            this.obrisiClanaToolStripMenuItem.Name = "obrisiClanaToolStripMenuItem";
            this.obrisiClanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrisiClanaToolStripMenuItem.Text = "Obrisi clana";
            // 
            // napraviNovoIznajmljivanjeToolStripMenuItem
            // 
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Name = "napraviNovoIznajmljivanjeToolStripMenuItem";
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Text = "Napravi novo iznajmljivanje";
            // 
            // pretragaIznajmljenihKnjigaToolStripMenuItem
            // 
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Name = "pretragaIznajmljenihKnjigaToolStripMenuItem";
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Text = "Pretraga iznajmljenih knjiga";
            // 
            // razduzivanjeKnjigaToolStripMenuItem
            // 
            this.razduzivanjeKnjigaToolStripMenuItem.Name = "razduzivanjeKnjigaToolStripMenuItem";
            this.razduzivanjeKnjigaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.razduzivanjeKnjigaToolStripMenuItem.Text = "Razduzivanje knjiga";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "Pocetna strana";
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziClanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iznajmljivanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napraviNovoIznajmljivanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIznajmljenihKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razduzivanjeKnjigaToolStripMenuItem;
    }
}