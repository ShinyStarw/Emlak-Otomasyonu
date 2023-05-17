namespace ANKA_OTOMASYON
{
    partial class müsteri_ekle
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
            this.txt_müsteri_adsoyad = new System.Windows.Forms.TextBox();
            this.cmb_tür = new System.Windows.Forms.ComboBox();
            this.cmb_istenen = new System.Windows.Forms.ComboBox();
            this.txt_müsteri_bütce = new System.Windows.Forms.TextBox();
            this.txt_müsteri_aciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_müsteri_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_müsteri_adsoyad
            // 
            this.txt_müsteri_adsoyad.Location = new System.Drawing.Point(157, 22);
            this.txt_müsteri_adsoyad.Multiline = true;
            this.txt_müsteri_adsoyad.Name = "txt_müsteri_adsoyad";
            this.txt_müsteri_adsoyad.Size = new System.Drawing.Size(229, 22);
            this.txt_müsteri_adsoyad.TabIndex = 0;
            // 
            // cmb_tür
            // 
            this.cmb_tür.FormattingEnabled = true;
            this.cmb_tür.Items.AddRange(new object[] {
            "SATILIK",
            "KİRALIK"});
            this.cmb_tür.Location = new System.Drawing.Point(157, 73);
            this.cmb_tür.Name = "cmb_tür";
            this.cmb_tür.Size = new System.Drawing.Size(155, 24);
            this.cmb_tür.TabIndex = 1;
            // 
            // cmb_istenen
            // 
            this.cmb_istenen.FormattingEnabled = true;
            this.cmb_istenen.Items.AddRange(new object[] {
            "DAİRE",
            "ARSA",
            "ARAÇ"});
            this.cmb_istenen.Location = new System.Drawing.Point(157, 127);
            this.cmb_istenen.Name = "cmb_istenen";
            this.cmb_istenen.Size = new System.Drawing.Size(155, 24);
            this.cmb_istenen.TabIndex = 2;
            // 
            // txt_müsteri_bütce
            // 
            this.txt_müsteri_bütce.Location = new System.Drawing.Point(157, 180);
            this.txt_müsteri_bütce.Multiline = true;
            this.txt_müsteri_bütce.Name = "txt_müsteri_bütce";
            this.txt_müsteri_bütce.Size = new System.Drawing.Size(164, 22);
            this.txt_müsteri_bütce.TabIndex = 3;
            // 
            // txt_müsteri_aciklama
            // 
            this.txt_müsteri_aciklama.Location = new System.Drawing.Point(157, 244);
            this.txt_müsteri_aciklama.Multiline = true;
            this.txt_müsteri_aciklama.Name = "txt_müsteri_aciklama";
            this.txt_müsteri_aciklama.Size = new System.Drawing.Size(229, 58);
            this.txt_müsteri_aciklama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD-SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "SATILIK/KİRALIK :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "İSTENEN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "BÜTÇE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "AÇIKLAMA :";
            // 
            // btn_müsteri_kaydet
            // 
            this.btn_müsteri_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_müsteri_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_müsteri_kaydet.Location = new System.Drawing.Point(137, 339);
            this.btn_müsteri_kaydet.Name = "btn_müsteri_kaydet";
            this.btn_müsteri_kaydet.Size = new System.Drawing.Size(102, 43);
            this.btn_müsteri_kaydet.TabIndex = 10;
            this.btn_müsteri_kaydet.Text = "KAYDET !";
            this.btn_müsteri_kaydet.UseVisualStyleBackColor = false;
            this.btn_müsteri_kaydet.Click += new System.EventHandler(this.btn_müsteri_kaydet_Click);
            // 
            // müsteri_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 409);
            this.Controls.Add(this.btn_müsteri_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_müsteri_aciklama);
            this.Controls.Add(this.txt_müsteri_bütce);
            this.Controls.Add(this.cmb_istenen);
            this.Controls.Add(this.cmb_tür);
            this.Controls.Add(this.txt_müsteri_adsoyad);
            this.Name = "müsteri_ekle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜSTERİ EKLEME EKRANI";
            this.Load += new System.EventHandler(this.müsteri_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_müsteri_adsoyad;
        private System.Windows.Forms.ComboBox cmb_tür;
        private System.Windows.Forms.ComboBox cmb_istenen;
        private System.Windows.Forms.TextBox txt_müsteri_bütce;
        private System.Windows.Forms.TextBox txt_müsteri_aciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_müsteri_kaydet;
    }
}