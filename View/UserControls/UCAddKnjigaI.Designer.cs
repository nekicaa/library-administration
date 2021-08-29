namespace View.UserControls
{
    partial class UCAddKnjigaI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajIzdanje = new System.Windows.Forms.Button();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.txtGodStampe = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiIzdanje = new System.Windows.Forms.Button();
            this.dgvIzdanja = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(168, 158);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(216, 20);
            this.txtZanr.TabIndex = 15;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(168, 116);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(216, 20);
            this.txtISBN.TabIndex = 14;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(168, 70);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(216, 20);
            this.txtNaziv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Zanr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajIzdanje);
            this.groupBox1.Controls.Add(this.cbAutor);
            this.groupBox1.Controls.Add(this.txtGodStampe);
            this.groupBox1.Controls.Add(this.txtIzdavac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(412, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj izdanje";
            // 
            // btnDodajIzdanje
            // 
            this.btnDodajIzdanje.Location = new System.Drawing.Point(141, 161);
            this.btnDodajIzdanje.Name = "btnDodajIzdanje";
            this.btnDodajIzdanje.Size = new System.Drawing.Size(106, 23);
            this.btnDodajIzdanje.TabIndex = 11;
            this.btnDodajIzdanje.Text = "Dodaj izdanje";
            this.btnDodajIzdanje.UseVisualStyleBackColor = true;
            this.btnDodajIzdanje.Click += new System.EventHandler(this.btnDodajIzdanje_Click);
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(141, 32);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(178, 21);
            this.cbAutor.TabIndex = 10;
            // 
            // txtGodStampe
            // 
            this.txtGodStampe.Location = new System.Drawing.Point(141, 75);
            this.txtGodStampe.Name = "txtGodStampe";
            this.txtGodStampe.Size = new System.Drawing.Size(178, 20);
            this.txtGodStampe.TabIndex = 8;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(141, 115);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(178, 20);
            this.txtIzdavac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Godina stampe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Izdavac";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(421, 358);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(190, 23);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj knjigu";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dodaj novu knjigu";
            // 
            // btnObrisiIzdanje
            // 
            this.btnObrisiIzdanje.Location = new System.Drawing.Point(421, 300);
            this.btnObrisiIzdanje.Name = "btnObrisiIzdanje";
            this.btnObrisiIzdanje.Size = new System.Drawing.Size(106, 23);
            this.btnObrisiIzdanje.TabIndex = 16;
            this.btnObrisiIzdanje.Text = "Obrisi izdanje";
            this.btnObrisiIzdanje.UseVisualStyleBackColor = true;
            this.btnObrisiIzdanje.Click += new System.EventHandler(this.btnObrisiIzdanje_Click);
            // 
            // dgvIzdanja
            // 
            this.dgvIzdanja.AllowUserToAddRows = false;
            this.dgvIzdanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdanja.Location = new System.Drawing.Point(39, 218);
            this.dgvIzdanja.Name = "dgvIzdanja";
            this.dgvIzdanja.ReadOnly = true;
            this.dgvIzdanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzdanja.Size = new System.Drawing.Size(345, 163);
            this.dgvIzdanja.TabIndex = 17;
            // 
            // UCAddKnjigaI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgvIzdanja);
            this.Controls.Add(this.btnObrisiIzdanje);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCAddKnjigaI";
            this.Size = new System.Drawing.Size(773, 425);
            this.Load += new System.EventHandler(this.UCAddKnjigaI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajIzdanje;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.TextBox txtGodStampe;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiIzdanje;
        private System.Windows.Forms.DataGridView dgvIzdanja;
    }
}
