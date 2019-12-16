namespace SuOtomasyon
{
    partial class YeniKayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.grbYeniKayit = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbYeniKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(52, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "SU SATIŞ OTOMASYONU";
            // 
            // grbYeniKayit
            // 
            this.grbYeniKayit.Controls.Add(this.txtTelefon);
            this.grbYeniKayit.Controls.Add(this.btnKaydet);
            this.grbYeniKayit.Controls.Add(this.txtAdres);
            this.grbYeniKayit.Controls.Add(this.txtSoyadi);
            this.grbYeniKayit.Controls.Add(this.txtAdi);
            this.grbYeniKayit.Controls.Add(this.label5);
            this.grbYeniKayit.Controls.Add(this.label4);
            this.grbYeniKayit.Controls.Add(this.label2);
            this.grbYeniKayit.Controls.Add(this.label1);
            this.grbYeniKayit.Location = new System.Drawing.Point(61, 152);
            this.grbYeniKayit.Name = "grbYeniKayit";
            this.grbYeniKayit.Size = new System.Drawing.Size(482, 474);
            this.grbYeniKayit.TabIndex = 4;
            this.grbYeniKayit.TabStop = false;
            this.grbYeniKayit.Text = "Yeni Kayıt";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(192, 170);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(232, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(319, 401);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 46);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(192, 227);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(232, 142);
            this.txtAdres.TabIndex = 4;
            this.txtAdres.Text = "";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(192, 110);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(232, 22);
            this.txtSoyadi.TabIndex = 2;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(192, 57);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(232, 22);
            this.txtAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(70, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 714);
            this.Controls.Add(this.grbYeniKayit);
            this.Controls.Add(this.label3);
            this.Name = "YeniKayit";
            this.Text = "YeniKayit";
            this.Load += new System.EventHandler(this.YeniKayit_Load);
            this.grbYeniKayit.ResumeLayout(false);
            this.grbYeniKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbYeniKayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}