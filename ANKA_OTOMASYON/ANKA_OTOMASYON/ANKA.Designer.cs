namespace ANKA_OTOMASYON
{
    partial class ANKA
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANKA));
            this.strip_anka_genel = new System.Windows.Forms.MenuStrip();
            this.SATILIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satilik_daire_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satilik_arsa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satilik_arac_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KİRALIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralık_daire_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralik_arac_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kREDİHESAPLAYICIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webControl_sahibinden = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.grpbx_satiliklar = new System.Windows.Forms.GroupBox();
            this.lbl_kiralik_arac = new System.Windows.Forms.Label();
            this.lbl_kiralik_daire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_satilik_arac = new System.Windows.Forms.Label();
            this.lbl_satilik_arsa = new System.Windows.Forms.Label();
            this.lbl_satilik_daire = new System.Windows.Forms.Label();
            this.grpbx_bekleyenler = new System.Windows.Forms.GroupBox();
            this.btn_müsteri_yenile = new System.Windows.Forms.Button();
            this.btn_müsteri_ekle = new System.Windows.Forms.Button();
            this.datagrid_müsteri = new System.Windows.Forms.DataGridView();
            this.btn_müsteri_sil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_randevu_yenile = new System.Windows.Forms.Button();
            this.btn_randevu_ekle = new System.Windows.Forms.Button();
            this.btn_randevu_sil = new System.Windows.Forms.Button();
            this.datagrid_randevu = new System.Windows.Forms.DataGridView();
            this.btn_list_yenile = new System.Windows.Forms.Button();
            this.strip_anka_genel.SuspendLayout();
            this.grpbx_satiliklar.SuspendLayout();
            this.grpbx_bekleyenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_müsteri)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_randevu)).BeginInit();
            this.SuspendLayout();
            // 
            // strip_anka_genel
            // 
            this.strip_anka_genel.BackColor = System.Drawing.Color.White;
            this.strip_anka_genel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strip_anka_genel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SATILIKToolStripMenuItem,
            this.KİRALIKToolStripMenuItem,
            this.kREDİHESAPLAYICIToolStripMenuItem});
            this.strip_anka_genel.Location = new System.Drawing.Point(0, 0);
            this.strip_anka_genel.Name = "strip_anka_genel";
            this.strip_anka_genel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.strip_anka_genel.Size = new System.Drawing.Size(1352, 28);
            this.strip_anka_genel.TabIndex = 1;
            this.strip_anka_genel.Text = "menuStrip1";
            // 
            // SATILIKToolStripMenuItem
            // 
            this.SATILIKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satilik_daire_ToolStripMenuItem,
            this.satilik_arsa_ToolStripMenuItem,
            this.satilik_arac_ToolStripMenuItem});
            this.SATILIKToolStripMenuItem.Name = "SATILIKToolStripMenuItem";
            this.SATILIKToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.SATILIKToolStripMenuItem.Text = "SATILIK";
            // 
            // satilik_daire_ToolStripMenuItem
            // 
            this.satilik_daire_ToolStripMenuItem.Name = "satilik_daire_ToolStripMenuItem";
            this.satilik_daire_ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.satilik_daire_ToolStripMenuItem.Text = "DAİRE";
            this.satilik_daire_ToolStripMenuItem.Click += new System.EventHandler(this.satilik_daire_ToolStripMenuItem_Click_1);
            // 
            // satilik_arsa_ToolStripMenuItem
            // 
            this.satilik_arsa_ToolStripMenuItem.Name = "satilik_arsa_ToolStripMenuItem";
            this.satilik_arsa_ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.satilik_arsa_ToolStripMenuItem.Text = "ARSA";
            this.satilik_arsa_ToolStripMenuItem.Click += new System.EventHandler(this.satilik_arsa_ToolStripMenuItem_Click);
            // 
            // satilik_arac_ToolStripMenuItem
            // 
            this.satilik_arac_ToolStripMenuItem.Name = "satilik_arac_ToolStripMenuItem";
            this.satilik_arac_ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.satilik_arac_ToolStripMenuItem.Text = "ARAÇ";
            this.satilik_arac_ToolStripMenuItem.Click += new System.EventHandler(this.satilik_arac_ToolStripMenuItem_Click);
            // 
            // KİRALIKToolStripMenuItem
            // 
            this.KİRALIKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiralık_daire_ToolStripMenuItem1,
            this.kiralik_arac_ToolStripMenuItem1});
            this.KİRALIKToolStripMenuItem.Name = "KİRALIKToolStripMenuItem";
            this.KİRALIKToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.KİRALIKToolStripMenuItem.Text = "KİRALIK";
            // 
            // kiralık_daire_ToolStripMenuItem1
            // 
            this.kiralık_daire_ToolStripMenuItem1.Name = "kiralık_daire_ToolStripMenuItem1";
            this.kiralık_daire_ToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.kiralık_daire_ToolStripMenuItem1.Text = "DAİRE";
            this.kiralık_daire_ToolStripMenuItem1.Click += new System.EventHandler(this.kiralık_daire_ToolStripMenuItem1_Click);
            // 
            // kiralik_arac_ToolStripMenuItem1
            // 
            this.kiralik_arac_ToolStripMenuItem1.Name = "kiralik_arac_ToolStripMenuItem1";
            this.kiralik_arac_ToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.kiralik_arac_ToolStripMenuItem1.Text = "ARAÇ";
            this.kiralik_arac_ToolStripMenuItem1.Click += new System.EventHandler(this.kiralik_arac_ToolStripMenuItem1_Click);
            // 
            // kREDİHESAPLAYICIToolStripMenuItem
            // 
            this.kREDİHESAPLAYICIToolStripMenuItem.Name = "kREDİHESAPLAYICIToolStripMenuItem";
            this.kREDİHESAPLAYICIToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.kREDİHESAPLAYICIToolStripMenuItem.Text = "KREDİ HESAPLAYICI";
            this.kREDİHESAPLAYICIToolStripMenuItem.Click += new System.EventHandler(this.KREDİHESAPLAYICIToolStripMenuItem_Click_1);
            // 
            // webControl_sahibinden
            // 
            this.webControl_sahibinden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl_sahibinden.BackColor = System.Drawing.Color.White;
            this.webControl_sahibinden.Location = new System.Drawing.Point(0, 32);
            this.webControl_sahibinden.Name = "webControl_sahibinden";
            this.webControl_sahibinden.Size = new System.Drawing.Size(788, 571);
            this.webControl_sahibinden.TabIndex = 3;
            this.webControl_sahibinden.Text = "webControl1";
            this.webControl_sahibinden.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.InputMsgFilter = null;
            this.webView1.ObjectForScripting = null;
            this.webView1.Title = null;
            // 
            // grpbx_satiliklar
            // 
            this.grpbx_satiliklar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_satiliklar.Controls.Add(this.btn_list_yenile);
            this.grpbx_satiliklar.Controls.Add(this.lbl_kiralik_arac);
            this.grpbx_satiliklar.Controls.Add(this.lbl_kiralik_daire);
            this.grpbx_satiliklar.Controls.Add(this.label2);
            this.grpbx_satiliklar.Controls.Add(this.label6);
            this.grpbx_satiliklar.Controls.Add(this.label5);
            this.grpbx_satiliklar.Controls.Add(this.label1);
            this.grpbx_satiliklar.Controls.Add(this.lbl_satilik_arac);
            this.grpbx_satiliklar.Controls.Add(this.lbl_satilik_arsa);
            this.grpbx_satiliklar.Controls.Add(this.lbl_satilik_daire);
            this.grpbx_satiliklar.ForeColor = System.Drawing.Color.OliveDrab;
            this.grpbx_satiliklar.Location = new System.Drawing.Point(795, 32);
            this.grpbx_satiliklar.Name = "grpbx_satiliklar";
            this.grpbx_satiliklar.Size = new System.Drawing.Size(545, 125);
            this.grpbx_satiliklar.TabIndex = 4;
            this.grpbx_satiliklar.TabStop = false;
            this.grpbx_satiliklar.Text = "SATILIKLAR";
            // 
            // lbl_kiralik_arac
            // 
            this.lbl_kiralik_arac.AutoSize = true;
            this.lbl_kiralik_arac.ForeColor = System.Drawing.Color.Black;
            this.lbl_kiralik_arac.Location = new System.Drawing.Point(268, 53);
            this.lbl_kiralik_arac.Name = "lbl_kiralik_arac";
            this.lbl_kiralik_arac.Size = new System.Drawing.Size(97, 16);
            this.lbl_kiralik_arac.TabIndex = 8;
            this.lbl_kiralik_arac.Text = "lbl_kiralik_arac";
            // 
            // lbl_kiralik_daire
            // 
            this.lbl_kiralik_daire.AutoSize = true;
            this.lbl_kiralik_daire.ForeColor = System.Drawing.Color.Black;
            this.lbl_kiralik_daire.Location = new System.Drawing.Point(268, 27);
            this.lbl_kiralik_daire.Name = "lbl_kiralik_daire";
            this.lbl_kiralik_daire.Size = new System.Drawing.Size(101, 16);
            this.lbl_kiralik_daire.TabIndex = 8;
            this.lbl_kiralik_daire.Text = "lbl_kiralik_daire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "KİRALIKLAR";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(98, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 5);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(544, 5);
            this.label5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 100);
            this.label1.TabIndex = 3;
            // 
            // lbl_satilik_arac
            // 
            this.lbl_satilik_arac.AutoSize = true;
            this.lbl_satilik_arac.ForeColor = System.Drawing.Color.Black;
            this.lbl_satilik_arac.Location = new System.Drawing.Point(-1, 82);
            this.lbl_satilik_arac.Name = "lbl_satilik_arac";
            this.lbl_satilik_arac.Size = new System.Drawing.Size(96, 16);
            this.lbl_satilik_arac.TabIndex = 2;
            this.lbl_satilik_arac.Text = "lbl_satilik_arac";
            // 
            // lbl_satilik_arsa
            // 
            this.lbl_satilik_arsa.AutoSize = true;
            this.lbl_satilik_arsa.ForeColor = System.Drawing.Color.Black;
            this.lbl_satilik_arsa.Location = new System.Drawing.Point(-1, 53);
            this.lbl_satilik_arsa.Name = "lbl_satilik_arsa";
            this.lbl_satilik_arsa.Size = new System.Drawing.Size(96, 16);
            this.lbl_satilik_arsa.TabIndex = 1;
            this.lbl_satilik_arsa.Text = "lbl_satilik_arsa";
            // 
            // lbl_satilik_daire
            // 
            this.lbl_satilik_daire.AutoSize = true;
            this.lbl_satilik_daire.ForeColor = System.Drawing.Color.Black;
            this.lbl_satilik_daire.Location = new System.Drawing.Point(-1, 27);
            this.lbl_satilik_daire.Name = "lbl_satilik_daire";
            this.lbl_satilik_daire.Size = new System.Drawing.Size(100, 16);
            this.lbl_satilik_daire.TabIndex = 0;
            this.lbl_satilik_daire.Text = "lbl_satilik_daire";
            // 
            // grpbx_bekleyenler
            // 
            this.grpbx_bekleyenler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_bekleyenler.Controls.Add(this.btn_müsteri_yenile);
            this.grpbx_bekleyenler.Controls.Add(this.btn_müsteri_ekle);
            this.grpbx_bekleyenler.Controls.Add(this.datagrid_müsteri);
            this.grpbx_bekleyenler.Controls.Add(this.btn_müsteri_sil);
            this.grpbx_bekleyenler.ForeColor = System.Drawing.Color.Black;
            this.grpbx_bekleyenler.Location = new System.Drawing.Point(795, 163);
            this.grpbx_bekleyenler.Name = "grpbx_bekleyenler";
            this.grpbx_bekleyenler.Size = new System.Drawing.Size(545, 272);
            this.grpbx_bekleyenler.TabIndex = 6;
            this.grpbx_bekleyenler.TabStop = false;
            this.grpbx_bekleyenler.Text = "BEKLEYEN MÜŞTERİLER";
            // 
            // btn_müsteri_yenile
            // 
            this.btn_müsteri_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_müsteri_yenile.ForeColor = System.Drawing.Color.Snow;
            this.btn_müsteri_yenile.Location = new System.Drawing.Point(470, 0);
            this.btn_müsteri_yenile.Name = "btn_müsteri_yenile";
            this.btn_müsteri_yenile.Size = new System.Drawing.Size(75, 26);
            this.btn_müsteri_yenile.TabIndex = 9;
            this.btn_müsteri_yenile.Text = "YENİLE";
            this.btn_müsteri_yenile.UseVisualStyleBackColor = false;
            this.btn_müsteri_yenile.Click += new System.EventHandler(this.btn_müsteri_yenile_Click);
            // 
            // btn_müsteri_ekle
            // 
            this.btn_müsteri_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_müsteri_ekle.ForeColor = System.Drawing.Color.Snow;
            this.btn_müsteri_ekle.Location = new System.Drawing.Point(257, 0);
            this.btn_müsteri_ekle.Name = "btn_müsteri_ekle";
            this.btn_müsteri_ekle.Size = new System.Drawing.Size(75, 26);
            this.btn_müsteri_ekle.TabIndex = 1;
            this.btn_müsteri_ekle.Text = "EKLE";
            this.btn_müsteri_ekle.UseVisualStyleBackColor = false;
            this.btn_müsteri_ekle.Click += new System.EventHandler(this.btn_müsteri_ekle_Click);
            // 
            // datagrid_müsteri
            // 
            this.datagrid_müsteri.AllowUserToAddRows = false;
            this.datagrid_müsteri.AllowUserToDeleteRows = false;
            this.datagrid_müsteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_müsteri.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_müsteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_müsteri.Location = new System.Drawing.Point(1, 32);
            this.datagrid_müsteri.Name = "datagrid_müsteri";
            this.datagrid_müsteri.ReadOnly = true;
            this.datagrid_müsteri.RowHeadersWidth = 51;
            this.datagrid_müsteri.RowTemplate.Height = 24;
            this.datagrid_müsteri.Size = new System.Drawing.Size(544, 234);
            this.datagrid_müsteri.TabIndex = 0;
            // 
            // btn_müsteri_sil
            // 
            this.btn_müsteri_sil.BackColor = System.Drawing.Color.Red;
            this.btn_müsteri_sil.ForeColor = System.Drawing.Color.Snow;
            this.btn_müsteri_sil.Location = new System.Drawing.Point(368, 0);
            this.btn_müsteri_sil.Name = "btn_müsteri_sil";
            this.btn_müsteri_sil.Size = new System.Drawing.Size(75, 26);
            this.btn_müsteri_sil.TabIndex = 8;
            this.btn_müsteri_sil.Text = "SİL";
            this.btn_müsteri_sil.UseVisualStyleBackColor = false;
            this.btn_müsteri_sil.Click += new System.EventHandler(this.btn_müsteri_sil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_randevu_yenile);
            this.groupBox1.Controls.Add(this.btn_randevu_ekle);
            this.groupBox1.Controls.Add(this.btn_randevu_sil);
            this.groupBox1.Controls.Add(this.datagrid_randevu);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(794, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RANDEVULAR";
            // 
            // btn_randevu_yenile
            // 
            this.btn_randevu_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_randevu_yenile.ForeColor = System.Drawing.Color.Snow;
            this.btn_randevu_yenile.Location = new System.Drawing.Point(471, 0);
            this.btn_randevu_yenile.Name = "btn_randevu_yenile";
            this.btn_randevu_yenile.Size = new System.Drawing.Size(75, 26);
            this.btn_randevu_yenile.TabIndex = 11;
            this.btn_randevu_yenile.Text = "YENİLE";
            this.btn_randevu_yenile.UseVisualStyleBackColor = false;
            this.btn_randevu_yenile.Click += new System.EventHandler(this.btn_randevu_yenile_Click);
            // 
            // btn_randevu_ekle
            // 
            this.btn_randevu_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_randevu_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_randevu_ekle.Location = new System.Drawing.Point(258, 0);
            this.btn_randevu_ekle.Name = "btn_randevu_ekle";
            this.btn_randevu_ekle.Size = new System.Drawing.Size(75, 26);
            this.btn_randevu_ekle.TabIndex = 8;
            this.btn_randevu_ekle.Text = "EKLE";
            this.btn_randevu_ekle.UseVisualStyleBackColor = false;
            this.btn_randevu_ekle.Click += new System.EventHandler(this.btn_randevu_ekle_Click);
            // 
            // btn_randevu_sil
            // 
            this.btn_randevu_sil.BackColor = System.Drawing.Color.Red;
            this.btn_randevu_sil.ForeColor = System.Drawing.Color.Snow;
            this.btn_randevu_sil.Location = new System.Drawing.Point(369, 0);
            this.btn_randevu_sil.Name = "btn_randevu_sil";
            this.btn_randevu_sil.Size = new System.Drawing.Size(75, 26);
            this.btn_randevu_sil.TabIndex = 10;
            this.btn_randevu_sil.Text = "SİL";
            this.btn_randevu_sil.UseVisualStyleBackColor = false;
            this.btn_randevu_sil.Click += new System.EventHandler(this.btn_randevu_sil_Click);
            // 
            // datagrid_randevu
            // 
            this.datagrid_randevu.AllowUserToAddRows = false;
            this.datagrid_randevu.AllowUserToDeleteRows = false;
            this.datagrid_randevu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_randevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_randevu.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_randevu.Location = new System.Drawing.Point(1, 32);
            this.datagrid_randevu.Name = "datagrid_randevu";
            this.datagrid_randevu.ReadOnly = true;
            this.datagrid_randevu.RowHeadersWidth = 51;
            this.datagrid_randevu.RowTemplate.Height = 24;
            this.datagrid_randevu.Size = new System.Drawing.Size(544, 111);
            this.datagrid_randevu.TabIndex = 1;
            // 
            // btn_list_yenile
            // 
            this.btn_list_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_list_yenile.ForeColor = System.Drawing.Color.Snow;
            this.btn_list_yenile.Location = new System.Drawing.Point(470, 84);
            this.btn_list_yenile.Name = "btn_list_yenile";
            this.btn_list_yenile.Size = new System.Drawing.Size(75, 26);
            this.btn_list_yenile.TabIndex = 10;
            this.btn_list_yenile.Text = "YENİLE";
            this.btn_list_yenile.UseVisualStyleBackColor = false;
            this.btn_list_yenile.Click += new System.EventHandler(this.btn_list_yenile_Click);
            // 
            // ANKA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbx_bekleyenler);
            this.Controls.Add(this.grpbx_satiliklar);
            this.Controls.Add(this.webControl_sahibinden);
            this.Controls.Add(this.strip_anka_genel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strip_anka_genel;
            this.Name = "ANKA";
            this.Text = "EMLAK OTOMASYON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ANKA_Load);
            this.strip_anka_genel.ResumeLayout(false);
            this.strip_anka_genel.PerformLayout();
            this.grpbx_satiliklar.ResumeLayout(false);
            this.grpbx_satiliklar.PerformLayout();
            this.grpbx_bekleyenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_müsteri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_randevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip_anka_genel;
        private System.Windows.Forms.ToolStripMenuItem SATILIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satilik_daire_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satilik_arsa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satilik_arac_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KİRALIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralık_daire_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kiralik_arac_ToolStripMenuItem1;
        private EO.WinForm.WebControl webControl_sahibinden;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.ToolStripMenuItem kREDİHESAPLAYICIToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_satiliklar;
        private System.Windows.Forms.GroupBox grpbx_bekleyenler;
        public System.Windows.Forms.Label lbl_satilik_daire;
        private System.Windows.Forms.Button btn_müsteri_ekle;
        private System.Windows.Forms.DataGridView datagrid_müsteri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_randevu_ekle;
        private System.Windows.Forms.DataGridView datagrid_randevu;
        private System.Windows.Forms.Button btn_müsteri_yenile;
        private System.Windows.Forms.Button btn_müsteri_sil;
        private System.Windows.Forms.Button btn_randevu_yenile;
        private System.Windows.Forms.Button btn_randevu_sil;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_satilik_arac;
        public System.Windows.Forms.Label lbl_satilik_arsa;
        public System.Windows.Forms.Label lbl_kiralik_daire;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_kiralik_arac;
        private System.Windows.Forms.Button btn_list_yenile;
    }
}

