namespace ANKA_OTOMASYON.kiralık
{
    partial class kiralik_arac
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_satilik_ara = new System.Windows.Forms.Label();
            this.txt_kiralik_arac_ara = new System.Windows.Forms.TextBox();
            this.btn_kiralik_arac_ekle = new System.Windows.Forms.Button();
            this.btn_kiralik_arac_sil = new System.Windows.Forms.Button();
            this.btn_kiralik_arac_yenile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kiralik_arac_yol = new System.Windows.Forms.TextBox();
            this.btn_fotogoster = new System.Windows.Forms.Button();
            this.datagrid_kiralik_arac = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_kiralik_arac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_satilik_ara);
            this.panel1.Controls.Add(this.txt_kiralik_arac_ara);
            this.panel1.Controls.Add(this.btn_kiralik_arac_ekle);
            this.panel1.Controls.Add(this.btn_kiralik_arac_sil);
            this.panel1.Controls.Add(this.btn_kiralik_arac_yenile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 63);
            this.panel1.TabIndex = 6;
            // 
            // lbl_satilik_ara
            // 
            this.lbl_satilik_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_satilik_ara.AutoSize = true;
            this.lbl_satilik_ara.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_satilik_ara.ForeColor = System.Drawing.Color.Teal;
            this.lbl_satilik_ara.Location = new System.Drawing.Point(912, 11);
            this.lbl_satilik_ara.Name = "lbl_satilik_ara";
            this.lbl_satilik_ara.Size = new System.Drawing.Size(106, 31);
            this.lbl_satilik_ara.TabIndex = 10;
            this.lbl_satilik_ara.Text = "ARAMA :";
            // 
            // txt_kiralik_arac_ara
            // 
            this.txt_kiralik_arac_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kiralik_arac_ara.Location = new System.Drawing.Point(1039, 11);
            this.txt_kiralik_arac_ara.Multiline = true;
            this.txt_kiralik_arac_ara.Name = "txt_kiralik_arac_ara";
            this.txt_kiralik_arac_ara.Size = new System.Drawing.Size(374, 32);
            this.txt_kiralik_arac_ara.TabIndex = 9;
            this.txt_kiralik_arac_ara.Text = "(Modele Göre..)";
            this.txt_kiralik_arac_ara.TextChanged += new System.EventHandler(this.txt_kiralik_arac_ara_TextChanged);
            // 
            // btn_kiralik_arac_ekle
            // 
            this.btn_kiralik_arac_ekle.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiralik_arac_ekle.ForeColor = System.Drawing.Color.YellowGreen;
            this.btn_kiralik_arac_ekle.Location = new System.Drawing.Point(7, 12);
            this.btn_kiralik_arac_ekle.Name = "btn_kiralik_arac_ekle";
            this.btn_kiralik_arac_ekle.Size = new System.Drawing.Size(117, 35);
            this.btn_kiralik_arac_ekle.TabIndex = 3;
            this.btn_kiralik_arac_ekle.Text = "EKLE";
            this.btn_kiralik_arac_ekle.UseVisualStyleBackColor = true;
            this.btn_kiralik_arac_ekle.Click += new System.EventHandler(this.btn_kiralik_arac_ekle_Click);
            // 
            // btn_kiralik_arac_sil
            // 
            this.btn_kiralik_arac_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kiralik_arac_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_kiralik_arac_sil.Location = new System.Drawing.Point(302, 12);
            this.btn_kiralik_arac_sil.Name = "btn_kiralik_arac_sil";
            this.btn_kiralik_arac_sil.Size = new System.Drawing.Size(117, 35);
            this.btn_kiralik_arac_sil.TabIndex = 6;
            this.btn_kiralik_arac_sil.Text = "SİL !";
            this.btn_kiralik_arac_sil.UseVisualStyleBackColor = true;
            this.btn_kiralik_arac_sil.Click += new System.EventHandler(this.btn_kiralik_arac_sil_Click);
            // 
            // btn_kiralik_arac_yenile
            // 
            this.btn_kiralik_arac_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kiralik_arac_yenile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_kiralik_arac_yenile.Location = new System.Drawing.Point(157, 12);
            this.btn_kiralik_arac_yenile.Name = "btn_kiralik_arac_yenile";
            this.btn_kiralik_arac_yenile.Size = new System.Drawing.Size(117, 35);
            this.btn_kiralik_arac_yenile.TabIndex = 4;
            this.btn_kiralik_arac_yenile.Text = "YENİLE!";
            this.btn_kiralik_arac_yenile.UseVisualStyleBackColor = true;
            this.btn_kiralik_arac_yenile.Click += new System.EventHandler(this.btn_kiralik_arac_yenile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_kiralik_arac_yol);
            this.panel2.Controls.Add(this.btn_fotogoster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 47);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aracın Fotoğraf Klasörü :";
            // 
            // txt_kiralik_arac_yol
            // 
            this.txt_kiralik_arac_yol.Enabled = false;
            this.txt_kiralik_arac_yol.Location = new System.Drawing.Point(251, 13);
            this.txt_kiralik_arac_yol.Multiline = true;
            this.txt_kiralik_arac_yol.Name = "txt_kiralik_arac_yol";
            this.txt_kiralik_arac_yol.Size = new System.Drawing.Size(834, 31);
            this.txt_kiralik_arac_yol.TabIndex = 1;
            // 
            // btn_fotogoster
            // 
            this.btn_fotogoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fotogoster.ForeColor = System.Drawing.Color.Purple;
            this.btn_fotogoster.Location = new System.Drawing.Point(1091, 13);
            this.btn_fotogoster.Name = "btn_fotogoster";
            this.btn_fotogoster.Size = new System.Drawing.Size(146, 31);
            this.btn_fotogoster.TabIndex = 0;
            this.btn_fotogoster.Text = "FOTO GÖSTER !";
            this.btn_fotogoster.UseVisualStyleBackColor = true;
            this.btn_fotogoster.Click += new System.EventHandler(this.btn_fotogoster_Click);
            // 
            // datagrid_kiralik_arac
            // 
            this.datagrid_kiralik_arac.AllowUserToAddRows = false;
            this.datagrid_kiralik_arac.AllowUserToDeleteRows = false;
            this.datagrid_kiralik_arac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_kiralik_arac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_kiralik_arac.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_kiralik_arac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_kiralik_arac.Location = new System.Drawing.Point(0, 63);
            this.datagrid_kiralik_arac.Name = "datagrid_kiralik_arac";
            this.datagrid_kiralik_arac.ReadOnly = true;
            this.datagrid_kiralik_arac.RowHeadersWidth = 51;
            this.datagrid_kiralik_arac.RowTemplate.Height = 24;
            this.datagrid_kiralik_arac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_kiralik_arac.Size = new System.Drawing.Size(1427, 524);
            this.datagrid_kiralik_arac.TabIndex = 7;
            this.datagrid_kiralik_arac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_kiralik_arac_CellClick);
            // 
            // kiralik_arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagrid_kiralik_arac);
            this.Name = "kiralik_arac";
            this.Text = "kiralik_arac";
            this.Load += new System.EventHandler(this.kiralik_arac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_kiralik_arac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_satilik_ara;
        private System.Windows.Forms.TextBox txt_kiralik_arac_ara;
        private System.Windows.Forms.Button btn_kiralik_arac_ekle;
        private System.Windows.Forms.Button btn_kiralik_arac_sil;
        private System.Windows.Forms.Button btn_kiralik_arac_yenile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kiralik_arac_yol;
        private System.Windows.Forms.Button btn_fotogoster;
        public System.Windows.Forms.DataGridView datagrid_kiralik_arac;
    }
}