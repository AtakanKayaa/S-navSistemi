namespace YazılımYapımı.Öğretmen_UC
{
    partial class UC_YeniSoruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_YeniSoruEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoruLabel = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNOSET = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜNİTE";
            // 
            // txtUnite
            // 
            this.txtUnite.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnite.Location = new System.Drawing.Point(115, 157);
            this.txtUnite.Name = "txtUnite";
            this.txtUnite.Size = new System.Drawing.Size(427, 47);
            this.txtUnite.TabIndex = 2;
            this.txtUnite.TextChanged += new System.EventHandler(this.txtUnite_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(792, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soru No:";
            // 
            // SoruLabel
            // 
            this.SoruLabel.AutoSize = true;
            this.SoruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoruLabel.ForeColor = System.Drawing.Color.Red;
            this.SoruLabel.Location = new System.Drawing.Point(821, 95);
            this.SoruLabel.Name = "SoruLabel";
            this.SoruLabel.Size = new System.Drawing.Size(39, 29);
            this.SoruLabel.TabIndex = 4;
            this.SoruLabel.Text = "11";
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoru.Location = new System.Drawing.Point(115, 290);
            this.txtSoru.MaxLength = 327677589;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(427, 47);
            this.txtSoru.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(112, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soru";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(115, 384);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(427, 47);
            this.txtA.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "A şıkkı";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(115, 476);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(427, 47);
            this.txtB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(115, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "B şıkkı";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(115, 592);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(427, 47);
            this.txtC.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(115, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "C şıkkı";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(115, 699);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(427, 47);
            this.txtD.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(115, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "D şıkkı";
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCevap.Location = new System.Drawing.Point(619, 592);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(427, 47);
            this.txtCevap.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(619, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cevap";
            // 
            // labelNOSET
            // 
            this.labelNOSET.AutoSize = true;
            this.labelNOSET.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNOSET.ForeColor = System.Drawing.Color.Red;
            this.labelNOSET.Location = new System.Drawing.Point(168, 207);
            this.labelNOSET.Name = "labelNOSET";
            this.labelNOSET.Size = new System.Drawing.Size(307, 29);
            this.labelNOSET.TabIndex = 17;
            this.labelNOSET.Text = "Böyle bir Ünite bulunamadı.";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSonraki.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.Image = ((System.Drawing.Image)(resources.GetObject("btnSonraki.Image")));
            this.btnSonraki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSonraki.Location = new System.Drawing.Point(619, 663);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(205, 49);
            this.btnSonraki.TabIndex = 18;
            this.btnSonraki.Text = "SONRAKİ";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSıfırla.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSıfırla.Image = ((System.Drawing.Image)(resources.GetObject("btnSıfırla.Image")));
            this.btnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSıfırla.Location = new System.Drawing.Point(841, 663);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(205, 49);
            this.btnSıfırla.TabIndex = 19;
            this.btnSıfırla.Text = "SIFIRLA";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitir.Location = new System.Drawing.Point(619, 719);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(427, 49);
            this.btnBitir.TabIndex = 20;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1090, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(978, 336);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UC_YeniSoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.labelNOSET);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoruLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_YeniSoruEkle";
            this.Size = new System.Drawing.Size(1095, 768);
            this.Load += new System.EventHandler(this.UC_YeniSoruEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUnite;
        private Label label3;
        private Label SoruLabel;
        private TextBox txtSoru;
        private Label label5;
        private TextBox txtA;
        private Label label6;
        private TextBox txtB;
        private Label label7;
        private TextBox txtC;
        private Label label8;
        private TextBox txtD;
        private Label label9;
        private TextBox txtCevap;
        private Label label10;
        private Label labelNOSET;
        private Button btnSonraki;
        private Button btnSıfırla;
        private Button btnBitir;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private DataGridView dataGridView1;
    }
}
