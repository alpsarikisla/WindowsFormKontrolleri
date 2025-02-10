namespace WindowsFomKontrolleri
{
    partial class TarihKontrolleri
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
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_uzunTarih = new System.Windows.Forms.Label();
            this.lbl_kisaTarih = new System.Windows.Forms.Label();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.lbl_Ay = new System.Windows.Forms.Label();
            this.lbl_Yil = new System.Windows.Forms.Label();
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.lbl_Dakika = new System.Windows.Forms.Label();
            this.lbl_Saniye = new System.Windows.Forms.Label();
            this.lbl_Salise = new System.Windows.Forms.Label();
            this.dtp_tarihsec = new System.Windows.Forms.DateTimePicker();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_secilenTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Time Veri Türü";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(26, 75);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(44, 20);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "Tarih";
            // 
            // lbl_uzunTarih
            // 
            this.lbl_uzunTarih.AutoSize = true;
            this.lbl_uzunTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uzunTarih.Location = new System.Drawing.Point(26, 111);
            this.lbl_uzunTarih.Name = "lbl_uzunTarih";
            this.lbl_uzunTarih.Size = new System.Drawing.Size(86, 20);
            this.lbl_uzunTarih.TabIndex = 2;
            this.lbl_uzunTarih.Text = "Uzun Tarih";
            // 
            // lbl_kisaTarih
            // 
            this.lbl_kisaTarih.AutoSize = true;
            this.lbl_kisaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kisaTarih.Location = new System.Drawing.Point(26, 144);
            this.lbl_kisaTarih.Name = "lbl_kisaTarih";
            this.lbl_kisaTarih.Size = new System.Drawing.Size(78, 20);
            this.lbl_kisaTarih.TabIndex = 2;
            this.lbl_kisaTarih.Text = "Kısa Tarih";
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gun.Location = new System.Drawing.Point(27, 195);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(49, 20);
            this.lbl_gun.TabIndex = 3;
            this.lbl_gun.Text = "Gün=";
            // 
            // lbl_Ay
            // 
            this.lbl_Ay.AutoSize = true;
            this.lbl_Ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ay.Location = new System.Drawing.Point(27, 226);
            this.lbl_Ay.Name = "lbl_Ay";
            this.lbl_Ay.Size = new System.Drawing.Size(36, 20);
            this.lbl_Ay.TabIndex = 4;
            this.lbl_Ay.Text = "Ay=";
            // 
            // lbl_Yil
            // 
            this.lbl_Yil.AutoSize = true;
            this.lbl_Yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yil.Location = new System.Drawing.Point(28, 257);
            this.lbl_Yil.Name = "lbl_Yil";
            this.lbl_Yil.Size = new System.Drawing.Size(35, 20);
            this.lbl_Yil.TabIndex = 5;
            this.lbl_Yil.Text = "Yıl=";
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Saat.Location = new System.Drawing.Point(220, 195);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(52, 20);
            this.lbl_Saat.TabIndex = 6;
            this.lbl_Saat.Text = "Saat=";
            // 
            // lbl_Dakika
            // 
            this.lbl_Dakika.AutoSize = true;
            this.lbl_Dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Dakika.Location = new System.Drawing.Point(220, 226);
            this.lbl_Dakika.Name = "lbl_Dakika";
            this.lbl_Dakika.Size = new System.Drawing.Size(67, 20);
            this.lbl_Dakika.TabIndex = 7;
            this.lbl_Dakika.Text = "Dakika=";
            // 
            // lbl_Saniye
            // 
            this.lbl_Saniye.AutoSize = true;
            this.lbl_Saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Saniye.Location = new System.Drawing.Point(220, 257);
            this.lbl_Saniye.Name = "lbl_Saniye";
            this.lbl_Saniye.Size = new System.Drawing.Size(66, 20);
            this.lbl_Saniye.TabIndex = 8;
            this.lbl_Saniye.Text = "Saniye=";
            // 
            // lbl_Salise
            // 
            this.lbl_Salise.AutoSize = true;
            this.lbl_Salise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Salise.Location = new System.Drawing.Point(220, 288);
            this.lbl_Salise.Name = "lbl_Salise";
            this.lbl_Salise.Size = new System.Drawing.Size(61, 20);
            this.lbl_Salise.TabIndex = 9;
            this.lbl_Salise.Text = "Salise=";
            // 
            // dtp_tarihsec
            // 
            this.dtp_tarihsec.Location = new System.Drawing.Point(30, 369);
            this.dtp_tarihsec.Name = "dtp_tarihsec";
            this.dtp_tarihsec.Size = new System.Drawing.Size(200, 20);
            this.dtp_tarihsec.TabIndex = 10;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(236, 366);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(125, 23);
            this.btn_getir.TabIndex = 11;
            this.btn_getir.Text = "Tarih Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_secilenTarih
            // 
            this.lbl_secilenTarih.AutoSize = true;
            this.lbl_secilenTarih.Location = new System.Drawing.Point(367, 371);
            this.lbl_secilenTarih.Name = "lbl_secilenTarih";
            this.lbl_secilenTarih.Size = new System.Drawing.Size(81, 13);
            this.lbl_secilenTarih.TabIndex = 12;
            this.lbl_secilenTarih.Text = "Seçilen Tarih = ";
            // 
            // TarihKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.lbl_secilenTarih);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.dtp_tarihsec);
            this.Controls.Add(this.lbl_Salise);
            this.Controls.Add(this.lbl_Saniye);
            this.Controls.Add(this.lbl_Dakika);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.lbl_Yil);
            this.Controls.Add(this.lbl_Ay);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.lbl_kisaTarih);
            this.Controls.Add(this.lbl_uzunTarih);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.label1);
            this.Name = "TarihKontrolleri";
            this.Text = "TarihKontrolleri";
            this.Load += new System.EventHandler(this.TarihKontrolleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_uzunTarih;
        private System.Windows.Forms.Label lbl_kisaTarih;
        private System.Windows.Forms.Label lbl_gun;
        private System.Windows.Forms.Label lbl_Ay;
        private System.Windows.Forms.Label lbl_Yil;
        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.Label lbl_Dakika;
        private System.Windows.Forms.Label lbl_Saniye;
        private System.Windows.Forms.Label lbl_Salise;
        private System.Windows.Forms.DateTimePicker dtp_tarihsec;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_secilenTarih;
    }
}