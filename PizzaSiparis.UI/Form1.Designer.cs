
namespace PizzaSiparis.UI
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
            this.cmbPizzalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.rdpKucukBoy = new System.Windows.Forms.RadioButton();
            this.rdpOrtaBoy = new System.Windows.Forms.RadioButton();
            this.rdpBuyukBoy = new System.Windows.Forms.RadioButton();
            this.flMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.btnSepeteAt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresBilgisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.Location = new System.Drawing.Point(184, 87);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(238, 24);
            this.cmbPizzalar.TabIndex = 0;
            this.cmbPizzalar.SelectedIndexChanged += new System.EventHandler(this.cmbPizzalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Seçiniz";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(206, 131);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(170, 21);
            this.lblIcerik.TabIndex = 2;
            this.lblIcerik.Text = "Pizzaİçerik Bilgileri : ";
            // 
            // rdpKucukBoy
            // 
            this.rdpKucukBoy.AutoSize = true;
            this.rdpKucukBoy.Location = new System.Drawing.Point(68, 196);
            this.rdpKucukBoy.Name = "rdpKucukBoy";
            this.rdpKucukBoy.Size = new System.Drawing.Size(96, 21);
            this.rdpKucukBoy.TabIndex = 3;
            this.rdpKucukBoy.TabStop = true;
            this.rdpKucukBoy.Text = "Küçük Boy";
            this.rdpKucukBoy.UseVisualStyleBackColor = true;
            // 
            // rdpOrtaBoy
            // 
            this.rdpOrtaBoy.AutoSize = true;
            this.rdpOrtaBoy.Location = new System.Drawing.Point(196, 196);
            this.rdpOrtaBoy.Name = "rdpOrtaBoy";
            this.rdpOrtaBoy.Size = new System.Drawing.Size(81, 21);
            this.rdpOrtaBoy.TabIndex = 3;
            this.rdpOrtaBoy.TabStop = true;
            this.rdpOrtaBoy.Text = "OrtaBoy";
            this.rdpOrtaBoy.UseVisualStyleBackColor = true;
            // 
            // rdpBuyukBoy
            // 
            this.rdpBuyukBoy.AutoSize = true;
            this.rdpBuyukBoy.Location = new System.Drawing.Point(326, 196);
            this.rdpBuyukBoy.Name = "rdpBuyukBoy";
            this.rdpBuyukBoy.Size = new System.Drawing.Size(96, 21);
            this.rdpBuyukBoy.TabIndex = 3;
            this.rdpBuyukBoy.TabStop = true;
            this.rdpBuyukBoy.Text = "Büyük Boy";
            this.rdpBuyukBoy.UseVisualStyleBackColor = true;
            // 
            // flMalzemeler
            // 
            this.flMalzemeler.Location = new System.Drawing.Point(68, 277);
            this.flMalzemeler.Name = "flMalzemeler";
            this.flMalzemeler.Size = new System.Drawing.Size(367, 160);
            this.flMalzemeler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekta Malzeme Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet Giriniz : ";
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(172, 457);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(105, 22);
            this.nmAdet.TabIndex = 7;
            this.nmAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ara Toplam:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(402, 458);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(16, 17);
            this.lblAraToplam.TabIndex = 8;
            this.lblAraToplam.Text = "0";
            // 
            // btnSepeteAt
            // 
            this.btnSepeteAt.Location = new System.Drawing.Point(333, 488);
            this.btnSepeteAt.Name = "btnSepeteAt";
            this.btnSepeteAt.Size = new System.Drawing.Size(102, 48);
            this.btnSepeteAt.TabIndex = 9;
            this.btnSepeteAt.Text = "Sepete Ekle";
            this.btnSepeteAt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdresBilgisi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(511, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 393);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Bilgileri Giriniz ";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(697, 488);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(102, 48);
            this.btnSiparisiTamamla.TabIndex = 9;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(105, 55);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(168, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // txtAdresBilgisi
            // 
            this.txtAdresBilgisi.Location = new System.Drawing.Point(105, 110);
            this.txtAdresBilgisi.Multiline = true;
            this.txtAdresBilgisi.Name = "txtAdresBilgisi";
            this.txtAdresBilgisi.Size = new System.Drawing.Size(177, 194);
            this.txtAdresBilgisi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sipariş Ekranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 658);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSepeteAt);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flMalzemeler);
            this.Controls.Add(this.rdpBuyukBoy);
            this.Controls.Add(this.rdpOrtaBoy);
            this.Controls.Add(this.rdpKucukBoy);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPizzalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPizzalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.RadioButton rdpKucukBoy;
        private System.Windows.Forms.RadioButton rdpOrtaBoy;
        private System.Windows.Forms.RadioButton rdpBuyukBoy;
        private System.Windows.Forms.FlowLayoutPanel flMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Button btnSepeteAt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresBilgisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label7;
    }
}

