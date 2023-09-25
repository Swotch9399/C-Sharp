namespace WindowsFormsApp1
{
    partial class Manav1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manav1));
            this.colorbox = new System.Windows.Forms.GroupBox();
            this.orangebutton = new System.Windows.Forms.Button();
            this.redbutton = new System.Windows.Forms.Button();
            this.yellowbutton = new System.Windows.Forms.Button();
            this.greenbutton = new System.Windows.Forms.Button();
            this.bluebutton = new System.Windows.Forms.Button();
            this.blackbutton = new System.Windows.Forms.Button();
            this.whitebutton = new System.Windows.Forms.Button();
            this.resetbox = new System.Windows.Forms.GroupBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.listaddbutton = new System.Windows.Forms.Button();
            this.listboxselectremovebutton = new System.Windows.Forms.Button();
            this.textboxclearbutton = new System.Windows.Forms.Button();
            this.listboxtextremovebutton = new System.Windows.Forms.Button();
            this.listboxclearbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureboxvisiblebutton = new System.Windows.Forms.Button();
            this.pictureboxnotvisiblebutton = new System.Windows.Forms.Button();
            this.pictureselectbutton1 = new System.Windows.Forms.RadioButton();
            this.pictureselectbutton2 = new System.Windows.Forms.RadioButton();
            this.pictureselectbutton3 = new System.Windows.Forms.RadioButton();
            this.colorbox.SuspendLayout();
            this.resetbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // colorbox
            // 
            this.colorbox.Controls.Add(this.whitebutton);
            this.colorbox.Controls.Add(this.blackbutton);
            this.colorbox.Controls.Add(this.bluebutton);
            this.colorbox.Controls.Add(this.greenbutton);
            this.colorbox.Controls.Add(this.yellowbutton);
            this.colorbox.Controls.Add(this.redbutton);
            this.colorbox.Controls.Add(this.orangebutton);
            this.colorbox.Location = new System.Drawing.Point(12, 338);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(573, 100);
            this.colorbox.TabIndex = 0;
            this.colorbox.TabStop = false;
            this.colorbox.Text = "Renkler";
            this.colorbox.Enter += new System.EventHandler(this.colorbox_Enter);
            // 
            // orangebutton
            // 
            this.orangebutton.BackColor = System.Drawing.Color.DarkOrange;
            this.orangebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orangebutton.Location = new System.Drawing.Point(6, 19);
            this.orangebutton.Name = "orangebutton";
            this.orangebutton.Size = new System.Drawing.Size(75, 71);
            this.orangebutton.TabIndex = 1;
            this.orangebutton.Text = "Turuncu";
            this.orangebutton.UseVisualStyleBackColor = false;
            this.orangebutton.Click += new System.EventHandler(this.orangebutton_Click);
            // 
            // redbutton
            // 
            this.redbutton.BackColor = System.Drawing.Color.Red;
            this.redbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redbutton.Location = new System.Drawing.Point(87, 19);
            this.redbutton.Name = "redbutton";
            this.redbutton.Size = new System.Drawing.Size(75, 71);
            this.redbutton.TabIndex = 2;
            this.redbutton.Text = "Kırmızı";
            this.redbutton.UseVisualStyleBackColor = false;
            this.redbutton.Click += new System.EventHandler(this.redbutton_Click);
            // 
            // yellowbutton
            // 
            this.yellowbutton.BackColor = System.Drawing.Color.Yellow;
            this.yellowbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yellowbutton.Location = new System.Drawing.Point(168, 19);
            this.yellowbutton.Name = "yellowbutton";
            this.yellowbutton.Size = new System.Drawing.Size(75, 71);
            this.yellowbutton.TabIndex = 2;
            this.yellowbutton.Text = "Sarı";
            this.yellowbutton.UseVisualStyleBackColor = false;
            this.yellowbutton.Click += new System.EventHandler(this.yellowbutton_Click);
            // 
            // greenbutton
            // 
            this.greenbutton.BackColor = System.Drawing.Color.Green;
            this.greenbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.greenbutton.Location = new System.Drawing.Point(249, 19);
            this.greenbutton.Name = "greenbutton";
            this.greenbutton.Size = new System.Drawing.Size(75, 71);
            this.greenbutton.TabIndex = 2;
            this.greenbutton.Text = "Yeşil";
            this.greenbutton.UseVisualStyleBackColor = false;
            this.greenbutton.Click += new System.EventHandler(this.greenbutton_Click);
            // 
            // bluebutton
            // 
            this.bluebutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.bluebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bluebutton.Location = new System.Drawing.Point(330, 19);
            this.bluebutton.Name = "bluebutton";
            this.bluebutton.Size = new System.Drawing.Size(75, 71);
            this.bluebutton.TabIndex = 2;
            this.bluebutton.Text = "Mavi";
            this.bluebutton.UseVisualStyleBackColor = false;
            this.bluebutton.Click += new System.EventHandler(this.bluebutton_Click);
            // 
            // blackbutton
            // 
            this.blackbutton.BackColor = System.Drawing.Color.Black;
            this.blackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blackbutton.ForeColor = System.Drawing.Color.White;
            this.blackbutton.Location = new System.Drawing.Point(411, 19);
            this.blackbutton.Name = "blackbutton";
            this.blackbutton.Size = new System.Drawing.Size(75, 71);
            this.blackbutton.TabIndex = 2;
            this.blackbutton.Text = "Siyah";
            this.blackbutton.UseVisualStyleBackColor = false;
            this.blackbutton.Click += new System.EventHandler(this.blackbutton_Click);
            // 
            // whitebutton
            // 
            this.whitebutton.BackColor = System.Drawing.Color.White;
            this.whitebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.whitebutton.Location = new System.Drawing.Point(492, 19);
            this.whitebutton.Name = "whitebutton";
            this.whitebutton.Size = new System.Drawing.Size(75, 71);
            this.whitebutton.TabIndex = 3;
            this.whitebutton.Text = "Beyaz";
            this.whitebutton.UseVisualStyleBackColor = false;
            this.whitebutton.Click += new System.EventHandler(this.whitebutton_Click);
            // 
            // resetbox
            // 
            this.resetbox.Controls.Add(this.resetbutton);
            this.resetbox.Location = new System.Drawing.Point(591, 338);
            this.resetbox.Name = "resetbox";
            this.resetbox.Size = new System.Drawing.Size(197, 100);
            this.resetbox.TabIndex = 1;
            this.resetbox.TabStop = false;
            this.resetbox.Text = "Sıfırla";
            this.resetbox.Enter += new System.EventHandler(this.resetbox_Enter);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.OrangeRed;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetbutton.Location = new System.Drawing.Point(6, 19);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(185, 75);
            this.resetbutton.TabIndex = 2;
            this.resetbutton.Text = "Sıfırla";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 41);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(289, 173);
            this.listbox.TabIndex = 2;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(12, 15);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(289, 20);
            this.textbox.TabIndex = 3;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // listaddbutton
            // 
            this.listaddbutton.Location = new System.Drawing.Point(307, 15);
            this.listaddbutton.Name = "listaddbutton";
            this.listaddbutton.Size = new System.Drawing.Size(110, 23);
            this.listaddbutton.TabIndex = 4;
            this.listaddbutton.Text = "Sepete Ekle";
            this.listaddbutton.UseVisualStyleBackColor = true;
            this.listaddbutton.Click += new System.EventHandler(this.listaddbutton_Click);
            // 
            // listboxselectremovebutton
            // 
            this.listboxselectremovebutton.Location = new System.Drawing.Point(307, 162);
            this.listboxselectremovebutton.Name = "listboxselectremovebutton";
            this.listboxselectremovebutton.Size = new System.Drawing.Size(110, 23);
            this.listboxselectremovebutton.TabIndex = 5;
            this.listboxselectremovebutton.Text = "Seçilenleri Temizle";
            this.listboxselectremovebutton.UseVisualStyleBackColor = true;
            this.listboxselectremovebutton.Click += new System.EventHandler(this.listboxselectremovebutton_Click);
            // 
            // textboxclearbutton
            // 
            this.textboxclearbutton.Location = new System.Drawing.Point(307, 44);
            this.textboxclearbutton.Name = "textboxclearbutton";
            this.textboxclearbutton.Size = new System.Drawing.Size(110, 23);
            this.textboxclearbutton.TabIndex = 6;
            this.textboxclearbutton.Text = "Kelimeleri Temizle";
            this.textboxclearbutton.UseVisualStyleBackColor = true;
            this.textboxclearbutton.Click += new System.EventHandler(this.textboxclearbutton_Click);
            // 
            // listboxtextremovebutton
            // 
            this.listboxtextremovebutton.Location = new System.Drawing.Point(307, 133);
            this.listboxtextremovebutton.Name = "listboxtextremovebutton";
            this.listboxtextremovebutton.Size = new System.Drawing.Size(110, 23);
            this.listboxtextremovebutton.TabIndex = 7;
            this.listboxtextremovebutton.Text = "Yazılanı Temizle";
            this.listboxtextremovebutton.UseVisualStyleBackColor = true;
            this.listboxtextremovebutton.Click += new System.EventHandler(this.listboxtextremovebutton_Click);
            // 
            // listboxclearbutton
            // 
            this.listboxclearbutton.Location = new System.Drawing.Point(307, 191);
            this.listboxclearbutton.Name = "listboxclearbutton";
            this.listboxclearbutton.Size = new System.Drawing.Size(110, 23);
            this.listboxclearbutton.TabIndex = 9;
            this.listboxclearbutton.Text = "Sepeti Temizle";
            this.listboxclearbutton.UseVisualStyleBackColor = true;
            this.listboxclearbutton.Click += new System.EventHandler(this.listboxclearbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(423, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 199);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(423, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 199);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(423, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 199);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureboxvisiblebutton
            // 
            this.pictureboxvisiblebutton.Location = new System.Drawing.Point(423, 220);
            this.pictureboxvisiblebutton.Name = "pictureboxvisiblebutton";
            this.pictureboxvisiblebutton.Size = new System.Drawing.Size(85, 23);
            this.pictureboxvisiblebutton.TabIndex = 13;
            this.pictureboxvisiblebutton.Text = "Resmi Göster";
            this.pictureboxvisiblebutton.UseVisualStyleBackColor = true;
            this.pictureboxvisiblebutton.Click += new System.EventHandler(this.pictureboxvisiblebutton_Click);
            // 
            // pictureboxnotvisiblebutton
            // 
            this.pictureboxnotvisiblebutton.Location = new System.Drawing.Point(703, 220);
            this.pictureboxnotvisiblebutton.Name = "pictureboxnotvisiblebutton";
            this.pictureboxnotvisiblebutton.Size = new System.Drawing.Size(85, 23);
            this.pictureboxnotvisiblebutton.TabIndex = 14;
            this.pictureboxnotvisiblebutton.Text = "Resmi Sakla";
            this.pictureboxnotvisiblebutton.UseVisualStyleBackColor = true;
            this.pictureboxnotvisiblebutton.Click += new System.EventHandler(this.pictureboxnotvisiblebutton_Click);
            // 
            // pictureselectbutton1
            // 
            this.pictureselectbutton1.AutoSize = true;
            this.pictureselectbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pictureselectbutton1.Location = new System.Drawing.Point(547, 226);
            this.pictureselectbutton1.Name = "pictureselectbutton1";
            this.pictureselectbutton1.Size = new System.Drawing.Size(32, 17);
            this.pictureselectbutton1.TabIndex = 15;
            this.pictureselectbutton1.TabStop = true;
            this.pictureselectbutton1.Text = "1";
            this.pictureselectbutton1.UseVisualStyleBackColor = true;
            this.pictureselectbutton1.CheckedChanged += new System.EventHandler(this.pictureselectbutton1_CheckedChanged);
            // 
            // pictureselectbutton2
            // 
            this.pictureselectbutton2.AutoSize = true;
            this.pictureselectbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pictureselectbutton2.Location = new System.Drawing.Point(585, 226);
            this.pictureselectbutton2.Name = "pictureselectbutton2";
            this.pictureselectbutton2.Size = new System.Drawing.Size(32, 17);
            this.pictureselectbutton2.TabIndex = 16;
            this.pictureselectbutton2.TabStop = true;
            this.pictureselectbutton2.Text = "2";
            this.pictureselectbutton2.UseVisualStyleBackColor = true;
            this.pictureselectbutton2.CheckedChanged += new System.EventHandler(this.pictureselectbutton2_CheckedChanged);
            // 
            // pictureselectbutton3
            // 
            this.pictureselectbutton3.AutoSize = true;
            this.pictureselectbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pictureselectbutton3.Location = new System.Drawing.Point(623, 226);
            this.pictureselectbutton3.Name = "pictureselectbutton3";
            this.pictureselectbutton3.Size = new System.Drawing.Size(32, 17);
            this.pictureselectbutton3.TabIndex = 17;
            this.pictureselectbutton3.TabStop = true;
            this.pictureselectbutton3.Text = "3";
            this.pictureselectbutton3.UseVisualStyleBackColor = true;
            this.pictureselectbutton3.CheckedChanged += new System.EventHandler(this.pictureselectbutton3_CheckedChanged);
            // 
            // Manav1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureselectbutton3);
            this.Controls.Add(this.pictureselectbutton2);
            this.Controls.Add(this.pictureselectbutton1);
            this.Controls.Add(this.pictureboxnotvisiblebutton);
            this.Controls.Add(this.pictureboxvisiblebutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listboxclearbutton);
            this.Controls.Add(this.listboxtextremovebutton);
            this.Controls.Add(this.textboxclearbutton);
            this.Controls.Add(this.listboxselectremovebutton);
            this.Controls.Add(this.listaddbutton);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.resetbox);
            this.Controls.Add(this.colorbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manav1";
            this.Text = "Manav";
            this.Load += new System.EventHandler(this.Manav1_Load);
            this.colorbox.ResumeLayout(false);
            this.resetbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colorbox;
        private System.Windows.Forms.Button whitebutton;
        private System.Windows.Forms.Button blackbutton;
        private System.Windows.Forms.Button bluebutton;
        private System.Windows.Forms.Button greenbutton;
        private System.Windows.Forms.Button yellowbutton;
        private System.Windows.Forms.Button redbutton;
        private System.Windows.Forms.Button orangebutton;
        private System.Windows.Forms.GroupBox resetbox;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button listaddbutton;
        private System.Windows.Forms.Button listboxselectremovebutton;
        private System.Windows.Forms.Button textboxclearbutton;
        private System.Windows.Forms.Button listboxtextremovebutton;
        private System.Windows.Forms.Button listboxclearbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button pictureboxvisiblebutton;
        private System.Windows.Forms.Button pictureboxnotvisiblebutton;
        private System.Windows.Forms.RadioButton pictureselectbutton1;
        private System.Windows.Forms.RadioButton pictureselectbutton2;
        private System.Windows.Forms.RadioButton pictureselectbutton3;
    }
}

