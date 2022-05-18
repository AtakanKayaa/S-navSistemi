namespace YazılımYapımı
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSoruGorSil = new System.Windows.Forms.Button();
            this.btnSoruGüncelle = new System.Windows.Forms.Button();
            this.btnYeniSoruEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SorularıGorSil1 = new YazılımYapımı.Öğretmen_UC.UC_SorularıGorSil();
            this.uC_SoruGüncelle1 = new YazılımYapımı.Öğretmen_UC.UC_SoruGüncelle();
            this.uC_YeniSoruEkle1 = new YazılımYapımı.Öğretmen_UC.UC_YeniSoruEkle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnSoruGorSil);
            this.panel1.Controls.Add(this.btnSoruGüncelle);
            this.panel1.Controls.Add(this.btnYeniSoruEkle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Turquoise;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(12, 708);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 539);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 61);
            this.button5.TabIndex = 6;
            this.button5.Text = "Çıkış";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSoruGorSil
            // 
            this.btnSoruGorSil.BackColor = System.Drawing.Color.Turquoise;
            this.btnSoruGorSil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoruGorSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruGorSil.Image")));
            this.btnSoruGorSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSoruGorSil.Location = new System.Drawing.Point(12, 440);
            this.btnSoruGorSil.Name = "btnSoruGorSil";
            this.btnSoruGorSil.Size = new System.Drawing.Size(263, 68);
            this.btnSoruGorSil.TabIndex = 4;
            this.btnSoruGorSil.Text = "     Soruları Gör/Sil";
            this.btnSoruGorSil.UseVisualStyleBackColor = false;
            this.btnSoruGorSil.Click += new System.EventHandler(this.btnSoruGorSil_Click);
            // 
            // btnSoruGüncelle
            // 
            this.btnSoruGüncelle.BackColor = System.Drawing.Color.Turquoise;
            this.btnSoruGüncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoruGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruGüncelle.Image")));
            this.btnSoruGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoruGüncelle.Location = new System.Drawing.Point(12, 376);
            this.btnSoruGüncelle.Name = "btnSoruGüncelle";
            this.btnSoruGüncelle.Size = new System.Drawing.Size(263, 45);
            this.btnSoruGüncelle.TabIndex = 3;
            this.btnSoruGüncelle.Text = "Soru Güncelle";
            this.btnSoruGüncelle.UseVisualStyleBackColor = false;
            this.btnSoruGüncelle.Click += new System.EventHandler(this.btnSoruGüncelle_Click);
            // 
            // btnYeniSoruEkle
            // 
            this.btnYeniSoruEkle.BackColor = System.Drawing.Color.Turquoise;
            this.btnYeniSoruEkle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYeniSoruEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniSoruEkle.Image")));
            this.btnYeniSoruEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniSoruEkle.Location = new System.Drawing.Point(12, 310);
            this.btnYeniSoruEkle.Name = "btnYeniSoruEkle";
            this.btnYeniSoruEkle.Size = new System.Drawing.Size(263, 45);
            this.btnYeniSoruEkle.TabIndex = 2;
            this.btnYeniSoruEkle.Text = "Yeni Soru Ekle";
            this.btnYeniSoruEkle.UseVisualStyleBackColor = false;
            this.btnYeniSoruEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğretmen";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.uC_SorularıGorSil1);
            this.panel2.Controls.Add(this.uC_SoruGüncelle1);
            this.panel2.Controls.Add(this.uC_YeniSoruEkle1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 768);
            this.panel2.TabIndex = 1;
            // 
            // uC_SorularıGorSil1
            // 
            this.uC_SorularıGorSil1.BackColor = System.Drawing.Color.White;
            this.uC_SorularıGorSil1.Location = new System.Drawing.Point(0, 0);
            this.uC_SorularıGorSil1.Name = "uC_SorularıGorSil1";
            this.uC_SorularıGorSil1.Size = new System.Drawing.Size(1369, 960);
            this.uC_SorularıGorSil1.TabIndex = 3;
            // 
            // uC_SoruGüncelle1
            // 
            this.uC_SoruGüncelle1.BackColor = System.Drawing.Color.White;
            this.uC_SoruGüncelle1.Location = new System.Drawing.Point(0, 0);
            this.uC_SoruGüncelle1.Name = "uC_SoruGüncelle1";
            this.uC_SoruGüncelle1.Size = new System.Drawing.Size(1369, 960);
            this.uC_SoruGüncelle1.TabIndex = 2;
            // 
            // uC_YeniSoruEkle1
            // 
            this.uC_YeniSoruEkle1.BackColor = System.Drawing.Color.White;
            this.uC_YeniSoruEkle1.Location = new System.Drawing.Point(0, 0);
            this.uC_YeniSoruEkle1.Name = "uC_YeniSoruEkle1";
            this.uC_YeniSoruEkle1.Size = new System.Drawing.Size(1369, 960);
            this.uC_YeniSoruEkle1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
        private Button btnSoruGorSil;
        private Button btnSoruGüncelle;
        private Button btnYeniSoruEkle;
        private Label label1;
        private Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Öğretmen_UC.UC_YeniSoruEkle uC_YeniSoruEkle1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Öğretmen_UC.UC_SoruGüncelle uC_SoruGüncelle1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Öğretmen_UC.UC_SorularıGorSil uC_SorularıGorSil1;
    }
}