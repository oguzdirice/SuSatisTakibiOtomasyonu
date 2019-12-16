namespace SuOtomasyon
{
    partial class Form1
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
            this.grbArama = new System.Windows.Forms.GroupBox();
            this.tbxMusteriAdiAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMusteriler = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtgMusteriler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.grbTabloİslemleri = new System.Windows.Forms.GroupBox();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.btnBugunSiparisler = new System.Windows.Forms.Button();
            this.grbSiparisler = new System.Windows.Forms.GroupBox();
            this.btnTeslimEdildi = new System.Windows.Forms.Button();
            this.btnYeniCikti = new System.Windows.Forms.Button();
            this.btnYeniSiparis = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dtgSiparisler = new System.Windows.Forms.DataGridView();
            this.grbArama.SuspendLayout();
            this.grbMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriler)).BeginInit();
            this.grbTabloİslemleri.SuspendLayout();
            this.grbSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // grbArama
            // 
            this.grbArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbArama.Controls.Add(this.tbxMusteriAdiAra);
            this.grbArama.Controls.Add(this.label1);
            this.grbArama.Location = new System.Drawing.Point(22, 116);
            this.grbArama.Name = "grbArama";
            this.grbArama.Size = new System.Drawing.Size(831, 75);
            this.grbArama.TabIndex = 0;
            this.grbArama.TabStop = false;
            this.grbArama.Text = "Arama";
            // 
            // tbxMusteriAdiAra
            // 
            this.tbxMusteriAdiAra.Location = new System.Drawing.Point(77, 41);
            this.tbxMusteriAdiAra.Name = "tbxMusteriAdiAra";
            this.tbxMusteriAdiAra.Size = new System.Drawing.Size(460, 22);
            this.tbxMusteriAdiAra.TabIndex = 3;
            this.tbxMusteriAdiAra.TextChanged += new System.EventHandler(this.tbxMusteriAdiAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbMusteriler
            // 
            this.grbMusteriler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbMusteriler.Controls.Add(this.btnSil);
            this.grbMusteriler.Controls.Add(this.btnGuncelle);
            this.grbMusteriler.Controls.Add(this.btnEkle);
            this.grbMusteriler.Controls.Add(this.dtgMusteriler);
            this.grbMusteriler.Location = new System.Drawing.Point(22, 221);
            this.grbMusteriler.Name = "grbMusteriler";
            this.grbMusteriler.Size = new System.Drawing.Size(831, 397);
            this.grbMusteriler.TabIndex = 1;
            this.grbMusteriler.TabStop = false;
            this.grbMusteriler.Text = "Müşteriler";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(255, 323);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 56);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(129, 323);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 56);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(20, 323);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 56);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtgMusteriler
            // 
            this.dtgMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMusteriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgMusteriler.Location = new System.Drawing.Point(6, 30);
            this.dtgMusteriler.Name = "dtgMusteriler";
            this.dtgMusteriler.RowHeadersWidth = 51;
            this.dtgMusteriler.RowTemplate.Height = 24;
            this.dtgMusteriler.Size = new System.Drawing.Size(819, 273);
            this.dtgMusteriler.TabIndex = 0;
            this.dtgMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusteriler_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(627, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "SU SATIŞ OTOMASYONU";
            // 
            // grbTabloİslemleri
            // 
            this.grbTabloİslemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbTabloİslemleri.Controls.Add(this.btnSeciliSil);
            this.grbTabloİslemleri.Controls.Add(this.btnBugunSiparisler);
            this.grbTabloİslemleri.Location = new System.Drawing.Point(881, 116);
            this.grbTabloİslemleri.Name = "grbTabloİslemleri";
            this.grbTabloİslemleri.Size = new System.Drawing.Size(836, 75);
            this.grbTabloİslemleri.TabIndex = 3;
            this.grbTabloİslemleri.TabStop = false;
            this.grbTabloİslemleri.Text = "Tablo İşlemleri";
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSeciliSil.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnSeciliSil.FlatAppearance.BorderSize = 0;
            this.btnSeciliSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeciliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeciliSil.Location = new System.Drawing.Point(401, 18);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(201, 43);
            this.btnSeciliSil.TabIndex = 2;
            this.btnSeciliSil.Text = "SEÇİLİ OLANI SİL";
            this.btnSeciliSil.UseVisualStyleBackColor = false;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // btnBugunSiparisler
            // 
            this.btnBugunSiparisler.BackColor = System.Drawing.Color.Pink;
            this.btnBugunSiparisler.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnBugunSiparisler.FlatAppearance.BorderSize = 0;
            this.btnBugunSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBugunSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBugunSiparisler.Location = new System.Drawing.Point(622, 18);
            this.btnBugunSiparisler.Name = "btnBugunSiparisler";
            this.btnBugunSiparisler.Size = new System.Drawing.Size(199, 43);
            this.btnBugunSiparisler.TabIndex = 0;
            this.btnBugunSiparisler.Text = "BUGÜNÜN SİPARİŞLERİ";
            this.btnBugunSiparisler.UseVisualStyleBackColor = false;
            this.btnBugunSiparisler.Click += new System.EventHandler(this.btnBugunSiparisler_Click);
            // 
            // grbSiparisler
            // 
            this.grbSiparisler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbSiparisler.Controls.Add(this.btnTeslimEdildi);
            this.grbSiparisler.Controls.Add(this.btnYeniCikti);
            this.grbSiparisler.Controls.Add(this.btnYeniSiparis);
            this.grbSiparisler.Controls.Add(this.btnYenile);
            this.grbSiparisler.Controls.Add(this.dtgSiparisler);
            this.grbSiparisler.Location = new System.Drawing.Point(874, 221);
            this.grbSiparisler.Name = "grbSiparisler";
            this.grbSiparisler.Size = new System.Drawing.Size(843, 397);
            this.grbSiparisler.TabIndex = 4;
            this.grbSiparisler.TabStop = false;
            this.grbSiparisler.Text = "Siparişler";
            // 
            // btnTeslimEdildi
            // 
            this.btnTeslimEdildi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeslimEdildi.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnTeslimEdildi.FlatAppearance.BorderSize = 0;
            this.btnTeslimEdildi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeslimEdildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEdildi.Location = new System.Drawing.Point(244, 323);
            this.btnTeslimEdildi.Name = "btnTeslimEdildi";
            this.btnTeslimEdildi.Size = new System.Drawing.Size(102, 56);
            this.btnTeslimEdildi.TabIndex = 4;
            this.btnTeslimEdildi.Text = "Teslim Edildi";
            this.btnTeslimEdildi.UseVisualStyleBackColor = false;
            this.btnTeslimEdildi.Click += new System.EventHandler(this.btnTeslimEdildi_Click);
            // 
            // btnYeniCikti
            // 
            this.btnYeniCikti.BackColor = System.Drawing.Color.Thistle;
            this.btnYeniCikti.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnYeniCikti.FlatAppearance.BorderSize = 0;
            this.btnYeniCikti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniCikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniCikti.Location = new System.Drawing.Point(134, 323);
            this.btnYeniCikti.Name = "btnYeniCikti";
            this.btnYeniCikti.Size = new System.Drawing.Size(102, 56);
            this.btnYeniCikti.TabIndex = 3;
            this.btnYeniCikti.Text = "Yeni Çıktı";
            this.btnYeniCikti.UseVisualStyleBackColor = false;
            this.btnYeniCikti.Click += new System.EventHandler(this.btnYeniCikti_Click);
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnYeniSiparis.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnYeniSiparis.FlatAppearance.BorderSize = 0;
            this.btnYeniSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSiparis.Location = new System.Drawing.Point(24, 323);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(102, 56);
            this.btnYeniSiparis.TabIndex = 2;
            this.btnYeniSiparis.Text = "Yeni Sipariş";
            this.btnYeniSiparis.UseVisualStyleBackColor = false;
            this.btnYeniSiparis.Click += new System.EventHandler(this.btnYeniSiparis_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Linen;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(753, 323);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 25);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dtgSiparisler
            // 
            this.dtgSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSiparisler.Location = new System.Drawing.Point(7, 30);
            this.dtgSiparisler.Name = "dtgSiparisler";
            this.dtgSiparisler.RowHeadersWidth = 51;
            this.dtgSiparisler.RowTemplate.Height = 24;
            this.dtgSiparisler.Size = new System.Drawing.Size(830, 273);
            this.dtgSiparisler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1756, 719);
            this.Controls.Add(this.grbSiparisler);
            this.Controls.Add(this.grbTabloİslemleri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbMusteriler);
            this.Controls.Add(this.grbArama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SU SATIŞ OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbArama.ResumeLayout(false);
            this.grbArama.PerformLayout();
            this.grbMusteriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriler)).EndInit();
            this.grbTabloİslemleri.ResumeLayout(false);
            this.grbSiparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMusteriAdiAra;
        private System.Windows.Forms.GroupBox grbMusteriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dtgMusteriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbTabloİslemleri;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.Button btnBugunSiparisler;
        private System.Windows.Forms.GroupBox grbSiparisler;
        private System.Windows.Forms.Button btnTeslimEdildi;
        private System.Windows.Forms.Button btnYeniCikti;
        private System.Windows.Forms.Button btnYeniSiparis;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dtgSiparisler;
    }
}

