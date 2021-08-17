namespace View.UserControls
{
    partial class UCAddBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtGodStampe = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj novu knjigu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAutor);
            this.groupBox1.Controls.Add(this.txtGodStampe);
            this.groupBox1.Controls.Add(this.txtIzdavac);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(0, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izdanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zanr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Godina stampe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Izdavac";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(196, 155);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(91, 23);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(160, 95);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(160, 146);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(265, 20);
            this.txtISBN.TabIndex = 6;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(160, 188);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(265, 20);
            this.txtZanr.TabIndex = 7;
            // 
            // txtGodStampe
            // 
            this.txtGodStampe.Location = new System.Drawing.Point(160, 75);
            this.txtGodStampe.Name = "txtGodStampe";
            this.txtGodStampe.Size = new System.Drawing.Size(265, 20);
            this.txtGodStampe.TabIndex = 8;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(160, 115);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(265, 20);
            this.txtIzdavac.TabIndex = 9;
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(160, 32);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(265, 21);
            this.cbAutor.TabIndex = 10;
            // 
            // UCAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCAddBook";
            this.Size = new System.Drawing.Size(495, 431);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.TextBox txtGodStampe;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtZanr;
    }
}
