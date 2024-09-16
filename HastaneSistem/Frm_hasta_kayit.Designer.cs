namespace HastaneSistem
{
    partial class Frm_hasta_kayit
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
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(84, 12);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 8;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(84, 64);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 20);
            this.msk_tc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(84, 38);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon No :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(84, 116);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre :";
            // 
            // msk_telefon
            // 
            this.msk_telefon.Location = new System.Drawing.Point(84, 90);
            this.msk_telefon.Mask = "(999) 000-0000";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(100, 20);
            this.msk_telefon.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet :";
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(84, 142);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmb_cinsiyet.TabIndex = 18;
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_kayit.Location = new System.Drawing.Point(84, 169);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(100, 23);
            this.btn_kayit.TabIndex = 19;
            this.btn_kayit.Text = "Kayıt Yap";
            this.btn_kayit.UseVisualStyleBackColor = false;
            // 
            // Frm_hasta_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(253, 225);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_telefon);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Frm_hasta_kayit";
            this.Text = "Hasta Kayıt Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Button btn_kayit;
    }
}