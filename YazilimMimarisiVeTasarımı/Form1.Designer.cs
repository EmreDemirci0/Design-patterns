
namespace YazilimMimarisiVeTasarımı
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
            this.btn_Onaylama = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_CikisTarihiYönetici = new System.Windows.Forms.DateTimePicker();
            this.Dtp_GirisTarihiYönetici = new System.Windows.Forms.DateTimePicker();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.cmb_konaklama = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_ulasim = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_nereden = new System.Windows.Forms.ComboBox();
            this.cmb_nereye = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Onaylama
            // 
            this.btn_Onaylama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Onaylama.Location = new System.Drawing.Point(56, 485);
            this.btn_Onaylama.Name = "btn_Onaylama";
            this.btn_Onaylama.Size = new System.Drawing.Size(534, 61);
            this.btn_Onaylama.TabIndex = 0;
            this.btn_Onaylama.Text = "Rezervasyon Onayla";
            this.btn_Onaylama.UseVisualStyleBackColor = true;
            this.btn_Onaylama.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 70);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hoşgeldiniz ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(390, 305);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(200, 20);
            this.txt_adres.TabIndex = 4;
            // 
            // txt_telNo
            // 
            this.txt_telNo.Location = new System.Drawing.Point(390, 271);
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(200, 20);
            this.txt_telNo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(284, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = " adresi :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(390, 203);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(200, 20);
            this.txt_ad.TabIndex = 1;
            this.txt_ad.TextChanged += new System.EventHandler(this.txtrezyapmaAdi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(194, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefon Numaranız : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(288, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Adınız :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(46, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Çıkış Tarihini Belirleyiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(50, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Giriş Tarihini Belirleyiniz:";
            // 
            // Dtp_CikisTarihiYönetici
            // 
            this.Dtp_CikisTarihiYönetici.Location = new System.Drawing.Point(390, 433);
            this.Dtp_CikisTarihiYönetici.Name = "Dtp_CikisTarihiYönetici";
            this.Dtp_CikisTarihiYönetici.Size = new System.Drawing.Size(200, 20);
            this.Dtp_CikisTarihiYönetici.TabIndex = 7;
            // 
            // Dtp_GirisTarihiYönetici
            // 
            this.Dtp_GirisTarihiYönetici.Location = new System.Drawing.Point(390, 385);
            this.Dtp_GirisTarihiYönetici.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Dtp_GirisTarihiYönetici.Name = "Dtp_GirisTarihiYönetici";
            this.Dtp_GirisTarihiYönetici.Size = new System.Drawing.Size(200, 20);
            this.Dtp_GirisTarihiYönetici.TabIndex = 7;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(390, 339);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(200, 20);
            this.txt_tc.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(194, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tc Kimlik No Giriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(287, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Soyadı:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(390, 237);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(200, 20);
            this.txt_soyad.TabIndex = 2;
            // 
            // cmb_konaklama
            // 
            this.cmb_konaklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_konaklama.FormattingEnabled = true;
            this.cmb_konaklama.Items.AddRange(new object[] {
            "Çadır",
            "Otel"});
            this.cmb_konaklama.Location = new System.Drawing.Point(240, 122);
            this.cmb_konaklama.Name = "cmb_konaklama";
            this.cmb_konaklama.Size = new System.Drawing.Size(121, 21);
            this.cmb_konaklama.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(7, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Konaklama Tipini Seçiniz:";
            // 
            // cmb_ulasim
            // 
            this.cmb_ulasim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ulasim.FormattingEnabled = true;
            this.cmb_ulasim.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cmb_ulasim.Location = new System.Drawing.Point(240, 81);
            this.cmb_ulasim.Name = "cmb_ulasim";
            this.cmb_ulasim.Size = new System.Drawing.Size(121, 21);
            this.cmb_ulasim.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(37, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Ulaşım Tipini Seçiniz:";
            // 
            // cmb_nereden
            // 
            this.cmb_nereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nereden.FormattingEnabled = true;
            this.cmb_nereden.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "Bursa",
            "İnegöl",
            "İzmit",
            "Adana",
            "Kırıkkale"});
            this.cmb_nereden.Location = new System.Drawing.Point(547, 79);
            this.cmb_nereden.Name = "cmb_nereden";
            this.cmb_nereden.Size = new System.Drawing.Size(121, 21);
            this.cmb_nereden.TabIndex = 42;
            // 
            // cmb_nereye
            // 
            this.cmb_nereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nereye.FormattingEnabled = true;
            this.cmb_nereye.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "Bursa",
            "İnegöl",
            "İzmit",
            "Adana",
            "Kırıkkale"});
            this.cmb_nereye.Location = new System.Drawing.Point(547, 120);
            this.cmb_nereye.Name = "cmb_nereye";
            this.cmb_nereye.Size = new System.Drawing.Size(121, 21);
            this.cmb_nereye.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(443, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "nereden:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(454, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "nereye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 579);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_nereye);
            this.Controls.Add(this.cmb_konaklama);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_nereden);
            this.Controls.Add(this.cmb_ulasim);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_CikisTarihiYönetici);
            this.Controls.Add(this.Dtp_GirisTarihiYönetici);
            this.Controls.Add(this.btn_Onaylama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Onaylama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_telNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_CikisTarihiYönetici;
        private System.Windows.Forms.DateTimePicker Dtp_GirisTarihiYönetici;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.ComboBox cmb_konaklama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_ulasim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_nereden;
        private System.Windows.Forms.ComboBox cmb_nereye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

