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
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznajmljivanje knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum iznajmljivanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok za razduzivanje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clan";
            // 
            // txtDatIznajmljivanja
            // 
            this.txtDatIznajmljivanja.Location = new System.Drawing.Point(208, 97);
            this.txtDatIznajmljivanja.Name = "txtDatIznajmljivanja";
            this.txtDatIznajmljivanja.Size = new System.Drawing.Size(206, 20);
            this.txtDatIznajmljivanja.TabIndex = 4;
            // 
            // txtRokRazduzivanja
            // 
            this.txtRokRazduzivanja.Location = new System.Drawing.Point(208, 134);
            this.txtRokRazduzivanja.Name = "txtRokRazduzivanja";
            this.txtRokRazduzivanja.Size = new System.Drawing.Size(206, 20);
            this.txtRokRazduzivanja.TabIndex = 5;
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(208, 172);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(206, 21);
            this.cbClan.TabIndex = 6;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(110, 224);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(107, 23);
            this.btnDodajStavku.TabIndex = 7;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(278, 224);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(107, 23);
            this.btnObrisiStavku.TabIndex = 8;
            this.btnObrisiStavku.Text = "Obrisi stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 98);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(173, 397);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(164, 23);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sacuvaj iznajmljivanje";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // UCAddRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.txtRokRazduzivanja);
            this.Controls.Add(this.txtDatIznajmljivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddRent";
            this.Size = new System.Drawing.Size(523, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
