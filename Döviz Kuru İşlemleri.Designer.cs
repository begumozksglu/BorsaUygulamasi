
namespace ÖDEV
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DolarAlisText = new System.Windows.Forms.Label();
            this.DolarSatisText = new System.Windows.Forms.Label();
            this.EuroSatisText = new System.Windows.Forms.Label();
            this.EuroAlisText = new System.Windows.Forms.Label();
            this.btndolarAlis = new System.Windows.Forms.Button();
            this.btndolarSatis = new System.Windows.Forms.Button();
            this.btneuroSatis = new System.Windows.Forms.Button();
            this.btneuroAlis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBozdur = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Euro Satış :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Euro Alış :";
            // 
            // DolarAlisText
            // 
            this.DolarAlisText.BackColor = System.Drawing.Color.Transparent;
            this.DolarAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DolarAlisText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DolarAlisText.Location = new System.Drawing.Point(180, 119);
            this.DolarAlisText.Name = "DolarAlisText";
            this.DolarAlisText.Size = new System.Drawing.Size(118, 33);
            this.DolarAlisText.TabIndex = 4;
            // 
            // DolarSatisText
            // 
            this.DolarSatisText.BackColor = System.Drawing.Color.Transparent;
            this.DolarSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DolarSatisText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DolarSatisText.Location = new System.Drawing.Point(180, 184);
            this.DolarSatisText.Name = "DolarSatisText";
            this.DolarSatisText.Size = new System.Drawing.Size(118, 33);
            this.DolarSatisText.TabIndex = 5;
            // 
            // EuroSatisText
            // 
            this.EuroSatisText.BackColor = System.Drawing.Color.Transparent;
            this.EuroSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EuroSatisText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EuroSatisText.Location = new System.Drawing.Point(180, 316);
            this.EuroSatisText.Name = "EuroSatisText";
            this.EuroSatisText.Size = new System.Drawing.Size(118, 33);
            this.EuroSatisText.TabIndex = 7;
            // 
            // EuroAlisText
            // 
            this.EuroAlisText.BackColor = System.Drawing.Color.Transparent;
            this.EuroAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EuroAlisText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EuroAlisText.Location = new System.Drawing.Point(180, 247);
            this.EuroAlisText.Name = "EuroAlisText";
            this.EuroAlisText.Size = new System.Drawing.Size(118, 33);
            this.EuroAlisText.TabIndex = 6;
            // 
            // btndolarAlis
            // 
            this.btndolarAlis.Location = new System.Drawing.Point(328, 119);
            this.btndolarAlis.Name = "btndolarAlis";
            this.btndolarAlis.Size = new System.Drawing.Size(54, 28);
            this.btndolarAlis.TabIndex = 8;
            this.btndolarAlis.Text = ".....";
            this.btndolarAlis.UseVisualStyleBackColor = true;
            this.btndolarAlis.Click += new System.EventHandler(this.btndolarAlis_Click);
            // 
            // btndolarSatis
            // 
            this.btndolarSatis.Location = new System.Drawing.Point(328, 187);
            this.btndolarSatis.Name = "btndolarSatis";
            this.btndolarSatis.Size = new System.Drawing.Size(54, 28);
            this.btndolarSatis.TabIndex = 9;
            this.btndolarSatis.Text = ".....";
            this.btndolarSatis.UseVisualStyleBackColor = true;
            this.btndolarSatis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btneuroSatis
            // 
            this.btneuroSatis.Location = new System.Drawing.Point(328, 316);
            this.btneuroSatis.Name = "btneuroSatis";
            this.btneuroSatis.Size = new System.Drawing.Size(54, 28);
            this.btneuroSatis.TabIndex = 11;
            this.btneuroSatis.Text = ".....";
            this.btneuroSatis.UseVisualStyleBackColor = true;
            this.btneuroSatis.Click += new System.EventHandler(this.btneuroSatis_Click);
            // 
            // btneuroAlis
            // 
            this.btneuroAlis.Location = new System.Drawing.Point(328, 247);
            this.btneuroAlis.Name = "btneuroAlis";
            this.btneuroAlis.Size = new System.Drawing.Size(54, 28);
            this.btneuroAlis.TabIndex = 10;
            this.btneuroAlis.Text = ".....";
            this.btneuroAlis.UseVisualStyleBackColor = true;
            this.btneuroAlis.Click += new System.EventHandler(this.btneuroAlis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBozdur);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(414, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 389);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Döviz İşlemler";
            // 
            // btnBozdur
            // 
            this.btnBozdur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBozdur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBozdur.Location = new System.Drawing.Point(190, 317);
            this.btnBozdur.Name = "btnBozdur";
            this.btnBozdur.Size = new System.Drawing.Size(159, 46);
            this.btnBozdur.TabIndex = 13;
            this.btnBozdur.Text = "Bozdur";
            this.btnBozdur.UseVisualStyleBackColor = false;
            this.btnBozdur.Click += new System.EventHandler(this.btnBozdur_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHesapla.Location = new System.Drawing.Point(25, 317);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(159, 46);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(122, 108);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(227, 30);
            this.txtMiktar.TabIndex = 11;
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(122, 243);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(227, 30);
            this.txtKalan.TabIndex = 10;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(122, 175);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(227, 30);
            this.txtTutar.TabIndex = 9;
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(122, 42);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(227, 30);
            this.txtKur.TabIndex = 8;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kalan :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tutar :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Miktar :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 33);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kur :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneuroSatis);
            this.Controls.Add(this.btneuroAlis);
            this.Controls.Add(this.btndolarSatis);
            this.Controls.Add(this.btndolarAlis);
            this.Controls.Add(this.EuroSatisText);
            this.Controls.Add(this.EuroAlisText);
            this.Controls.Add(this.DolarSatisText);
            this.Controls.Add(this.DolarAlisText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Döviz Kuru İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DolarAlisText;
        private System.Windows.Forms.Label DolarSatisText;
        private System.Windows.Forms.Label EuroSatisText;
        private System.Windows.Forms.Label EuroAlisText;
        private System.Windows.Forms.Button btndolarAlis;
        private System.Windows.Forms.Button btndolarSatis;
        private System.Windows.Forms.Button btneuroSatis;
        private System.Windows.Forms.Button btneuroAlis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBozdur;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

