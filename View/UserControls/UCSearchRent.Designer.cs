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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPretrazi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(217, 65);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(97, 23);
            this.btnPretrazi.TabIndex = 0;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(29, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 22);
            this.txtFilter.TabIndex = 1;
            // 
            // dgvIznajmljivanja
            // 
            this.dgvIznajmljivanja.AllowUserToAddRows = false;
            this.dgvIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIznajmljivanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIznajmljivanja.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIznajmljivanja.GridColor = System.Drawing.SystemColors.Control;
            this.dgvIznajmljivanja.Location = new System.Drawing.Point(29, 128);
            this.dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            this.dgvIznajmljivanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIznajmljivanja.Size = new System.Drawing.Size(285, 209);
            this.dgvIznajmljivanja.TabIndex = 2;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStavke.Location = new System.Drawing.Point(45, 191);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(285, 151);
            this.dgvStavke.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClan);
            this.groupBox1.Controls.Add(this.txtRokRazduzivanja);
            this.groupBox1.Controls.Add(this.txtDatIznajmljivanja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(353, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 418);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iznajmljivanje";
            // 
            // txtClan
            // 
            this.txtClan.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClan.Location = new System.Drawing.Point(169, 142);
            this.txtClan.Name = "txtClan";
            this.txtClan.ReadOnly = true;
            this.txtClan.Size = new System.Drawing.Size(161, 22);
            this.txtClan.TabIndex = 12;
            // 
            // txtRokRazduzivanja
            // 
            this.txtRokRazduzivanja.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRokRazduzivanja.Location = new System.Drawing.Point(169, 104);
            this.txtRokRazduzivanja.Name = "txtRokRazduzivanja";
            this.txtRokRazduzivanja.ReadOnly = true;
            this.txtRokRazduzivanja.Size = new System.Drawing.Size(161, 22);
            this.txtRokRazduzivanja.TabIndex = 11;
            // 
            // txtDatIznajmljivanja
            // 
            this.txtDatIznajmljivanja.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatIznajmljivanja.Location = new System.Drawing.Point(169, 67);
            this.txtDatIznajmljivanja.Name = "txtDatIznajmljivanja";
            this.txtDatIznajmljivanja.ReadOnly = true;
            this.txtDatIznajmljivanja.Size = new System.Drawing.Size(161, 22);
            this.txtDatIznajmljivanja.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Član";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rok za razduživanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum iznajmljivanja";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOdaberi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.Location = new System.Drawing.Point(217, 363);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(97, 23);
            this.btnOdaberi.TabIndex = 5;
            this.btnOdaberi.Text = "Prikaži";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pretraži po članu:";
            // 
            // UCSearchRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIznajmljivanja);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPretrazi);
            this.Name = "UCSearchRent";
            this.Size = new System.Drawing.Size(709, 408);
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
        private System.Windows.Forms.Label label5;
    }
}
