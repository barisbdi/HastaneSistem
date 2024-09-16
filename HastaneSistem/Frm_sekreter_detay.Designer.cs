namespace HastaneSistem
{
    partial class Frm_sekreter_detay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rch_duyuru = new System.Windows.Forms.RichTextBox();
            this.btn_duyuruolustur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.chk_durum = new System.Windows.Forms.CheckBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.Branşlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_doktorpanel = new System.Windows.Forms.Button();
            this.btn_branspanel = new System.Windows.Forms.Button();
            this.btn_randevuliste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Branşlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(76, 33);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(79, 13);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "000000000000";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(76, 57);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(42, 13);
            this.lbl_adsoyad.TabIndex = 3;
            this.lbl_adsoyad.Text = "null null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_duyuruolustur);
            this.groupBox2.Controls.Add(this.rch_duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // rch_duyuru
            // 
            this.rch_duyuru.Location = new System.Drawing.Point(6, 19);
            this.rch_duyuru.Name = "rch_duyuru";
            this.rch_duyuru.Size = new System.Drawing.Size(188, 128);
            this.rch_duyuru.TabIndex = 0;
            this.rch_duyuru.Text = "";
            // 
            // btn_duyuruolustur
            // 
            this.btn_duyuruolustur.Location = new System.Drawing.Point(6, 153);
            this.btn_duyuruolustur.Name = "btn_duyuruolustur";
            this.btn_duyuruolustur.Size = new System.Drawing.Size(188, 23);
            this.btn_duyuruolustur.TabIndex = 1;
            this.btn_duyuruolustur.Text = "Oluştur";
            this.btn_duyuruolustur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_guncelle);
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.chk_durum);
            this.groupBox3.Controls.Add(this.msk_tc);
            this.groupBox3.Controls.Add(this.cmb_doktor);
            this.groupBox3.Controls.Add(this.cmb_brans);
            this.groupBox3.Controls.Add(this.msk_saat);
            this.groupBox3.Controls.Add(this.msk_tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 282);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Branş :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Doktor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "TC :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(55, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 11;
            // 
            // msk_tarih
            // 
            this.msk_tarih.Location = new System.Drawing.Point(55, 56);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(100, 20);
            this.msk_tarih.TabIndex = 12;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(55, 85);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(100, 20);
            this.msk_saat.TabIndex = 13;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(55, 112);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(100, 21);
            this.cmb_brans.TabIndex = 14;
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(55, 139);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(100, 21);
            this.cmb_doktor.TabIndex = 15;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(55, 166);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 20);
            this.msk_tc.TabIndex = 16;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // chk_durum
            // 
            this.chk_durum.AutoSize = true;
            this.chk_durum.Location = new System.Drawing.Point(57, 192);
            this.chk_durum.Name = "chk_durum";
            this.chk_durum.Size = new System.Drawing.Size(57, 17);
            this.chk_durum.TabIndex = 17;
            this.chk_durum.Text = "Durum";
            this.chk_durum.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(9, 215);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(146, 23);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(9, 244);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(146, 23);
            this.btn_guncelle.TabIndex = 18;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // Branşlar
            // 
            this.Branşlar.Controls.Add(this.dataGridView2);
            this.Branşlar.Controls.Add(this.dataGridView1);
            this.Branşlar.Location = new System.Drawing.Point(402, 8);
            this.Branşlar.Name = "Branşlar";
            this.Branşlar.Size = new System.Drawing.Size(394, 143);
            this.Branşlar.TabIndex = 3;
            this.Branşlar.TabStop = false;
            this.Branşlar.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(388, 124);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Controls.Add(this.dataGridView4);
            this.groupBox4.Location = new System.Drawing.Point(399, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 199);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(388, 180);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(388, 180);
            this.dataGridView4.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_randevuliste);
            this.groupBox5.Controls.Add(this.btn_branspanel);
            this.groupBox5.Controls.Add(this.btn_doktorpanel);
            this.groupBox5.Location = new System.Drawing.Point(12, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // btn_doktorpanel
            // 
            this.btn_doktorpanel.Location = new System.Drawing.Point(14, 19);
            this.btn_doktorpanel.Name = "btn_doktorpanel";
            this.btn_doktorpanel.Size = new System.Drawing.Size(112, 23);
            this.btn_doktorpanel.TabIndex = 3;
            this.btn_doktorpanel.Text = "Doktor Paneli";
            this.btn_doktorpanel.UseVisualStyleBackColor = true;
            // 
            // btn_branspanel
            // 
            this.btn_branspanel.Location = new System.Drawing.Point(132, 19);
            this.btn_branspanel.Name = "btn_branspanel";
            this.btn_branspanel.Size = new System.Drawing.Size(112, 23);
            this.btn_branspanel.TabIndex = 4;
            this.btn_branspanel.Text = "Branş Paneli";
            this.btn_branspanel.UseVisualStyleBackColor = true;
            // 
            // btn_randevuliste
            // 
            this.btn_randevuliste.Location = new System.Drawing.Point(250, 19);
            this.btn_randevuliste.Name = "btn_randevuliste";
            this.btn_randevuliste.Size = new System.Drawing.Size(112, 23);
            this.btn_randevuliste.TabIndex = 5;
            this.btn_randevuliste.Text = "Randevu Liste";
            this.btn_randevuliste.UseVisualStyleBackColor = true;
            // 
            // Frm_sekreter_detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Branşlar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_sekreter_detay";
            this.Text = "Sekreter Detay Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Branşlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_duyuruolustur;
        private System.Windows.Forms.RichTextBox rch_duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox chk_durum;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.GroupBox Branşlar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_randevuliste;
        private System.Windows.Forms.Button btn_branspanel;
        private System.Windows.Forms.Button btn_doktorpanel;
    }
}