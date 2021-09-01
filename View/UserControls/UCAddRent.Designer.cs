namespace View.UserControls
{
    partial class UCAddRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatIznajmljivanja = new System.Windows.Forms.TextBox();
            this.txtRokRazduzivanja = new System.Windows.Forms.TextBox();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavke = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKnjiga = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznajmljivanje knjige";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum iznajmljivanja";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok za razduživanje";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Član";
            // 
            // txtDatIznajmljivanja
            // 
            this.txtDatIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatIznajmljivanja.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatIznajmljivanja.Location = new System.Drawing.Point(186, 87);
            this.txtDatIznajmljivanja.Name = "txtDatIznajmljivanja";
            this.txtDatIznajmljivanja.ReadOnly = true;
            this.txtDatIznajmljivanja.Size = new System.Drawing.Size(187, 22);
            this.txtDatIznajmljivanja.TabIndex = 4;
            // 
            // txtRokRazduzivanja
            // 
            this.txtRokRazduzivanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRokRazduzivanja.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRokRazduzivanja.Location = new System.Drawing.Point(186, 124);
            this.txtRokRazduzivanja.Name = "txtRokRazduzivanja";
            this.txtRokRazduzivanja.ReadOnly = true;
            this.txtRokRazduzivanja.Size = new System.Drawing.Size(187, 22);
            this.txtRokRazduzivanja.TabIndex = 5;
            // 
            // cbClan
            // 
            this.cbClan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClan.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(186, 162);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(187, 22);
            this.cbClan.TabIndex = 6;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDodajStavku.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(109, 115);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(115, 23);
            this.btnDodajStavku.TabIndex = 7;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnObrisiStavke
            // 
            this.btnObrisiStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiStavke.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnObrisiStavke.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStavke.Location = new System.Drawing.Point(511, 260);
            this.btnObrisiStavke.Name = "btnObrisiStavke";
            this.btnObrisiStavke.Size = new System.Drawing.Size(115, 23);
            this.btnObrisiStavke.TabIndex = 8;
            this.btnObrisiStavke.Text = "Obriši odabrane";
            this.btnObrisiStavke.UseVisualStyleBackColor = false;
            this.btnObrisiStavke.Click += new System.EventHandler(this.btnObrisiStavke_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStavke.Location = new System.Drawing.Point(38, 243);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(401, 122);
            this.dgvStavke.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSacuvaj.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(511, 327);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(164, 23);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj iznajmljivanje";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbKnjiga);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj stavke";
            // 
            // cbKnjiga
            // 
            this.cbKnjiga.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKnjiga.FormattingEnabled = true;
            this.cbKnjiga.Location = new System.Drawing.Point(109, 31);
            this.cbKnjiga.Name = "cbKnjiga";
            this.cbKnjiga.Size = new System.Drawing.Size(200, 22);
            this.cbKnjiga.TabIndex = 11;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(109, 73);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(200, 22);
            this.txtKolicina.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Knjiga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Količina";
            // 
            // UCAddRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnObrisiStavke);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.txtRokRazduzivanja);
            this.Controls.Add(this.txtDatIznajmljivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddRent";
            this.Size = new System.Drawing.Size(727, 423);
            this.Load += new System.EventHandler(this.UCAddRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatIznajmljivanja;
        private System.Windows.Forms.TextBox txtRokRazduzivanja;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnObrisiStavke;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKnjiga;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
