namespace serial_test
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
            this.textBox_com = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_disconnect_weight = new System.Windows.Forms.Button();
            this.button_connect_weight = new System.Windows.Forms.Button();
            this.textBox_com_weight = new System.Windows.Forms.TextBox();
            this.button_read_weight = new System.Windows.Forms.Button();
            this.button_copy_weight = new System.Windows.Forms.Button();
            this.textBox_data_weight = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_com
            // 
            this.textBox_com.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_com.Location = new System.Drawing.Point(6, 19);
            this.textBox_com.Name = "textBox_com";
            this.textBox_com.Size = new System.Drawing.Size(69, 23);
            this.textBox_com.TabIndex = 1;
            this.textBox_com.Text = "COM5";
            this.textBox_com.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.textBox_com);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(6, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.SystemColors.Control;
            this.button_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_connect.FlatAppearance.BorderSize = 0;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_connect.Location = new System.Drawing.Point(6, 48);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(69, 36);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Bağlan";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_copy);
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.textBox_data);
            this.groupBox2.Controls.Add(this.button_read);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metre";
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_copy.Location = new System.Drawing.Point(218, 20);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(70, 37);
            this.button_copy.TabIndex = 3;
            this.button_copy.Text = "Kopyala";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Control;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_reset.Location = new System.Drawing.Point(158, 20);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(54, 36);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.Control;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_save.Location = new System.Drawing.Point(93, 62);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(195, 36);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Kaydet";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_data
            // 
            this.textBox_data.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_data.Location = new System.Drawing.Point(93, 105);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(195, 35);
            this.textBox_data.TabIndex = 1;
            this.textBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_read
            // 
            this.button_read.BackColor = System.Drawing.SystemColors.Control;
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read.Location = new System.Drawing.Point(96, 20);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(56, 36);
            this.button_read.TabIndex = 3;
            this.button_read.Text = "Oku";
            this.button_read.UseVisualStyleBackColor = false;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.0.0.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button_read_weight);
            this.groupBox3.Controls.Add(this.button_copy_weight);
            this.groupBox3.Controls.Add(this.textBox_data_weight);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 169);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ağırlık";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(191, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Rolik Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(93, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_disconnect_weight);
            this.groupBox4.Controls.Add(this.button_connect_weight);
            this.groupBox4.Controls.Add(this.textBox_com_weight);
            this.groupBox4.Location = new System.Drawing.Point(6, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(81, 143);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ayarlar";
            // 
            // button_disconnect_weight
            // 
            this.button_disconnect_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_disconnect_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_disconnect_weight.Location = new System.Drawing.Point(6, 90);
            this.button_disconnect_weight.Name = "button_disconnect_weight";
            this.button_disconnect_weight.Size = new System.Drawing.Size(69, 41);
            this.button_disconnect_weight.TabIndex = 6;
            this.button_disconnect_weight.Text = "Kes";
            this.button_disconnect_weight.UseVisualStyleBackColor = false;
            this.button_disconnect_weight.Click += new System.EventHandler(this.button_disconnect_weight_Click);
            // 
            // button_connect_weight
            // 
            this.button_connect_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_connect_weight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_connect_weight.FlatAppearance.BorderSize = 0;
            this.button_connect_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_connect_weight.Location = new System.Drawing.Point(6, 48);
            this.button_connect_weight.Name = "button_connect_weight";
            this.button_connect_weight.Size = new System.Drawing.Size(69, 36);
            this.button_connect_weight.TabIndex = 5;
            this.button_connect_weight.Text = "Bağlan";
            this.button_connect_weight.UseVisualStyleBackColor = false;
            this.button_connect_weight.Click += new System.EventHandler(this.button_connect_weight_Click);
            // 
            // textBox_com_weight
            // 
            this.textBox_com_weight.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_com_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_com_weight.Location = new System.Drawing.Point(6, 19);
            this.textBox_com_weight.Name = "textBox_com_weight";
            this.textBox_com_weight.Size = new System.Drawing.Size(69, 23);
            this.textBox_com_weight.TabIndex = 4;
            this.textBox_com_weight.Text = "COM5";
            this.textBox_com_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_read_weight
            // 
            this.button_read_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_read_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read_weight.Location = new System.Drawing.Point(93, 19);
            this.button_read_weight.Name = "button_read_weight";
            this.button_read_weight.Size = new System.Drawing.Size(92, 29);
            this.button_read_weight.TabIndex = 4;
            this.button_read_weight.Text = "Oku";
            this.button_read_weight.UseVisualStyleBackColor = false;
            this.button_read_weight.Click += new System.EventHandler(this.button_read_weight_Click);
            // 
            // button_copy_weight
            // 
            this.button_copy_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_copy_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_copy_weight.Location = new System.Drawing.Point(191, 20);
            this.button_copy_weight.Name = "button_copy_weight";
            this.button_copy_weight.Size = new System.Drawing.Size(97, 28);
            this.button_copy_weight.TabIndex = 4;
            this.button_copy_weight.Text = "Kopyala";
            this.button_copy_weight.UseVisualStyleBackColor = false;
            this.button_copy_weight.Click += new System.EventHandler(this.button_copy_weight_Click);
            // 
            // textBox_data_weight
            // 
            this.textBox_data_weight.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_data_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textBox_data_weight.Location = new System.Drawing.Point(93, 111);
            this.textBox_data_weight.Name = "textBox_data_weight";
            this.textBox_data_weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_data_weight.Size = new System.Drawing.Size(195, 33);
            this.textBox_data_weight.TabIndex = 0;
            this.textBox_data_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(312, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 329);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rolik Ağırlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(147, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Ağırlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(318, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Metre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.Text = "SerialReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_com;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_copy_weight;
        private System.Windows.Forms.TextBox textBox_data_weight;
        private System.Windows.Forms.Button button_read_weight;
        private System.Windows.Forms.Button button_disconnect_weight;
        private System.Windows.Forms.Button button_connect_weight;
        private System.Windows.Forms.TextBox textBox_com_weight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

