namespace Homework_Anket_2
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
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.AtaAdı = new System.Windows.Forms.TextBox();
            this.Ölkə = new System.Windows.Forms.TextBox();
            this.Şəhər = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.DoğumTarixi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cins = new System.Windows.Forms.Label();
            this.Kişi = new System.Windows.Forms.RadioButton();
            this.Qadın = new System.Windows.Forms.RadioButton();
            this.YaddaşdaSaxla = new System.Windows.Forms.Button();
            this.Yüklə = new System.Windows.Forms.Button();
            this.AnketorAdı = new System.Windows.Forms.TextBox();
            this.AnketorAdıLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(136, 79);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(198, 20);
            this.Ad.TabIndex = 0;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(136, 105);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(198, 20);
            this.Soyad.TabIndex = 1;
            // 
            // AtaAdı
            // 
            this.AtaAdı.Location = new System.Drawing.Point(136, 131);
            this.AtaAdı.Name = "AtaAdı";
            this.AtaAdı.Size = new System.Drawing.Size(198, 20);
            this.AtaAdı.TabIndex = 2;
            // 
            // Ölkə
            // 
            this.Ölkə.Location = new System.Drawing.Point(136, 204);
            this.Ölkə.Name = "Ölkə";
            this.Ölkə.Size = new System.Drawing.Size(198, 20);
            this.Ölkə.TabIndex = 3;
            // 
            // Şəhər
            // 
            this.Şəhər.Location = new System.Drawing.Point(136, 230);
            this.Şəhər.Name = "Şəhər";
            this.Şəhər.Size = new System.Drawing.Size(198, 20);
            this.Şəhər.TabIndex = 4;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(136, 256);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(198, 20);
            this.Telefon.TabIndex = 5;
            // 
            // DoğumTarixi
            // 
            this.DoğumTarixi.Location = new System.Drawing.Point(136, 330);
            this.DoğumTarixi.Name = "DoğumTarixi";
            this.DoğumTarixi.Size = new System.Drawing.Size(198, 20);
            this.DoğumTarixi.TabIndex = 6;
            this.DoğumTarixi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ata adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ölkə:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şəhər:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doğum tarixi:";
            // 
            // Cins
            // 
            this.Cins.AutoSize = true;
            this.Cins.Location = new System.Drawing.Point(12, 383);
            this.Cins.Name = "Cins";
            this.Cins.Size = new System.Drawing.Size(30, 13);
            this.Cins.TabIndex = 17;
            this.Cins.Text = "Cins:";
            // 
            // Kişi
            // 
            this.Kişi.AutoSize = true;
            this.Kişi.Location = new System.Drawing.Point(175, 381);
            this.Kişi.Name = "Kişi";
            this.Kişi.Size = new System.Drawing.Size(41, 17);
            this.Kişi.TabIndex = 18;
            this.Kişi.TabStop = true;
            this.Kişi.Text = "Kişi";
            this.Kişi.UseVisualStyleBackColor = true;
            // 
            // Qadın
            // 
            this.Qadın.AutoSize = true;
            this.Qadın.Location = new System.Drawing.Point(249, 381);
            this.Qadın.Name = "Qadın";
            this.Qadın.Size = new System.Drawing.Size(53, 17);
            this.Qadın.TabIndex = 19;
            this.Qadın.TabStop = true;
            this.Qadın.Text = "Qadın";
            this.Qadın.UseVisualStyleBackColor = true;
            this.Qadın.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // YaddaşdaSaxla
            // 
            this.YaddaşdaSaxla.Location = new System.Drawing.Point(15, 415);
            this.YaddaşdaSaxla.Name = "YaddaşdaSaxla";
            this.YaddaşdaSaxla.Size = new System.Drawing.Size(319, 23);
            this.YaddaşdaSaxla.TabIndex = 20;
            this.YaddaşdaSaxla.Text = "Yaddaşda saxla";
            this.YaddaşdaSaxla.UseVisualStyleBackColor = true;
            this.YaddaşdaSaxla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yüklə
            // 
            this.Yüklə.Location = new System.Drawing.Point(249, 28);
            this.Yüklə.Name = "Yüklə";
            this.Yüklə.Size = new System.Drawing.Size(85, 22);
            this.Yüklə.TabIndex = 21;
            this.Yüklə.Text = "Yüklə";
            this.Yüklə.UseVisualStyleBackColor = true;
            this.Yüklə.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnketorAdı
            // 
            this.AnketorAdı.Location = new System.Drawing.Point(136, 28);
            this.AnketorAdı.Name = "AnketorAdı";
            this.AnketorAdı.Size = new System.Drawing.Size(107, 20);
            this.AnketorAdı.TabIndex = 22;
            this.AnketorAdı.TextChanged += new System.EventHandler(this.AnketorAdı_TextChanged);
            // 
            // AnketorAdıLabel
            // 
            this.AnketorAdıLabel.AutoSize = true;
            this.AnketorAdıLabel.Location = new System.Drawing.Point(12, 31);
            this.AnketorAdıLabel.Name = "AnketorAdıLabel";
            this.AnketorAdıLabel.Size = new System.Drawing.Size(64, 13);
            this.AnketorAdıLabel.TabIndex = 23;
            this.AnketorAdıLabel.Text = "Anketor adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.AnketorAdıLabel);
            this.Controls.Add(this.AnketorAdı);
            this.Controls.Add(this.Yüklə);
            this.Controls.Add(this.YaddaşdaSaxla);
            this.Controls.Add(this.Qadın);
            this.Controls.Add(this.Kişi);
            this.Controls.Add(this.Cins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoğumTarixi);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Şəhər);
            this.Controls.Add(this.Ölkə);
            this.Controls.Add(this.AtaAdı);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Name = "Form1";
            this.Text = "Anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox AtaAdı;
        private System.Windows.Forms.TextBox Ölkə;
        private System.Windows.Forms.TextBox Şəhər;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.DateTimePicker DoğumTarixi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Cins;
        private System.Windows.Forms.RadioButton Kişi;
        private System.Windows.Forms.RadioButton Qadın;
        private System.Windows.Forms.Button YaddaşdaSaxla;
        private System.Windows.Forms.Button Yüklə;
        private System.Windows.Forms.TextBox AnketorAdı;
        private System.Windows.Forms.Label AnketorAdıLabel;
    }
}

