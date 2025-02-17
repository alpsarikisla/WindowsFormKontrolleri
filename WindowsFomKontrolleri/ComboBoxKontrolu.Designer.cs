namespace WindowsFomKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.btn_departmanGetir = new System.Windows.Forms.Button();
            this.lbl_secilenDepartman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ders = new System.Windows.Forms.ComboBox();
            this.btn_dersSec = new System.Windows.Forms.Button();
            this.lbl_secilenDers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_secilenSehir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birden çok seçenek arasından birini seçtirmeye yarayan araçtır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departman = ";
            // 
            // cb_departman
            // 
            this.cb_departman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Pazarlama",
            "Muhasebe",
            "İnsan Kaynakları",
            "Üretim Planlama",
            "Ar & Ge"});
            this.cb_departman.Location = new System.Drawing.Point(162, 84);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(294, 33);
            this.cb_departman.TabIndex = 2;
            // 
            // btn_departmanGetir
            // 
            this.btn_departmanGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_departmanGetir.Location = new System.Drawing.Point(476, 84);
            this.btn_departmanGetir.Name = "btn_departmanGetir";
            this.btn_departmanGetir.Size = new System.Drawing.Size(113, 33);
            this.btn_departmanGetir.TabIndex = 3;
            this.btn_departmanGetir.Text = "Getir";
            this.btn_departmanGetir.UseVisualStyleBackColor = true;
            this.btn_departmanGetir.Click += new System.EventHandler(this.btn_departmanGetir_Click);
            // 
            // lbl_secilenDepartman
            // 
            this.lbl_secilenDepartman.AutoSize = true;
            this.lbl_secilenDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilenDepartman.Location = new System.Drawing.Point(26, 133);
            this.lbl_secilenDepartman.Name = "lbl_secilenDepartman";
            this.lbl_secilenDepartman.Size = new System.Drawing.Size(195, 25);
            this.lbl_secilenDepartman.TabIndex = 4;
            this.lbl_secilenDepartman.Text = "Seçilen Departman =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ders =";
            // 
            // cb_ders
            // 
            this.cb_ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ders.FormattingEnabled = true;
            this.cb_ders.Location = new System.Drawing.Point(162, 190);
            this.cb_ders.Name = "cb_ders";
            this.cb_ders.Size = new System.Drawing.Size(294, 33);
            this.cb_ders.TabIndex = 2;
            // 
            // btn_dersSec
            // 
            this.btn_dersSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dersSec.Location = new System.Drawing.Point(476, 190);
            this.btn_dersSec.Name = "btn_dersSec";
            this.btn_dersSec.Size = new System.Drawing.Size(113, 33);
            this.btn_dersSec.TabIndex = 3;
            this.btn_dersSec.Text = "Ders Seç";
            this.btn_dersSec.UseVisualStyleBackColor = true;
            this.btn_dersSec.Click += new System.EventHandler(this.btn_dersSec_Click);
            // 
            // lbl_secilenDers
            // 
            this.lbl_secilenDers.AutoSize = true;
            this.lbl_secilenDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilenDers.Location = new System.Drawing.Point(26, 249);
            this.lbl_secilenDers.Name = "lbl_secilenDers";
            this.lbl_secilenDers.Size = new System.Drawing.Size(140, 25);
            this.lbl_secilenDers.TabIndex = 4;
            this.lbl_secilenDers.Text = "Seçilen Ders =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "ComboBox DataBound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şehir =";
            // 
            // cb_sehir
            // 
            this.cb_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Location = new System.Drawing.Point(140, 461);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(305, 33);
            this.cb_sehir.TabIndex = 7;
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(565, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "DataBound Verilerin bir veri kaynağından doldurulması işlemidir. \r\nBiz koleksiyon" +
    " aracılığıyla nesne içindeki verileri dolduracağız";
            // 
            // lbl_secilenSehir
            // 
            this.lbl_secilenSehir.AutoSize = true;
            this.lbl_secilenSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilenSehir.Location = new System.Drawing.Point(48, 524);
            this.lbl_secilenSehir.Name = "lbl_secilenSehir";
            this.lbl_secilenSehir.Size = new System.Drawing.Size(140, 25);
            this.lbl_secilenSehir.TabIndex = 9;
            this.lbl_secilenSehir.Text = "Seçilen Şehir=";
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 641);
            this.Controls.Add(this.lbl_secilenSehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_secilenDers);
            this.Controls.Add(this.lbl_secilenDepartman);
            this.Controls.Add(this.btn_dersSec);
            this.Controls.Add(this.btn_departmanGetir);
            this.Controls.Add(this.cb_ders);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.Load += new System.EventHandler(this.ComboBoxKontrolu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Button btn_departmanGetir;
        private System.Windows.Forms.Label lbl_secilenDepartman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ders;
        private System.Windows.Forms.Button btn_dersSec;
        private System.Windows.Forms.Label lbl_secilenDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_secilenSehir;
    }
}