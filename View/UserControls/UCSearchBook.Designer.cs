namespace View.UserControls
{
    partial class UCSearchBook
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(12, 62);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 22);
            this.txtFilter.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPretrazi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(196, 60);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži knjige";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AllowUserToAddRows = false;
            this.dgvKnjige.AllowUserToDeleteRows = false;
            this.dgvKnjige.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKnjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKnjige.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.GridColor = System.Drawing.SystemColors.Control;
            this.dgvKnjige.Location = new System.Drawing.Point(12, 112);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(294, 195);
            this.dgvKnjige.TabIndex = 2;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOdaberi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.Location = new System.Drawing.Point(196, 341);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(110, 23);
            this.btnOdaberi.TabIndex = 3;
            this.btnOdaberi.Text = "Prikaži knjigu";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtZanr);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNaslov);
            this.groupBox1.Location = new System.Drawing.Point(347, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 416);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtZanr
            // 
            this.txtZanr.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZanr.Location = new System.Drawing.Point(149, 233);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.ReadOnly = true;
            this.txtZanr.Size = new System.Drawing.Size(191, 22);
            this.txtZanr.TabIndex = 13;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(149, 191);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(191, 22);
            this.txtISBN.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(149, 149);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(191, 22);
            this.txtNaziv.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Žanr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(80, 70);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(85, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Knjiga ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pretraži po nazivu ili žanru:";
            // 
            // UCSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvKnjige);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtFilter);
            this.Name = "UCSearchBook";
            this.Size = new System.Drawing.Size(729, 400);
            this.Load += new System.EventHandler(this.UCSearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}
