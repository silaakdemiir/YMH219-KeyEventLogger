namespace YMH219_KeyEventLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBaslat = new Button();
            btnDurdur = new Button();
            btnTemizle = new Button();
            btnKaydet = new Button();
            lstKayitlar = new ListBox();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(56, 52);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(233, 52);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(94, 29);
            btnDurdur.TabIndex = 1;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(420, 52);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(605, 52);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lstKayitlar
            // 
            lstKayitlar.FormattingEnabled = true;
            lstKayitlar.Location = new Point(56, 139);
            lstKayitlar.Name = "lstKayitlar";
            lstKayitlar.Size = new Size(643, 104);
            lstKayitlar.TabIndex = 4;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(310, 293);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(96, 20);
            lblDurum.TabIndex = 5;
            lblDurum.Text = "Kayıt: KAPALI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(lstKayitlar);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Button btnDurdur;
        private Button btnTemizle;
        private Button btnKaydet;
        private ListBox lstKayitlar;
        private Label lblDurum;
    }
}
