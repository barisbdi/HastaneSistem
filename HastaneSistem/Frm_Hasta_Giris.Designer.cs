namespace HastaneSistem
{
    partial class Frm_Hasta_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lnk_uyeol = new System.Windows.Forms.LinkLabel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(101, 36);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 20);
            this.msk_tc.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(101, 65);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 4;
            // 
            // lnk_uyeol
            // 
            this.lnk_uyeol.AutoSize = true;
            this.lnk_uyeol.Location = new System.Drawing.Point(81, 96);
            this.lnk_uyeol.Name = "lnk_uyeol";
            this.lnk_uyeol.Size = new System.Drawing.Size(39, 13);
            this.lnk_uyeol.TabIndex = 5;
            this.lnk_uyeol.TabStop = true;
            this.lnk_uyeol.Text = "Üye Ol";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(126, 91);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            // 
            // Frm_Hasta_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(224, 130);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lnk_uyeol);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Hasta_Giris";
            this.Text = "Hasta Giris Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.LinkLabel lnk_uyeol;
        private System.Windows.Forms.Button btn_giris;
    }
}