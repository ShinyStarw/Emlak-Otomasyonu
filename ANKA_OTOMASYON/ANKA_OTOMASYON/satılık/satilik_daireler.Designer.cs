namespace ANKA_OTOMASYON
{
    partial class satilik_daireler
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
            this.txt_satilik_ara = new System.Windows.Forms.TextBox();
            this.btn_stlk_daire_ekle = new System.Windows.Forms.Button();
            this.btn_satilik_sil = new System.Windows.Forms.Button();
            this.btn_satilik_yenile = new System.Windows.Forms.Button();
            this.datagrid_satilik_daireler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_konum = new System.Windows.Forms.TextBox();
            this.btn_konum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_satilik_yol = new System.Windows.Forms.TextBox();
            this.btn_fotogoster = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_satilik_daireler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_satilik_ara);
            this.panel1.Controls.Add(this.txt_satilik_ara);
            this.panel1.Controls.Add(this.btn_stlk_daire_ekle);
            this.panel1.Controls.Add(this.btn_satilik_sil);
            this.panel1.Controls.Add(this.btn_satilik_yenile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_satilik_ara
            // 
            this.lbl_satilik_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_satilik_ara.AutoSize = true;
            this.lbl_satilik_ara.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_satilik_ara.ForeColor = System.Drawing.Color.Teal;
            this.lbl_satilik_ara.Location = new System.Drawing.Point(938, 11);
            this.lbl_satilik_ara.Name = "lbl_satilik_ara";
            this.lbl_satilik_ara.Size = new System.Drawing.Size(106, 31);
            this.lbl_satilik_ara.TabIndex = 10;
            this.lbl_satilik_ara.Text = "ARAMA :";
            // 
            // txt_satilik_ara
            // 
            this.txt_satilik_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_satilik_ara.Location = new System.Drawing.Point(1065, 11);
            this.txt_satilik_ara.Multiline = true;
            this.txt_satilik_ara.Name = "txt_satilik_ara";
            this.txt_satilik_ara.Size = new System.Drawing.Size(374, 32);
            this.txt_satilik_ara.TabIndex = 9;
            this.txt_satilik_ara.Text = "(Mahalleye Göre..)";
            this.txt_satilik_ara.TextChanged += new System.EventHandler(this.txt_satilik_ara_TextChanged);
            this.txt_satilik_ara.MouseEnter += new System.EventHandler(this.txt_satilik_ara_MouseEnter);
            // 
            // btn_stlk_daire_ekle
            // 
            this.btn_stlk_daire_ekle.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stlk_daire_ekle.ForeColor = System.Drawing.Color.YellowGreen;
            this.btn_stlk_daire_ekle.Location = new System.Drawing.Point(7, 12);
            this.btn_stlk_daire_ekle.Name = "btn_stlk_daire_ekle";
            this.btn_stlk_daire_ekle.Size = new System.Drawing.Size(117, 35);
            this.btn_stlk_daire_ekle.TabIndex = 3;
            this.btn_stlk_daire_ekle.Text = "EKLE";
            this.btn_stlk_daire_ekle.UseVisualStyleBackColor = true;
            this.btn_stlk_daire_ekle.Click += new System.EventHandler(this.btn_stlk_daire_ekle_Click);
            // 
            // btn_satilik_sil
            // 
            this.btn_satilik_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satilik_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_satilik_sil.Location = new System.Drawing.Point(302, 12);
            this.btn_satilik_sil.Name = "btn_satilik_sil";
            this.btn_satilik_sil.Size = new System.Drawing.Size(117, 35);
            this.btn_satilik_sil.TabIndex = 6;
            this.btn_satilik_sil.Text = "SİL !";
            this.btn_satilik_sil.UseVisualStyleBackColor = true;
            this.btn_satilik_sil.Click += new System.EventHandler(this.btn_satilik_sil_Click);
            // 
            // btn_satilik_yenile
            // 
            this.btn_satilik_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satilik_yenile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_satilik_yenile.Location = new System.Drawing.Point(157, 12);
            this.btn_satilik_yenile.Name = "btn_satilik_yenile";
            this.btn_satilik_yenile.Size = new System.Drawing.Size(117, 35);
            this.btn_satilik_yenile.TabIndex = 4;
            this.btn_satilik_yenile.Text = "YENİLE!";
            this.btn_satilik_yenile.UseVisualStyleBackColor = true;
            this.btn_satilik_yenile.Click += new System.EventHandler(this.btn_satilik_yenile_Click);
            // 
            // datagrid_satilik_daireler
            // 
            this.datagrid_satilik_daireler.AllowUserToAddRows = false;
            this.datagrid_satilik_daireler.AllowUserToDeleteRows = false;
            this.datagrid_satilik_daireler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_satilik_daireler.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_satilik_daireler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_satilik_daireler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_satilik_daireler.Location = new System.Drawing.Point(0, 63);
            this.datagrid_satilik_daireler.Name = "datagrid_satilik_daireler";
            this.datagrid_satilik_daireler.ReadOnly = true;
            this.datagrid_satilik_daireler.RowHeadersWidth = 51;
            this.datagrid_satilik_daireler.RowTemplate.Height = 24;
            this.datagrid_satilik_daireler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_satilik_daireler.Size = new System.Drawing.Size(1456, 536);
            this.datagrid_satilik_daireler.TabIndex = 1;
            this.datagrid_satilik_daireler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_satilik_daireler_CellClick);
            this.datagrid_satilik_daireler.DoubleClick += new System.EventHandler(this.datagrid_satilik_daireler_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_konum);
            this.panel2.Controls.Add(this.btn_konum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_satilik_yol);
            this.panel2.Controls.Add(this.btn_fotogoster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 47);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(838, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Konum :";
            // 
            // txt_konum
            // 
            this.txt_konum.Enabled = false;
            this.txt_konum.Location = new System.Drawing.Point(920, 9);
            this.txt_konum.Multiline = true;
            this.txt_konum.Name = "txt_konum";
            this.txt_konum.Size = new System.Drawing.Size(355, 31);
            this.txt_konum.TabIndex = 5;
            // 
            // btn_konum
            // 
            this.btn_konum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_konum.ForeColor = System.Drawing.Color.Red;
            this.btn_konum.Location = new System.Drawing.Point(1281, 9);
            this.btn_konum.Name = "btn_konum";
            this.btn_konum.Size = new System.Drawing.Size(161, 31);
            this.btn_konum.TabIndex = 4;
            this.btn_konum.Text = "KONUM GÖSTER !";
            this.btn_konum.UseVisualStyleBackColor = true;
            this.btn_konum.Click += new System.EventHandler(this.btn_konum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dairenin Fotoğraf Klasörü :";
            // 
            // txt_satilik_yol
            // 
            this.txt_satilik_yol.Enabled = false;
            this.txt_satilik_yol.Location = new System.Drawing.Point(245, 13);
            this.txt_satilik_yol.Multiline = true;
            this.txt_satilik_yol.Name = "txt_satilik_yol";
            this.txt_satilik_yol.Size = new System.Drawing.Size(409, 31);
            this.txt_satilik_yol.TabIndex = 1;
            // 
            // btn_fotogoster
            // 
            this.btn_fotogoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fotogoster.ForeColor = System.Drawing.Color.Purple;
            this.btn_fotogoster.Location = new System.Drawing.Point(660, 13);
            this.btn_fotogoster.Name = "btn_fotogoster";
            this.btn_fotogoster.Size = new System.Drawing.Size(146, 31);
            this.btn_fotogoster.TabIndex = 0;
            this.btn_fotogoster.Text = "FOTO GÖSTER !";
            this.btn_fotogoster.UseVisualStyleBackColor = true;
            this.btn_fotogoster.Click += new System.EventHandler(this.btn_fotogoster_Click);
            // 
            // satilik_daireler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagrid_satilik_daireler);
            this.Controls.Add(this.panel1);
            this.Name = "satilik_daireler";
            this.ShowIcon = false;
            this.Text = "SATILIK DAİRELER";
            this.Load += new System.EventHandler(this.satilik_daireler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_satilik_daireler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_stlk_daire_ekle;
        private System.Windows.Forms.Button btn_satilik_sil;
        private System.Windows.Forms.Button btn_satilik_yenile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_satilik_yol;
        private System.Windows.Forms.Button btn_fotogoster;
        private System.Windows.Forms.Label lbl_satilik_ara;
        private System.Windows.Forms.TextBox txt_satilik_ara;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView datagrid_satilik_daireler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_konum;
        public System.Windows.Forms.Button btn_konum;
    }
}