namespace Project.WinUI
{
    partial class Form2
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
            this.grbMusteri = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtMusteriAdresi = new System.Windows.Forms.TextBox();
            this.txtMusTelNo = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.grbOdalar = new System.Windows.Forms.GroupBox();
            this.btn102 = new System.Windows.Forms.Button();
            this.btn202 = new System.Windows.Forms.Button();
            this.btn201 = new System.Windows.Forms.Button();
            this.btn303 = new System.Windows.Forms.Button();
            this.btn302 = new System.Windows.Forms.Button();
            this.btn203 = new System.Windows.Forms.Button();
            this.btn301 = new System.Windows.Forms.Button();
            this.btn103 = new System.Windows.Forms.Button();
            this.btn101 = new System.Windows.Forms.Button();
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoStandart = new System.Windows.Forms.RadioButton();
            this.rdoSuit = new System.Windows.Forms.RadioButton();
            this.rdoKing = new System.Windows.Forms.RadioButton();
            this.btnZiyaretciListesi = new System.Windows.Forms.Button();
            this.grbMusteri.SuspendLayout();
            this.grbOdalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMusteri
            // 
            this.grbMusteri.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grbMusteri.Controls.Add(this.btnMusteriEkle);
            this.grbMusteri.Controls.Add(this.label8);
            this.grbMusteri.Controls.Add(this.label7);
            this.grbMusteri.Controls.Add(this.label1);
            this.grbMusteri.Controls.Add(this.label6);
            this.grbMusteri.Controls.Add(this.label5);
            this.grbMusteri.Controls.Add(this.txtTCNo);
            this.grbMusteri.Controls.Add(this.txtMusteriAdresi);
            this.grbMusteri.Controls.Add(this.txtMusTelNo);
            this.grbMusteri.Controls.Add(this.txtMusteriSoyadi);
            this.grbMusteri.Controls.Add(this.txtMusteriAdi);
            this.grbMusteri.Location = new System.Drawing.Point(704, 12);
            this.grbMusteri.Name = "grbMusteri";
            this.grbMusteri.Size = new System.Drawing.Size(404, 206);
            this.grbMusteri.TabIndex = 5;
            this.grbMusteri.TabStop = false;
            this.grbMusteri.Text = "Müşteri Bilgileri";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMusteriEkle.Location = new System.Drawing.Point(200, 150);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(100, 41);
            this.btnMusteriEkle.TabIndex = 2;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Müşteri Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "TC Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşterinin Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "İletişim Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müşteri Adı";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(199, 106);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 22);
            this.txtTCNo.TabIndex = 0;
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.Location = new System.Drawing.Point(25, 169);
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Size = new System.Drawing.Size(106, 22);
            this.txtMusteriAdresi.TabIndex = 0;
            // 
            // txtMusTelNo
            // 
            this.txtMusTelNo.Location = new System.Drawing.Point(28, 106);
            this.txtMusTelNo.Name = "txtMusTelNo";
            this.txtMusTelNo.Size = new System.Drawing.Size(106, 22);
            this.txtMusTelNo.TabIndex = 0;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(199, 49);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriSoyadi.TabIndex = 0;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(25, 49);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(106, 22);
            this.txtMusteriAdi.TabIndex = 0;
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.Location = new System.Drawing.Point(45, 170);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(97, 24);
            this.btnOdaAra.TabIndex = 6;
            this.btnOdaAra.Text = "Oda Ara";
            this.btnOdaAra.UseVisualStyleBackColor = true;
            this.btnOdaAra.Click += new System.EventHandler(this.btnOdaAra_Click);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(139, 78);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 22);
            this.dtp2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check Out  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Check In  =";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(139, 37);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 8;
            // 
            // grbOdalar
            // 
            this.grbOdalar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbOdalar.Controls.Add(this.btn102);
            this.grbOdalar.Controls.Add(this.btn202);
            this.grbOdalar.Controls.Add(this.btn201);
            this.grbOdalar.Controls.Add(this.btn303);
            this.grbOdalar.Controls.Add(this.btn302);
            this.grbOdalar.Controls.Add(this.btn203);
            this.grbOdalar.Controls.Add(this.btn301);
            this.grbOdalar.Controls.Add(this.btn103);
            this.grbOdalar.Controls.Add(this.btn101);
            this.grbOdalar.Location = new System.Drawing.Point(45, 209);
            this.grbOdalar.Name = "grbOdalar";
            this.grbOdalar.Size = new System.Drawing.Size(391, 227);
            this.grbOdalar.TabIndex = 9;
            this.grbOdalar.TabStop = false;
            this.grbOdalar.Text = "Odalar";
            // 
            // btn102
            // 
            this.btn102.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn102.Location = new System.Drawing.Point(164, 21);
            this.btn102.Name = "btn102";
            this.btn102.Size = new System.Drawing.Size(73, 32);
            this.btn102.TabIndex = 3;
            this.btn102.Text = "102";
            this.btn102.UseVisualStyleBackColor = true;
            // 
            // btn202
            // 
            this.btn202.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn202.Location = new System.Drawing.Point(164, 77);
            this.btn202.Name = "btn202";
            this.btn202.Size = new System.Drawing.Size(73, 32);
            this.btn202.TabIndex = 3;
            this.btn202.Text = "202";
            this.btn202.UseVisualStyleBackColor = true;
            // 
            // btn201
            // 
            this.btn201.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn201.Location = new System.Drawing.Point(51, 77);
            this.btn201.Name = "btn201";
            this.btn201.Size = new System.Drawing.Size(75, 32);
            this.btn201.TabIndex = 3;
            this.btn201.Text = "201";
            this.btn201.UseVisualStyleBackColor = true;
            // 
            // btn303
            // 
            this.btn303.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn303.Location = new System.Drawing.Point(284, 131);
            this.btn303.Name = "btn303";
            this.btn303.Size = new System.Drawing.Size(76, 32);
            this.btn303.TabIndex = 3;
            this.btn303.Text = "303";
            this.btn303.UseVisualStyleBackColor = true;
            // 
            // btn302
            // 
            this.btn302.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn302.Location = new System.Drawing.Point(164, 131);
            this.btn302.Name = "btn302";
            this.btn302.Size = new System.Drawing.Size(73, 32);
            this.btn302.TabIndex = 3;
            this.btn302.Text = "302";
            this.btn302.UseVisualStyleBackColor = true;
            // 
            // btn203
            // 
            this.btn203.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn203.Location = new System.Drawing.Point(284, 77);
            this.btn203.Name = "btn203";
            this.btn203.Size = new System.Drawing.Size(76, 32);
            this.btn203.TabIndex = 3;
            this.btn203.Text = "203";
            this.btn203.UseVisualStyleBackColor = true;
            // 
            // btn301
            // 
            this.btn301.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn301.Location = new System.Drawing.Point(51, 131);
            this.btn301.Name = "btn301";
            this.btn301.Size = new System.Drawing.Size(75, 32);
            this.btn301.TabIndex = 3;
            this.btn301.Text = "301";
            this.btn301.UseVisualStyleBackColor = true;
            // 
            // btn103
            // 
            this.btn103.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn103.Location = new System.Drawing.Point(284, 21);
            this.btn103.Name = "btn103";
            this.btn103.Size = new System.Drawing.Size(76, 32);
            this.btn103.TabIndex = 3;
            this.btn103.Text = "103";
            this.btn103.UseVisualStyleBackColor = true;
            // 
            // btn101
            // 
            this.btn101.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn101.Location = new System.Drawing.Point(51, 21);
            this.btn101.Name = "btn101";
            this.btn101.Size = new System.Drawing.Size(75, 32);
            this.btn101.TabIndex = 3;
            this.btn101.Text = "101";
            this.btn101.UseVisualStyleBackColor = true;
            // 
            // btnRezervasyonEkle
            // 
            this.btnRezervasyonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(464, 181);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(177, 37);
            this.btnRezervasyonEkle.TabIndex = 2;
            this.btnRezervasyonEkle.Text = "Rezervasyon Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = false;
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 16;
            this.lstMusteriler.Location = new System.Drawing.Point(704, 224);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(404, 212);
            this.lstMusteriler.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oda Tipleri";
            // 
            // rdoStandart
            // 
            this.rdoStandart.AutoSize = true;
            this.rdoStandart.Checked = true;
            this.rdoStandart.Location = new System.Drawing.Point(48, 144);
            this.rdoStandart.Name = "rdoStandart";
            this.rdoStandart.Size = new System.Drawing.Size(81, 20);
            this.rdoStandart.TabIndex = 3;
            this.rdoStandart.TabStop = true;
            this.rdoStandart.Text = "Standart ";
            this.rdoStandart.UseVisualStyleBackColor = true;
            // 
            // rdoSuit
            // 
            this.rdoSuit.AutoSize = true;
            this.rdoSuit.Location = new System.Drawing.Point(177, 144);
            this.rdoSuit.Name = "rdoSuit";
            this.rdoSuit.Size = new System.Drawing.Size(50, 20);
            this.rdoSuit.TabIndex = 3;
            this.rdoSuit.Text = "Suit";
            this.rdoSuit.UseVisualStyleBackColor = true;
            // 
            // rdoKing
            // 
            this.rdoKing.AutoSize = true;
            this.rdoKing.Location = new System.Drawing.Point(300, 144);
            this.rdoKing.Name = "rdoKing";
            this.rdoKing.Size = new System.Drawing.Size(54, 20);
            this.rdoKing.TabIndex = 3;
            this.rdoKing.Text = "King";
            this.rdoKing.UseVisualStyleBackColor = true;
            // 
            // btnZiyaretciListesi
            // 
            this.btnZiyaretciListesi.BackColor = System.Drawing.Color.Salmon;
            this.btnZiyaretciListesi.Location = new System.Drawing.Point(464, 245);
            this.btnZiyaretciListesi.Name = "btnZiyaretciListesi";
            this.btnZiyaretciListesi.Size = new System.Drawing.Size(177, 37);
            this.btnZiyaretciListesi.TabIndex = 2;
            this.btnZiyaretciListesi.Text = "Misafir Ekle";
            this.btnZiyaretciListesi.UseVisualStyleBackColor = false;
            this.btnZiyaretciListesi.Click += new System.EventHandler(this.btnZiyaretciListesi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 457);
            this.Controls.Add(this.rdoKing);
            this.Controls.Add(this.rdoSuit);
            this.Controls.Add(this.rdoStandart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.grbMusteri);
            this.Controls.Add(this.btnOdaAra);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnZiyaretciListesi);
            this.Controls.Add(this.btnRezervasyonEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.grbOdalar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbMusteri.ResumeLayout(false);
            this.grbMusteri.PerformLayout();
            this.grbOdalar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbMusteri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtMusTelNo;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Button btnOdaAra;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.GroupBox grbOdalar;
        private System.Windows.Forms.Button btn102;
        private System.Windows.Forms.Button btn202;
        private System.Windows.Forms.Button btn201;
        private System.Windows.Forms.Button btn303;
        private System.Windows.Forms.Button btn302;
        private System.Windows.Forms.Button btn203;
        private System.Windows.Forms.Button btn301;
        private System.Windows.Forms.Button btn103;
        private System.Windows.Forms.Button btn101;
        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAdresi;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoStandart;
        private System.Windows.Forms.RadioButton rdoSuit;
        private System.Windows.Forms.RadioButton rdoKing;
        private System.Windows.Forms.Button btnZiyaretciListesi;
    }
}