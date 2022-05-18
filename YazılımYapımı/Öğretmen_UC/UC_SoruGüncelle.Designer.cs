namespace YazılımYapımı.Öğretmen_UC
{
    partial class UC_SoruGüncelle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SoruGüncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboUnite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboSoruNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnSifirla = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soruları Güncelle";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünite";
            // 
            // comboUnite
            // 
            this.comboUnite.BackColor = System.Drawing.Color.Transparent;
            this.comboUnite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboUnite.ForeColor = System.Drawing.Color.Black;
            this.comboUnite.ItemHeight = 30;
            this.comboUnite.Location = new System.Drawing.Point(147, 177);
            this.comboUnite.Name = "comboUnite";
            this.comboUnite.Size = new System.Drawing.Size(340, 36);
            this.comboUnite.TabIndex = 2;
            this.comboUnite.SelectedIndexChanged += new System.EventHandler(this.comboUnite_SelectedIndexChanged);
            // 
            // comboSoruNo
            // 
            this.comboSoruNo.BackColor = System.Drawing.Color.Transparent;
            this.comboSoruNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSoruNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoruNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoruNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoruNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSoruNo.ForeColor = System.Drawing.Color.Black;
            this.comboSoruNo.ItemHeight = 30;
            this.comboSoruNo.Location = new System.Drawing.Point(587, 177);
            this.comboSoruNo.Name = "comboSoruNo";
            this.comboSoruNo.Size = new System.Drawing.Size(340, 36);
            this.comboSoruNo.TabIndex = 4;
            this.comboSoruNo.SelectedIndexChanged += new System.EventHandler(this.comboSoruNo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(587, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soru no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(500, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soru:";
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoru.Location = new System.Drawing.Point(147, 288);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(780, 38);
            this.txtSoru.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(147, 409);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(340, 38);
            this.txtA.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "A şıkkı:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(608, 409);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(340, 38);
            this.txtB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(608, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "B şıkkı:";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(608, 552);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(340, 38);
            this.txtD.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(608, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "D şıkkı:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(147, 552);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(340, 38);
            this.txtC.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(147, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "C şıkkı:";
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevap.Location = new System.Drawing.Point(147, 654);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(780, 38);
            this.txtCevap.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(500, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cevap:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderRadius = 18;
            this.btnGuncelle.BorderThickness = 1;
            this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(262, 709);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(225, 56);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BorderRadius = 18;
            this.btnSifirla.BorderThickness = 1;
            this.btnSifirla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifirla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifirla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifirla.Location = new System.Drawing.Point(546, 709);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(225, 56);
            this.btnSifirla.TabIndex = 18;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // UC_SoruGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboUnite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(152, 177);
            this.Name = "UC_SoruGüncelle";
            this.Size = new System.Drawing.Size(1095, 768);
            this.Load += new System.EventHandler(this.UC_SoruGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private TextBox txtSoru;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboSoruNo;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboUnite;
        private TextBox txtB;
        private Label label6;
        private TextBox txtA;
        private Label label5;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSifirla;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private TextBox txtCevap;
        private Label label9;
        private TextBox txtD;
        private Label label7;
        private TextBox txtC;
        private Label label8;
    }
}
