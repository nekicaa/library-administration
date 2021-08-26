namespace View.UserControls
{
    partial class UCSearchRent
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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.txtRokRazduzivanja = new System.Windows.Forms.TextBox();
            this.txtDatIznajmljivanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(238, 73);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(97, 23);
            this.btnPretrazi.TabIndex = 0;
            this.btnPretrazi.Text = "Pretrazi ";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(50, 75);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // dgvIznajmljivanja
            // 
            this.dgvIznajmljivanja.AllowUserToAddRows = false;
            this.dgvIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIznajmljivanja.Location = new System.Drawing.Point(50, 136);
            this.dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            this.dgvIznajmljivanja.Size = new System.Drawing.Size(285, 209);
            this.dgvIznajmljivanja.TabIndex = 2;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(45, 191);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.Size = new System.Drawing.Size(285, 151);
            this.dgvStavke.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClan);
            this.groupBox1.Controls.Add(this.txtRokRazduzivanja);
            this.groupBox1.Controls.Add(this.txtDatIznajmljivanja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Location = new System.Drawing.Point(374, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 418);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iznajmljivanje";
            // 
            // txtClan
            // 
            this.txtClan.Location = new System.Drawing.Point(169, 142);
            this.txtClan.Name = "txtClan";
            this.txtClan.ReadOnly = true;
            this.txtClan.Size = new System.Drawing.Size(161, 20);
            this.txtClan.TabIndex = 12;
            // 
            // txtRokRazduzivanja
            // 
            this.txtRokRazduzivanja.Location = new System.Drawing.Point(169, 104);
            this.txtRokRazduzivanja.Name = "txtRokRazduzivanja";
            this.txtRokRazduzivanja.ReadOnly = true;
            this.txtRokRazduzivanja.Size = new System.Drawing.Size(161, 20);
            this.txtRokRazduzivanja.TabIndex = 11;
            // 
            // txtDatIznajmljivanja
            // 
            this.txtDatIznajmljivanja.Location = new System.Drawing.Point(169, 67);
            this.txtDatIznajmljivanja.Name = "txtDatIznajmljivanja";
            this.txtDatIznajmljivanja.ReadOnly = true;
            this.txtDatIznajmljivanja.Size = new System.Drawing.Size(161, 20);
            this.txtDatIznajmljivanja.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rok za razduzivanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum iznajmljivanja";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(238, 371);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(97, 23);
            this.btnOdaberi.TabIndex = 5;
            this.btnOdaberi.Text = "Prikazi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // UCSearchRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIznajmljivanja);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPretrazi);
            this.Name = "UCSearchRent";
            this.Size = new System.Drawing.Size(750, 424);
            this.Load += new System.EventHandler(this.UCSearchRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvIznajmljivanja;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.TextBox txtRokRazduzivanja;
        private System.Windows.Forms.TextBox txtDatIznajmljivanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
