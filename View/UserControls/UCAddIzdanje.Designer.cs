﻿namespace View.UserControls
{
    partial class UCAddIzdanje
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
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtGodStampe = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKnjige = new System.Windows.Forms.ComboBox();
            this.cbAutori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIzdavac.Location = new System.Drawing.Point(300, 261);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(265, 20);
            this.txtIzdavac.TabIndex = 23;
            // 
            // txtGodStampe
            // 
            this.txtGodStampe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGodStampe.Location = new System.Drawing.Point(300, 219);
            this.txtGodStampe.Name = "txtGodStampe";
            this.txtGodStampe.Size = new System.Drawing.Size(265, 20);
            this.txtGodStampe.TabIndex = 22;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(312, 329);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(146, 23);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Izdavac";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Godina izdanja";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Knjiga";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dodaj izdanje knjige";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Autor";
            // 
            // cbKnjige
            // 
            this.cbKnjige.FormattingEnabled = true;
            this.cbKnjige.Location = new System.Drawing.Point(300, 140);
            this.cbKnjige.Name = "cbKnjige";
            this.cbKnjige.Size = new System.Drawing.Size(265, 21);
            this.cbKnjige.TabIndex = 25;
            // 
            // cbAutori
            // 
            this.cbAutori.FormattingEnabled = true;
            this.cbAutori.Location = new System.Drawing.Point(300, 178);
            this.cbAutori.Name = "cbAutori";
            this.cbAutori.Size = new System.Drawing.Size(265, 21);
            this.cbAutori.TabIndex = 26;
            // 
            // UCAddIzdanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbAutori);
            this.Controls.Add(this.cbKnjige);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtGodStampe);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddIzdanje";
            this.Size = new System.Drawing.Size(761, 409);
            this.Load += new System.EventHandler(this.UCAddIzdanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtGodStampe;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKnjige;
        private System.Windows.Forms.ComboBox cbAutori;
    }
}