namespace View
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iznajmljivanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napraviNovoIznajmljivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIznajmljenihKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razduzivanjeKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 426);
            this.pnlMain.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(277, 164);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(232, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Administrator";
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
            this.pretraziKnjigeToolStripMenuItem,
            this.obrisiKnjiguToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // dodajNovuKnjiguToolStripMenuItem
            // 
            this.dodajNovuKnjiguToolStripMenuItem.Name = "dodajNovuKnjiguToolStripMenuItem";
            this.dodajNovuKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNovuKnjiguToolStripMenuItem.Text = "Dodaj novu knjigu";
            this.dodajNovuKnjiguToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuKnjiguToolStripMenuItem_Click);
            // 
            // pretraziKnjigeToolStripMenuItem
            // 
            this.pretraziKnjigeToolStripMenuItem.Name = "pretraziKnjigeToolStripMenuItem";
            this.pretraziKnjigeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretraziKnjigeToolStripMenuItem.Text = "Pretrazi knjige";
            this.pretraziKnjigeToolStripMenuItem.Click += new System.EventHandler(this.pretraziKnjigeToolStripMenuItem_Click);
            // 
            // obrisiKnjiguToolStripMenuItem
            // 
            this.obrisiKnjiguToolStripMenuItem.Name = "obrisiKnjiguToolStripMenuItem";
            this.obrisiKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrisiKnjiguToolStripMenuItem.Text = "Obrisi knjigu";
            this.obrisiKnjiguToolStripMenuItem.Click += new System.EventHandler(this.obrisiKnjiguToolStripMenuItem_Click);
            // 
            // clanoviToolStripMenuItem
            // 
            this.clanoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogClanaToolStripMenuItem,
            this.izmeniClanaToolStripMenuItem,
            this.obrisiClanaToolStripMenuItem});
            this.clanoviToolStripMenuItem.Name = "clanoviToolStripMenuItem";
            this.clanoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clanoviToolStripMenuItem.Text = "Clanovi";
            // 
            // dodajNovogClanaToolStripMenuItem
            // 
            this.dodajNovogClanaToolStripMenuItem.Name = "dodajNovogClanaToolStripMenuItem";
            this.dodajNovogClanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNovogClanaToolStripMenuItem.Text = "Dodaj novog clana";
            this.dodajNovogClanaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogClanaToolStripMenuItem_Click);
            // 
            // izmeniClanaToolStripMenuItem
            // 
            this.izmeniClanaToolStripMenuItem.Name = "izmeniClanaToolStripMenuItem";
            this.izmeniClanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izmeniClanaToolStripMenuItem.Text = "Izmeni clana";
            this.izmeniClanaToolStripMenuItem.Click += new System.EventHandler(this.izmeniClanaToolStripMenuItem_Click);
            // 
            // obrisiClanaToolStripMenuItem
            // 
            this.obrisiClanaToolStripMenuItem.Name = "obrisiClanaToolStripMenuItem";
            this.obrisiClanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrisiClanaToolStripMenuItem.Text = "Obrisi clana";
            this.obrisiClanaToolStripMenuItem.Click += new System.EventHandler(this.obrisiClanaToolStripMenuItem_Click);
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
            // napraviNovoIznajmljivanjeToolStripMenuItem
            // 
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Name = "napraviNovoIznajmljivanjeToolStripMenuItem";
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Text = "Napravi novo iznajmljivanje";
            this.napraviNovoIznajmljivanjeToolStripMenuItem.Click += new System.EventHandler(this.napraviNovoIznajmljivanjeToolStripMenuItem_Click);
            // 
            // pretragaIznajmljenihKnjigaToolStripMenuItem
            // 
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Name = "pretragaIznajmljenihKnjigaToolStripMenuItem";
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Text = "Pretraga iznajmljenih knjiga";
            this.pretragaIznajmljenihKnjigaToolStripMenuItem.Click += new System.EventHandler(this.pretragaIznajmljenihKnjigaToolStripMenuItem_Click);
            // 
            // razduzivanjeKnjigaToolStripMenuItem
            // 
            this.razduzivanjeKnjigaToolStripMenuItem.Name = "razduzivanjeKnjigaToolStripMenuItem";
            this.razduzivanjeKnjigaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.razduzivanjeKnjigaToolStripMenuItem.Text = "Razduzivanje knjiga";
            this.razduzivanjeKnjigaToolStripMenuItem.Click += new System.EventHandler(this.razduzivanjeKnjigaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "Pocetna strana";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iznajmljivanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napraviNovoIznajmljivanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIznajmljenihKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razduzivanjeKnjigaToolStripMenuItem;
    }
}