namespace ANKA_OTOMASYON
{
    partial class satilik_arsa
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
            this.txt_arsa_ara = new System.Windows.Forms.TextBox();
            this.btn_stlk_arsa_ekle = new System.Windows.Forms.Button();
            this.btn_arsa_sil = new System.Windows.Forms.Button();
            this.btn_arsa_yenile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_arsa_yol = new System.Windows.Forms.TextBox();
            this.btn_arsa_fotogoster = new System.Windows.Forms.Button();
            this.datagrid_arsa = new System.Windows.Forms.DataGridView();
            this.txt_satilik_arsa_konum = new System.Windows.Forms.TextBox();
            this.btn_arsa_konum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_arsa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_satilik_ara);
            this.panel1.Controls.Add(this.txt_arsa_ara);
            this.panel1.Controls.Add(this.btn_stlk_arsa_ekle);
            this.panel1.Controls.Add(this.btn_arsa_sil);
            this.panel1.Controls.Add(this.btn_arsa_yenile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 63);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_satilik_ara
            // 
            this.lbl_satilik_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_satilik_ara.AutoSize = true;
            this.lbl_satilik_ara.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_satilik_ara.ForeColor = System.Drawing.Color.Teal;
            this.lbl_satilik_ara.Location = new System.Drawing.Point(874, 11);
            this.lbl_satilik_ara.Name = "lbl_satilik_ara";
            this.lbl_satilik_ara.Size = new System.Drawing.Size(106, 31);
            this.lbl_satilik_ara.TabIndex = 10;
            this.lbl_satilik_ara.Text = "ARAMA :";
            // 
            // txt_arsa_ara
            // 
            this.txt_arsa_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_arsa_ara.Location = new System.Drawing.Point(1001, 11);
            this.txt_arsa_ara.Multiline = true;
            this.txt_arsa_ara.Name = "txt_arsa_ara";
            this.txt_arsa_ara.Size = new System.Drawing.Size(374, 32);
            this.txt_arsa_ara.TabIndex = 9;
            this.txt_arsa_ara.Text = "(İle Göre..)";
            this.txt_arsa_ara.TextChanged += new System.EventHandler(this.txt_satilik_ara_TextChanged);
            this.txt_arsa_ara.MouseEnter += new System.EventHandler(this.txt_arsa_ara_MouseEnter);
            // 
            // btn_stlk_arsa_ekle
            // 
            this.btn_stlk_arsa_ekle.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stlk_arsa_ekle.ForeColor = System.Drawing.Color.YellowGreen;
            this.btn_stlk_arsa_ekle.Location = new System.Drawing.Point(7, 12);
            this.btn_stlk_arsa_ekle.Name = "btn_stlk_arsa_ekle";
            this.btn_stlk_arsa_ekle.Size = new System.Drawing.Size(117, 35);
            this.btn_stlk_arsa_ekle.TabIndex = 3;
            this.btn_stlk_arsa_ekle.Text = "EKLE";
            this.btn_stlk_arsa_ekle.UseVisualStyleBackColor = true;
            this.btn_stlk_arsa_ekle.Click += new System.EventHandler(this.btn_stlk_arsa_ekle_Click);
            // 
            // btn_arsa_sil
            // 
            this.btn_arsa_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arsa_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_arsa_sil.Location = new System.Drawing.Point(302, 12);
            this.btn_arsa_sil.Name = "btn_arsa_sil";
            this.btn_arsa_sil.Size = new System.Drawing.Size(117, 35);
            this.btn_arsa_sil.TabIndex = 6;
            this.btn_arsa_sil.Text = "SİL !";
            this.btn_arsa_sil.UseVisualStyleBackColor = true;
            this.btn_arsa_sil.Click += new System.EventHandler(this.btn_arsa_sil_Click);
            // 
            // btn_arsa_yenile
            // 
            this.btn_arsa_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arsa_yenile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_arsa_yenile.Location = new System.Drawing.Point(157, 12);
            this.btn_arsa_yenile.Name = "btn_arsa_yenile";
            this.btn_arsa_yenile.Size = new System.Drawing.Size(117, 35);
            this.btn_arsa_yenile.TabIndex = 4;
            this.btn_arsa_yenile.Text = "YENİLE!";
            this.btn_arsa_yenile.UseVisualStyleBackColor = true;
            this.btn_arsa_yenile.Click += new System.EventHandler(this.btn_arsa_yenile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_satilik_arsa_konum);
            this.panel2.Controls.Add(this.btn_arsa_konum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_arsa_yol);
            this.panel2.Controls.Add(this.btn_arsa_fotogoster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 47);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arsanın Fotoğraf Klasörü :";
            // 
            // txt_arsa_yol
            // 
            this.txt_arsa_yol.Enabled = false;
            this.txt_arsa_yol.Location = new System.Drawing.Point(250, 6);
            this.txt_arsa_yol.Multiline = true;
            this.txt_arsa_yol.Name = "txt_arsa_yol";
            this.txt_arsa_yol.Size = new System.Drawing.Size(396, 31);
            this.txt_arsa_yol.TabIndex = 1;
            // 
            // btn_arsa_fotogoster
            // 
            this.btn_arsa_fotogoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arsa_fotogoster.ForeColor = System.Drawing.Color.Purple;
            this.btn_arsa_fotogoster.Location = new System.Drawing.Point(666, 6);
            this.btn_arsa_fotogoster.Name = "btn_arsa_fotogoster";
            this.btn_arsa_fotogoster.Size = new System.Drawing.Size(146, 31);
            this.btn_arsa_fotogoster.TabIndex = 0;
            this.btn_arsa_fotogoster.Text = "FOTO GÖSTER !";
            this.btn_arsa_fotogoster.UseVisualStyleBackColor = true;
            this.btn_arsa_fotogoster.Click += new System.EventHandler(this.btn_arsa_fotogoster_Click);
            // 
            // datagrid_arsa
            // 
            this.datagrid_arsa.AllowUserToAddRows = false;
            this.datagrid_arsa.AllowUserToDeleteRows = false;
            this.datagrid_arsa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_arsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_arsa.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_arsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_arsa.Location = new System.Drawing.Point(0, 63);
            this.datagrid_arsa.Name = "datagrid_arsa";
            this.datagrid_arsa.ReadOnly = true;
            this.datagrid_arsa.RowHeadersWidth = 51;
            this.datagrid_arsa.RowTemplate.Height = 24;
            this.datagrid_arsa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_arsa.Size = new System.Drawing.Size(1389, 536);
            this.datagrid_arsa.TabIndex = 4;
            this.datagrid_arsa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_arsa_CellClick);
            // 
            // txt_satilik_arsa_konum
            // 
            this.txt_satilik_arsa_konum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_satilik_arsa_konum.Enabled = false;
            this.txt_satilik_arsa_konum.Location = new System.Drawing.Point(827, 6);
            this.txt_satilik_arsa_konum.Multiline = true;
            this.txt_satilik_arsa_konum.Name = "txt_satilik_arsa_konum";
            this.txt_satilik_arsa_konum.Size = new System.Drawing.Size(396, 31);
            this.txt_satilik_arsa_konum.TabIndex = 5;
            // 
            // btn_arsa_konum
            // 
            this.btn_arsa_konum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_arsa_konum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arsa_konum.ForeColor = System.Drawing.Color.Red;
            this.btn_arsa_konum.Location = new System.Drawing.Point(1243, 6);
            this.btn_arsa_konum.Name = "btn_arsa_konum";
            this.btn_arsa_konum.Size = new System.Drawing.Size(146, 31);
            this.btn_arsa_konum.TabIndex = 4;
            this.btn_arsa_konum.Text = "KONUM GÖSTER !";
            this.btn_arsa_konum.UseVisualStyleBackColor = true;
            this.btn_arsa_konum.Click += new System.EventHandler(this.btn_arsa_konum_Click);
            // 
            // satilik_arsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagrid_arsa);
            this.Name = "satilik_arsa";
            this.ShowIcon = false;
            this.Text = "SATILIK ARSA";
            this.Load += new System.EventHandler(this.satilik_arsa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_arsa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_satilik_ara;
        private System.Windows.Forms.TextBox txt_arsa_ara;
        private System.Windows.Forms.Button btn_stlk_arsa_ekle;
        private System.Windows.Forms.Button btn_arsa_sil;
        private System.Windows.Forms.Button btn_arsa_yenile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_arsa_yol;
        private System.Windows.Forms.Button btn_arsa_fotogoster;
        public System.Windows.Forms.DataGridView datagrid_arsa;
        private System.Windows.Forms.TextBox txt_satilik_arsa_konum;
        private System.Windows.Forms.Button btn_arsa_konum;
    }
}