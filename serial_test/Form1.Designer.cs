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
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_read_weight = new System.Windows.Forms.Button();
            this.button_copy_weight = new System.Windows.Forms.Button();
            this.textBox_data_weight = new System.Windows.Forms.TextBox();
            this.button_disconnect_weight = new System.Windows.Forms.Button();
            this.button_connect_weight = new System.Windows.Forms.Button();
            this.textBox_com_weight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_com
            // 
            this.textBox_com.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_com.Location = new System.Drawing.Point(6, 19);
            this.textBox_com.Name = "textBox_com";
            this.textBox_com.Size = new System.Drawing.Size(100, 38);
            this.textBox_com.TabIndex = 1;
            this.textBox_com.Text = "COM5";
            this.textBox_com.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.textBox_com);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
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
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_connect.Location = new System.Drawing.Point(7, 63);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(99, 36);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Bağlan";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_data);
            this.groupBox2.Controls.Add(this.button_copy);
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_read);
            this.groupBox2.Location = new System.Drawing.Point(131, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metre";
            // 
            // textBox_data
            // 
            this.textBox_data.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_data.Location = new System.Drawing.Point(6, 19);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(273, 38);
            this.textBox_data.TabIndex = 1;
            this.textBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_copy.Location = new System.Drawing.Point(285, 19);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(139, 129);
            this.button_copy.TabIndex = 3;
            this.button_copy.Text = "Kopyala";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Control;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reset.Location = new System.Drawing.Point(143, 63);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(136, 85);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_read
            // 
            this.button_read.BackColor = System.Drawing.SystemColors.Control;
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_read.Location = new System.Drawing.Point(6, 63);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(131, 85);
            this.button_read.TabIndex = 3;
            this.button_read.Text = "Oku";
            this.button_read.UseVisualStyleBackColor = false;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.0.0.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_read_weight);
            this.groupBox3.Controls.Add(this.button_copy_weight);
            this.groupBox3.Controls.Add(this.textBox_data_weight);
            this.groupBox3.Location = new System.Drawing.Point(131, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 169);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ağırlık";
            // 
            // button_read_weight
            // 
            this.button_read_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_read_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_read_weight.Location = new System.Drawing.Point(6, 61);
            this.button_read_weight.Name = "button_read_weight";
            this.button_read_weight.Size = new System.Drawing.Size(273, 100);
            this.button_read_weight.TabIndex = 4;
            this.button_read_weight.Text = "Oku";
            this.button_read_weight.UseVisualStyleBackColor = false;
            this.button_read_weight.Click += new System.EventHandler(this.button_read_weight_Click);
            // 
            // button_copy_weight
            // 
            this.button_copy_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_copy_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_copy_weight.Location = new System.Drawing.Point(285, 19);
            this.button_copy_weight.Name = "button_copy_weight";
            this.button_copy_weight.Size = new System.Drawing.Size(139, 144);
            this.button_copy_weight.TabIndex = 4;
            this.button_copy_weight.Text = "Kopyala";
            this.button_copy_weight.UseVisualStyleBackColor = false;
            this.button_copy_weight.Click += new System.EventHandler(this.button_copy_weight_Click);
            // 
            // textBox_data_weight
            // 
            this.textBox_data_weight.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_data_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data_weight.Location = new System.Drawing.Point(6, 19);
            this.textBox_data_weight.Name = "textBox_data_weight";
            this.textBox_data_weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_data_weight.Size = new System.Drawing.Size(273, 38);
            this.textBox_data_weight.TabIndex = 0;
            this.textBox_data_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_disconnect_weight
            // 
            this.button_disconnect_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_disconnect_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_disconnect_weight.Location = new System.Drawing.Point(9, 125);
            this.button_disconnect_weight.Name = "button_disconnect_weight";
            this.button_disconnect_weight.Size = new System.Drawing.Size(99, 36);
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
            this.button_connect_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_connect_weight.Location = new System.Drawing.Point(9, 61);
            this.button_connect_weight.Name = "button_connect_weight";
            this.button_connect_weight.Size = new System.Drawing.Size(99, 58);
            this.button_connect_weight.TabIndex = 5;
            this.button_connect_weight.Text = "Bağlan";
            this.button_connect_weight.UseVisualStyleBackColor = false;
            this.button_connect_weight.Click += new System.EventHandler(this.button_connect_weight_Click);
            // 
            // textBox_com_weight
            // 
            this.textBox_com_weight.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_com_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_com_weight.Location = new System.Drawing.Point(8, 19);
            this.textBox_com_weight.Name = "textBox_com_weight";
            this.textBox_com_weight.Size = new System.Drawing.Size(100, 38);
            this.textBox_com_weight.TabIndex = 4;
            this.textBox_com_weight.Text = "COM5";
            this.textBox_com_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_disconnect_weight);
            this.groupBox4.Controls.Add(this.button_connect_weight);
            this.groupBox4.Controls.Add(this.textBox_com_weight);
            this.groupBox4.Location = new System.Drawing.Point(12, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 167);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ayarlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 361);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
    }
}

