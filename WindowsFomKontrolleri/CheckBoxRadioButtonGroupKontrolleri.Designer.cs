namespace WindowsFomKontrolleri
{
    partial class CheckBoxRadioButtonGroupKontrolleri
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
            this.cb_Kadin = new System.Windows.Forms.RadioButton();
            this.cb_Erkek = new System.Windows.Forms.RadioButton();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_ingilizce = new System.Windows.Forms.CheckBox();
            this.cb_almanca = new System.Windows.Forms.CheckBox();
            this.cb_italyanca = new System.Windows.Forms.CheckBox();
            this.cb_ispanyolca = new System.Windows.Forms.CheckBox();
            this.cb_svahilice = new System.Windows.Forms.CheckBox();
            this.cb_cince = new System.Windows.Forms.CheckBox();
            this.cb_flamenkce = new System.Windows.Forms.CheckBox();
            this.cb_japonca = new System.Windows.Forms.CheckBox();
            this.cb_arapca = new System.Windows.Forms.CheckBox();
            this.cb_korece = new System.Windows.Forms.CheckBox();
            this.lbl_diller = new System.Windows.Forms.Label();
            this.clb_sehirler = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_sehirler = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Kadin
            // 
            this.cb_Kadin.AutoSize = true;
            this.cb_Kadin.Location = new System.Drawing.Point(19, 29);
            this.cb_Kadin.Name = "cb_Kadin";
            this.cb_Kadin.Size = new System.Drawing.Size(52, 17);
            this.cb_Kadin.TabIndex = 0;
            this.cb_Kadin.TabStop = true;
            this.cb_Kadin.Text = "Kadın";
            this.cb_Kadin.UseVisualStyleBackColor = true;
            // 
            // cb_Erkek
            // 
            this.cb_Erkek.AutoSize = true;
            this.cb_Erkek.Location = new System.Drawing.Point(89, 29);
            this.cb_Erkek.Name = "cb_Erkek";
            this.cb_Erkek.Size = new System.Drawing.Size(53, 17);
            this.cb_Erkek.TabIndex = 1;
            this.cb_Erkek.TabStop = true;
            this.cb_Erkek.Text = "Erkek";
            this.cb_Erkek.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(469, 182);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(200, 23);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Location = new System.Drawing.Point(18, 230);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(54, 13);
            this.lbl_secilen.TabIndex = 3;
            this.lbl_secilen.Text = "Seçilen = ";
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(19, 34);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(42, 17);
            this.rb_evli.TabIndex = 4;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(89, 34);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(53, 17);
            this.rb_bekar.TabIndex = 4;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Kadin);
            this.groupBox1.Controls.Add(this.cb_Erkek);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_evli);
            this.groupBox2.Controls.Add(this.rb_bekar);
            this.groupBox2.Location = new System.Drawing.Point(21, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medeni Hal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_korece);
            this.groupBox3.Controls.Add(this.cb_arapca);
            this.groupBox3.Controls.Add(this.cb_japonca);
            this.groupBox3.Controls.Add(this.cb_ispanyolca);
            this.groupBox3.Controls.Add(this.cb_flamenkce);
            this.groupBox3.Controls.Add(this.cb_italyanca);
            this.groupBox3.Controls.Add(this.cb_cince);
            this.groupBox3.Controls.Add(this.cb_almanca);
            this.groupBox3.Controls.Add(this.cb_svahilice);
            this.groupBox3.Controls.Add(this.cb_ingilizce);
            this.groupBox3.Location = new System.Drawing.Point(238, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 153);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilinen Diller";
            // 
            // cb_ingilizce
            // 
            this.cb_ingilizce.AutoSize = true;
            this.cb_ingilizce.Location = new System.Drawing.Point(17, 23);
            this.cb_ingilizce.Name = "cb_ingilizce";
            this.cb_ingilizce.Size = new System.Drawing.Size(63, 17);
            this.cb_ingilizce.TabIndex = 0;
            this.cb_ingilizce.Text = "ingilizce";
            this.cb_ingilizce.UseVisualStyleBackColor = true;
            // 
            // cb_almanca
            // 
            this.cb_almanca.AutoSize = true;
            this.cb_almanca.Location = new System.Drawing.Point(17, 46);
            this.cb_almanca.Name = "cb_almanca";
            this.cb_almanca.Size = new System.Drawing.Size(67, 17);
            this.cb_almanca.TabIndex = 0;
            this.cb_almanca.Text = "Almanca";
            this.cb_almanca.UseVisualStyleBackColor = true;
            // 
            // cb_italyanca
            // 
            this.cb_italyanca.AutoSize = true;
            this.cb_italyanca.Location = new System.Drawing.Point(17, 69);
            this.cb_italyanca.Name = "cb_italyanca";
            this.cb_italyanca.Size = new System.Drawing.Size(69, 17);
            this.cb_italyanca.TabIndex = 0;
            this.cb_italyanca.Text = "İtalyanca";
            this.cb_italyanca.UseVisualStyleBackColor = true;
            // 
            // cb_ispanyolca
            // 
            this.cb_ispanyolca.AutoSize = true;
            this.cb_ispanyolca.Location = new System.Drawing.Point(17, 92);
            this.cb_ispanyolca.Name = "cb_ispanyolca";
            this.cb_ispanyolca.Size = new System.Drawing.Size(77, 17);
            this.cb_ispanyolca.TabIndex = 0;
            this.cb_ispanyolca.Text = "İspanyolca";
            this.cb_ispanyolca.UseVisualStyleBackColor = true;
            // 
            // cb_svahilice
            // 
            this.cb_svahilice.AutoSize = true;
            this.cb_svahilice.Location = new System.Drawing.Point(103, 23);
            this.cb_svahilice.Name = "cb_svahilice";
            this.cb_svahilice.Size = new System.Drawing.Size(69, 17);
            this.cb_svahilice.TabIndex = 0;
            this.cb_svahilice.Text = "Svahilice";
            this.cb_svahilice.UseVisualStyleBackColor = true;
            // 
            // cb_cince
            // 
            this.cb_cince.AutoSize = true;
            this.cb_cince.Location = new System.Drawing.Point(103, 46);
            this.cb_cince.Name = "cb_cince";
            this.cb_cince.Size = new System.Drawing.Size(53, 17);
            this.cb_cince.TabIndex = 0;
            this.cb_cince.Text = "Çince";
            this.cb_cince.UseVisualStyleBackColor = true;
            // 
            // cb_flamenkce
            // 
            this.cb_flamenkce.AutoSize = true;
            this.cb_flamenkce.Location = new System.Drawing.Point(103, 69);
            this.cb_flamenkce.Name = "cb_flamenkce";
            this.cb_flamenkce.Size = new System.Drawing.Size(78, 17);
            this.cb_flamenkce.TabIndex = 0;
            this.cb_flamenkce.Text = "Flemenkçe";
            this.cb_flamenkce.UseVisualStyleBackColor = true;
            // 
            // cb_japonca
            // 
            this.cb_japonca.AutoSize = true;
            this.cb_japonca.Location = new System.Drawing.Point(103, 92);
            this.cb_japonca.Name = "cb_japonca";
            this.cb_japonca.Size = new System.Drawing.Size(67, 17);
            this.cb_japonca.TabIndex = 0;
            this.cb_japonca.Text = "Japonca";
            this.cb_japonca.UseVisualStyleBackColor = true;
            // 
            // cb_arapca
            // 
            this.cb_arapca.AutoSize = true;
            this.cb_arapca.Location = new System.Drawing.Point(17, 115);
            this.cb_arapca.Name = "cb_arapca";
            this.cb_arapca.Size = new System.Drawing.Size(60, 17);
            this.cb_arapca.TabIndex = 0;
            this.cb_arapca.Text = "Arapça";
            this.cb_arapca.UseVisualStyleBackColor = true;
            // 
            // cb_korece
            // 
            this.cb_korece.AutoSize = true;
            this.cb_korece.Location = new System.Drawing.Point(103, 115);
            this.cb_korece.Name = "cb_korece";
            this.cb_korece.Size = new System.Drawing.Size(60, 17);
            this.cb_korece.TabIndex = 0;
            this.cb_korece.Text = "Korece";
            this.cb_korece.UseVisualStyleBackColor = true;
            // 
            // lbl_diller
            // 
            this.lbl_diller.AutoSize = true;
            this.lbl_diller.Location = new System.Drawing.Point(244, 230);
            this.lbl_diller.Name = "lbl_diller";
            this.lbl_diller.Size = new System.Drawing.Size(70, 13);
            this.lbl_diller.TabIndex = 8;
            this.lbl_diller.Text = "Bilinen Diller=";
            // 
            // clb_sehirler
            // 
            this.clb_sehirler.FormattingEnabled = true;
            this.clb_sehirler.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Eskişehir",
            "Adana",
            "Bursa",
            "Bilecik",
            "Kütahya"});
            this.clb_sehirler.Location = new System.Drawing.Point(6, 23);
            this.clb_sehirler.Name = "clb_sehirler";
            this.clb_sehirler.Size = new System.Drawing.Size(190, 109);
            this.clb_sehirler.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clb_sehirler);
            this.groupBox4.Location = new System.Drawing.Point(469, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 153);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şehirler";
            // 
            // lbl_sehirler
            // 
            this.lbl_sehirler.AutoSize = true;
            this.lbl_sehirler.Location = new System.Drawing.Point(466, 230);
            this.lbl_sehirler.Name = "lbl_sehirler";
            this.lbl_sehirler.Size = new System.Drawing.Size(48, 13);
            this.lbl_sehirler.TabIndex = 11;
            this.lbl_sehirler.Text = "Şehirler=";
            // 
            // CheckBoxRadioButtonGroupKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 286);
            this.Controls.Add(this.lbl_sehirler);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_diller);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "CheckBoxRadioButtonGroupKontrolleri";
            this.Text = "CheckBoxRadioButtonGroupKontrolleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cb_Kadin;
        private System.Windows.Forms.RadioButton cb_Erkek;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_japonca;
        private System.Windows.Forms.CheckBox cb_ispanyolca;
        private System.Windows.Forms.CheckBox cb_flamenkce;
        private System.Windows.Forms.CheckBox cb_italyanca;
        private System.Windows.Forms.CheckBox cb_cince;
        private System.Windows.Forms.CheckBox cb_almanca;
        private System.Windows.Forms.CheckBox cb_svahilice;
        private System.Windows.Forms.CheckBox cb_ingilizce;
        private System.Windows.Forms.CheckBox cb_korece;
        private System.Windows.Forms.CheckBox cb_arapca;
        private System.Windows.Forms.Label lbl_diller;
        private System.Windows.Forms.CheckedListBox clb_sehirler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_sehirler;
    }
}