namespace HastaneSistem
{
    partial class Frm_doktor_bilgi_duzenle
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
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(94, 116);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Şifre :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(94, 38);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Soyad :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(94, 12);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 33;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(94, 64);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 20);
            this.msk_tc.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "TC Kimlik No :";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(94, 90);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(100, 21);
            this.cmb_brans.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Branş :";
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(94, 142);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(100, 23);
            this.btn_bilgiguncelle.TabIndex = 41;
            this.btn_bilgiguncelle.Text = "Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = false;
            // 
            // Frm_doktor_bilgi_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(223, 196);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Frm_doktor_bilgi_duzenle";
            this.Text = "Frm_doktor_bilgi_duzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_bilgiguncelle;
    }
}