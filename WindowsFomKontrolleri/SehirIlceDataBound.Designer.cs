namespace WindowsFomKontrolleri
{
    partial class SehirIlceDataBound
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
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Ilce = new System.Windows.Forms.ComboBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_monitor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // cb_sehir
            // 
            this.cb_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Location = new System.Drawing.Point(132, 43);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(364, 37);
            this.cb_sehir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlçe";
            // 
            // cb_Ilce
            // 
            this.cb_Ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Ilce.FormattingEnabled = true;
            this.cb_Ilce.Location = new System.Drawing.Point(132, 93);
            this.cb_Ilce.Name = "cb_Ilce";
            this.cb_Ilce.Size = new System.Drawing.Size(364, 37);
            this.cb_Ilce.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getir.Location = new System.Drawing.Point(337, 136);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(159, 47);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_monitor
            // 
            this.lbl_monitor.AutoSize = true;
            this.lbl_monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_monitor.Location = new System.Drawing.Point(44, 192);
            this.lbl_monitor.Name = "lbl_monitor";
            this.lbl_monitor.Size = new System.Drawing.Size(0, 29);
            this.lbl_monitor.TabIndex = 3;
            // 
            // SehirIlceDataBound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_monitor);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.cb_Ilce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_sehir);
            this.Controls.Add(this.label1);
            this.Name = "SehirIlceDataBound";
            this.Text = "SehirIlceDataBound";
            this.Load += new System.EventHandler(this.SehirIlceDataBound_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Ilce;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_monitor;
    }
}