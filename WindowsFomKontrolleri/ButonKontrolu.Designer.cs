namespace WindowsFomKontrolleri
{
    partial class ButonKontrolu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButonKontrolu));
            this.btn_tikla = new System.Windows.Forms.Button();
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tikla
            // 
            this.btn_tikla.Location = new System.Drawing.Point(25, 38);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(75, 23);
            this.btn_tikla.TabIndex = 0;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Location = new System.Drawing.Point(106, 43);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(35, 13);
            this.lbl_mesaj.TabIndex = 1;
            this.lbl_mesaj.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 234);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ButonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.btn_tikla);
            this.Name = "ButonKontrolu";
            this.Text = "ButonKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Label label1;
    }
}