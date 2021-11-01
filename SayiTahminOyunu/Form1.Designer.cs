
namespace SayiTahminOyunu
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
            this.components = new System.ComponentModel.Container();
            this.gbx_tahmin = new System.Windows.Forms.GroupBox();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_durumMetin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_tahmin = new System.Windows.Forms.TextBox();
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.gbx_geriSayim = new System.Windows.Forms.GroupBox();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.gbx_sonuclar = new System.Windows.Forms.GroupBox();
            this.lbl_yanlistahmin = new System.Windows.Forms.Label();
            this.lbl_dogruTahmin = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbx_tahmin.SuspendLayout();
            this.gbx_geriSayim.SuspendLayout();
            this.gbx_sonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_tahmin
            // 
            this.gbx_tahmin.Controls.Add(this.lbl_durum);
            this.gbx_tahmin.Controls.Add(this.lbl_durumMetin);
            this.gbx_tahmin.Controls.Add(this.label1);
            this.gbx_tahmin.Controls.Add(this.tbx_tahmin);
            this.gbx_tahmin.Controls.Add(this.btn_tahmin);
            this.gbx_tahmin.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_tahmin.Location = new System.Drawing.Point(12, 12);
            this.gbx_tahmin.Name = "gbx_tahmin";
            this.gbx_tahmin.Size = new System.Drawing.Size(249, 196);
            this.gbx_tahmin.TabIndex = 0;
            this.gbx_tahmin.TabStop = false;
            this.gbx_tahmin.Text = "Tahmin";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_durum.Location = new System.Drawing.Point(81, 161);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(72, 26);
            this.lbl_durum.TabIndex = 3;
            this.lbl_durum.Text = "Yukarı";
            // 
            // lbl_durumMetin
            // 
            this.lbl_durumMetin.AutoSize = true;
            this.lbl_durumMetin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durumMetin.Location = new System.Drawing.Point(16, 164);
            this.lbl_durumMetin.Name = "lbl_durumMetin";
            this.lbl_durumMetin.Size = new System.Drawing.Size(70, 19);
            this.lbl_durumMetin.TabIndex = 2;
            this.lbl_durumMetin.Text = "Durum : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "0-20 Arasında Bir Sayı Giriniz!";
            // 
            // tbx_tahmin
            // 
            this.tbx_tahmin.Location = new System.Drawing.Point(20, 88);
            this.tbx_tahmin.Name = "tbx_tahmin";
            this.tbx_tahmin.Size = new System.Drawing.Size(117, 24);
            this.tbx_tahmin.TabIndex = 0;
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.Location = new System.Drawing.Point(143, 84);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(91, 31);
            this.btn_tahmin.TabIndex = 1;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = true;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // gbx_geriSayim
            // 
            this.gbx_geriSayim.Controls.Add(this.lbl_saniye);
            this.gbx_geriSayim.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_geriSayim.Location = new System.Drawing.Point(267, 12);
            this.gbx_geriSayim.Name = "gbx_geriSayim";
            this.gbx_geriSayim.Size = new System.Drawing.Size(165, 110);
            this.gbx_geriSayim.TabIndex = 2;
            this.gbx_geriSayim.TabStop = false;
            this.gbx_geriSayim.Text = "Geri Sayım";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saniye.Location = new System.Drawing.Point(32, 33);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(99, 58);
            this.lbl_saniye.TabIndex = 4;
            this.lbl_saniye.Text = "20";
            this.lbl_saniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbx_sonuclar
            // 
            this.gbx_sonuclar.Controls.Add(this.lbl_yanlistahmin);
            this.gbx_sonuclar.Controls.Add(this.lbl_dogruTahmin);
            this.gbx_sonuclar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_sonuclar.Location = new System.Drawing.Point(267, 128);
            this.gbx_sonuclar.Name = "gbx_sonuclar";
            this.gbx_sonuclar.Size = new System.Drawing.Size(165, 80);
            this.gbx_sonuclar.TabIndex = 3;
            this.gbx_sonuclar.TabStop = false;
            this.gbx_sonuclar.Text = "Sonuçlar";
            // 
            // lbl_yanlistahmin
            // 
            this.lbl_yanlistahmin.AutoSize = true;
            this.lbl_yanlistahmin.Font = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yanlistahmin.ForeColor = System.Drawing.Color.Red;
            this.lbl_yanlistahmin.Location = new System.Drawing.Point(9, 45);
            this.lbl_yanlistahmin.Name = "lbl_yanlistahmin";
            this.lbl_yanlistahmin.Size = new System.Drawing.Size(93, 16);
            this.lbl_yanlistahmin.TabIndex = 5;
            this.lbl_yanlistahmin.Text = "Yanlış Tahmin : ";
            // 
            // lbl_dogruTahmin
            // 
            this.lbl_dogruTahmin.AutoSize = true;
            this.lbl_dogruTahmin.Font = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dogruTahmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_dogruTahmin.Location = new System.Drawing.Point(6, 25);
            this.lbl_dogruTahmin.Name = "lbl_dogruTahmin";
            this.lbl_dogruTahmin.Size = new System.Drawing.Size(94, 16);
            this.lbl_dogruTahmin.TabIndex = 4;
            this.lbl_dogruTahmin.Text = "Doğru Tahmin : ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 214);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_tahmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 245);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbx_sonuclar);
            this.Controls.Add(this.gbx_geriSayim);
            this.Controls.Add(this.gbx_tahmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_tahmin.ResumeLayout(false);
            this.gbx_tahmin.PerformLayout();
            this.gbx_geriSayim.ResumeLayout(false);
            this.gbx_sonuclar.ResumeLayout(false);
            this.gbx_sonuclar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_tahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_tahmin;
        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.GroupBox gbx_geriSayim;
        private System.Windows.Forms.GroupBox gbx_sonuclar;
        private System.Windows.Forms.Label lbl_durumMetin;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label lbl_yanlistahmin;
        private System.Windows.Forms.Label lbl_dogruTahmin;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

