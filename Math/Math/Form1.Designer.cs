namespace Math
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
            this.sayi_label = new System.Windows.Forms.Label();
            this.sayi_textBox = new System.Windows.Forms.TextBox();
            this.yuzde_label = new System.Windows.Forms.Label();
            this.yuzde_textBox = new System.Windows.Forms.TextBox();
            this.hesapla_button = new System.Windows.Forms.Button();
            this.sonuc_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayi_label
            // 
            this.sayi_label.AutoSize = true;
            this.sayi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi_label.Location = new System.Drawing.Point(12, 9);
            this.sayi_label.Name = "sayi_label";
            this.sayi_label.Size = new System.Drawing.Size(67, 24);
            this.sayi_label.TabIndex = 0;
            this.sayi_label.Text = "Sayı =";
            this.sayi_label.Click += new System.EventHandler(this.sayi_label_Click);
            // 
            // sayi_textBox
            // 
            this.sayi_textBox.Location = new System.Drawing.Point(85, 14);
            this.sayi_textBox.Name = "sayi_textBox";
            this.sayi_textBox.Size = new System.Drawing.Size(116, 20);
            this.sayi_textBox.TabIndex = 1;
            this.sayi_textBox.TextChanged += new System.EventHandler(this.sayi_textBox_TextChanged);
            // 
            // yuzde_label
            // 
            this.yuzde_label.AutoSize = true;
            this.yuzde_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzde_label.Location = new System.Drawing.Point(12, 59);
            this.yuzde_label.Name = "yuzde_label";
            this.yuzde_label.Size = new System.Drawing.Size(123, 24);
            this.yuzde_label.TabIndex = 2;
            this.yuzde_label.Text = "Yüzde (%) =";
            this.yuzde_label.Click += new System.EventHandler(this.yuzde_label_Click);
            // 
            // yuzde_textBox
            // 
            this.yuzde_textBox.Location = new System.Drawing.Point(141, 64);
            this.yuzde_textBox.Name = "yuzde_textBox";
            this.yuzde_textBox.Size = new System.Drawing.Size(116, 20);
            this.yuzde_textBox.TabIndex = 3;
            this.yuzde_textBox.TextChanged += new System.EventHandler(this.yuzde_textBox_TextChanged);
            // 
            // hesapla_button
            // 
            this.hesapla_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla_button.Location = new System.Drawing.Point(85, 106);
            this.hesapla_button.Name = "hesapla_button";
            this.hesapla_button.Size = new System.Drawing.Size(111, 61);
            this.hesapla_button.TabIndex = 4;
            this.hesapla_button.Text = "HESAPLA";
            this.hesapla_button.UseVisualStyleBackColor = true;
            this.hesapla_button.Click += new System.EventHandler(this.hesapla_button_Click);
            // 
            // sonuc_label
            // 
            this.sonuc_label.AutoSize = true;
            this.sonuc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc_label.Location = new System.Drawing.Point(12, 182);
            this.sonuc_label.Name = "sonuc_label";
            this.sonuc_label.Size = new System.Drawing.Size(135, 24);
            this.sonuc_label.TabIndex = 5;
            this.sonuc_label.Text = "Sonuç = NaN";
            this.sonuc_label.Click += new System.EventHandler(this.sonuc_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 220);
            this.Controls.Add(this.sonuc_label);
            this.Controls.Add(this.hesapla_button);
            this.Controls.Add(this.yuzde_textBox);
            this.Controls.Add(this.yuzde_label);
            this.Controls.Add(this.sayi_textBox);
            this.Controls.Add(this.sayi_label);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Yüzde Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayi_label;
        private System.Windows.Forms.TextBox sayi_textBox;
        private System.Windows.Forms.Label yuzde_label;
        private System.Windows.Forms.TextBox yuzde_textBox;
        private System.Windows.Forms.Button hesapla_button;
        private System.Windows.Forms.Label sonuc_label;
    }
}

