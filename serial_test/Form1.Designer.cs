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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_com = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_rolik = new System.Windows.Forms.Button();
            this.button_weight = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_disconnect_weight = new System.Windows.Forms.Button();
            this.button_connect_weight = new System.Windows.Forms.Button();
            this.textBox_com_weight = new System.Windows.Forms.TextBox();
            this.textBox_data_weight = new System.Windows.Forms.TextBox();
            this.button_read_weight = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_net_weight = new System.Windows.Forms.TextBox();
            this.button_meter_copy = new System.Windows.Forms.Button();
            this.button_net_weight_copy = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_unitg = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_meter = new System.Windows.Forms.TextBox();
            this.textBox_totalw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_rolik = new System.Windows.Forms.TextBox();
            this.label_meter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_commget = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_zaman = new System.Windows.Forms.Label();
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
            this.textBox_com.Text = "COM2";
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
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.textBox_data);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button_read);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metre";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Control;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_reset.Location = new System.Drawing.Point(231, 104);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(54, 36);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Sıfırla";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.Control;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_save.Location = new System.Drawing.Point(93, 59);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(195, 36);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Metre Kaydet";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_data
            // 
            this.textBox_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.textBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_data.ForeColor = System.Drawing.Color.White;
            this.textBox_data.Location = new System.Drawing.Point(93, 20);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(195, 35);
            this.textBox_data.TabIndex = 1;
            this.textBox_data.Text = "METRE";
            this.textBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_data.TextChanged += new System.EventHandler(this.textBox_data_TextChanged);
            // 
            // button_read
            // 
            this.button_read.BackColor = System.Drawing.SystemColors.Control;
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read.Location = new System.Drawing.Point(93, 104);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(132, 36);
            this.button_read.TabIndex = 3;
            this.button_read.Text = "Oku";
            this.button_read.UseVisualStyleBackColor = false;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.0.0.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_rolik);
            this.groupBox3.Controls.Add(this.button_weight);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBox_data_weight);
            this.groupBox3.Controls.Add(this.button_read_weight);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 185);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ağırlık";
            // 
            // button_rolik
            // 
            this.button_rolik.BackColor = System.Drawing.SystemColors.Control;
            this.button_rolik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_rolik.Location = new System.Drawing.Point(93, 58);
            this.button_rolik.Name = "button_rolik";
            this.button_rolik.Size = new System.Drawing.Size(195, 43);
            this.button_rolik.TabIndex = 5;
            this.button_rolik.Text = "Rolik Kaydet";
            this.button_rolik.UseVisualStyleBackColor = false;
            this.button_rolik.Click += new System.EventHandler(this.button_rolik_Click);
            // 
            // button_weight
            // 
            this.button_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_weight.Location = new System.Drawing.Point(93, 107);
            this.button_weight.Name = "button_weight";
            this.button_weight.Size = new System.Drawing.Size(195, 37);
            this.button_weight.TabIndex = 5;
            this.button_weight.Text = "Ağırlık Kaydet";
            this.button_weight.UseVisualStyleBackColor = false;
            this.button_weight.Click += new System.EventHandler(this.button_weight_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_disconnect_weight);
            this.groupBox4.Controls.Add(this.button_connect_weight);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox_com_weight);
            this.groupBox4.Location = new System.Drawing.Point(6, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(81, 166);
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
            this.textBox_com_weight.Text = "COM3";
            this.textBox_com_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_data_weight
            // 
            this.textBox_data_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.textBox_data_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.textBox_data_weight.ForeColor = System.Drawing.Color.White;
            this.textBox_data_weight.Location = new System.Drawing.Point(93, 19);
            this.textBox_data_weight.Name = "textBox_data_weight";
            this.textBox_data_weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_data_weight.Size = new System.Drawing.Size(195, 33);
            this.textBox_data_weight.TabIndex = 0;
            this.textBox_data_weight.Text = "AĞIRLIK";
            this.textBox_data_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_read_weight
            // 
            this.button_read_weight.BackColor = System.Drawing.SystemColors.Control;
            this.button_read_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read_weight.Location = new System.Drawing.Point(93, 147);
            this.button_read_weight.Name = "button_read_weight";
            this.button_read_weight.Size = new System.Drawing.Size(195, 29);
            this.button_read_weight.TabIndex = 4;
            this.button_read_weight.Text = "Oku";
            this.button_read_weight.UseVisualStyleBackColor = false;
            this.button_read_weight.Click += new System.EventHandler(this.button_read_weight_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_zaman);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox_net_weight);
            this.groupBox5.Controls.Add(this.button_meter_copy);
            this.groupBox5.Controls.Add(this.button_net_weight_copy);
            this.groupBox5.Controls.Add(this.button_clear);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.textBox_unitg);
            this.groupBox5.Controls.Add(this.textBox_result);
            this.groupBox5.Controls.Add(this.textBox_meter);
            this.groupBox5.Controls.Add(this.textBox_totalw);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox_rolik);
            this.groupBox5.Controls.Add(this.label_meter);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(312, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 345);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bilgiler";
            // 
            // textBox_net_weight
            // 
            this.textBox_net_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_net_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_net_weight.Location = new System.Drawing.Point(133, 94);
            this.textBox_net_weight.Name = "textBox_net_weight";
            this.textBox_net_weight.Size = new System.Drawing.Size(100, 16);
            this.textBox_net_weight.TabIndex = 9;
            this.textBox_net_weight.Text = "0";
            this.textBox_net_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_net_weight.TextChanged += new System.EventHandler(this.textBox_net_weight_TextChanged);
            // 
            // button_meter_copy
            // 
            this.button_meter_copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_meter_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button_meter_copy.Location = new System.Drawing.Point(184, 201);
            this.button_meter_copy.Name = "button_meter_copy";
            this.button_meter_copy.Size = new System.Drawing.Size(178, 80);
            this.button_meter_copy.TabIndex = 8;
            this.button_meter_copy.Text = "Metre Kopyala";
            this.button_meter_copy.UseVisualStyleBackColor = false;
            this.button_meter_copy.Click += new System.EventHandler(this.button_meter_copy_Click);
            // 
            // button_net_weight_copy
            // 
            this.button_net_weight_copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_net_weight_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button_net_weight_copy.Location = new System.Drawing.Point(184, 116);
            this.button_net_weight_copy.Name = "button_net_weight_copy";
            this.button_net_weight_copy.Size = new System.Drawing.Size(178, 79);
            this.button_net_weight_copy.TabIndex = 7;
            this.button_net_weight_copy.Text = "Net Ağırlık Kopyala";
            this.button_net_weight_copy.UseVisualStyleBackColor = false;
            this.button_net_weight_copy.Click += new System.EventHandler(this.button_net_weight_copy_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Control;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_clear.Location = new System.Drawing.Point(6, 284);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(172, 55);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Temizle";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(6, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 165);
            this.button5.TabIndex = 5;
            this.button5.Text = "Hesapla";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox_unitg
            // 
            this.textBox_unitg.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_unitg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_unitg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_unitg.Location = new System.Drawing.Point(11, 94);
            this.textBox_unitg.Name = "textBox_unitg";
            this.textBox_unitg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_unitg.Size = new System.Drawing.Size(100, 16);
            this.textBox_unitg.TabIndex = 1;
            this.textBox_unitg.Text = "0";
            this.textBox_unitg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_result
            // 
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_result.ForeColor = System.Drawing.Color.Black;
            this.textBox_result.Location = new System.Drawing.Point(342, 79);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(20, 31);
            this.textBox_result.TabIndex = 1;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_result.Visible = false;
            // 
            // textBox_meter
            // 
            this.textBox_meter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_meter.Location = new System.Drawing.Point(256, 44);
            this.textBox_meter.Name = "textBox_meter";
            this.textBox_meter.Size = new System.Drawing.Size(100, 16);
            this.textBox_meter.TabIndex = 1;
            this.textBox_meter.Text = "0";
            this.textBox_meter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_totalw
            // 
            this.textBox_totalw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_totalw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_totalw.Location = new System.Drawing.Point(137, 44);
            this.textBox_totalw.Name = "textBox_totalw";
            this.textBox_totalw.Size = new System.Drawing.Size(100, 16);
            this.textBox_totalw.TabIndex = 1;
            this.textBox_totalw.Text = "0";
            this.textBox_totalw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(145, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Net Ağırlık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim Gramaj";
            // 
            // textBox_rolik
            // 
            this.textBox_rolik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_rolik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_rolik.Location = new System.Drawing.Point(9, 44);
            this.textBox_rolik.Name = "textBox_rolik";
            this.textBox_rolik.Size = new System.Drawing.Size(100, 16);
            this.textBox_rolik.TabIndex = 1;
            this.textBox_rolik.Text = "0";
            this.textBox_rolik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_meter
            // 
            this.label_meter.AutoSize = true;
            this.label_meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_meter.Location = new System.Drawing.Point(278, 20);
            this.label_meter.Name = "label_meter";
            this.label_meter.Size = new System.Drawing.Size(49, 17);
            this.label_meter.TabIndex = 0;
            this.label_meter.Text = "Metre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(130, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Ağırlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rolik Ağırlık";
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_copy.Location = new System.Drawing.Point(680, 242);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(178, 51);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "Sonuç Kopyala";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Visible = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click_1);
            // 
            // textBox_commget
            // 
            this.textBox_commget.BackColor = System.Drawing.Color.Black;
            this.textBox_commget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_commget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_commget.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_commget.Location = new System.Drawing.Point(12, 363);
            this.textBox_commget.Name = "textBox_commget";
            this.textBox_commget.Size = new System.Drawing.Size(668, 13);
            this.textBox_commget.TabIndex = 7;
            this.textBox_commget.TextChanged += new System.EventHandler(this.textBox_commget_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(184, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Son Kaydı Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_zaman
            // 
            this.label_zaman.AutoSize = true;
            this.label_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_zaman.Location = new System.Drawing.Point(249, 69);
            this.label_zaman.Name = "label_zaman";
            this.label_zaman.Size = new System.Drawing.Size(45, 13);
            this.label_zaman.TabIndex = 11;
            this.label_zaman.Text = "ZAMAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 381);
            this.Controls.Add(this.textBox_commget);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.Text = "QC-SDR";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_data_weight;
        private System.Windows.Forms.Button button_read_weight;
        private System.Windows.Forms.Button button_disconnect_weight;
        private System.Windows.Forms.Button button_connect_weight;
        private System.Windows.Forms.TextBox textBox_com_weight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_weight;
        private System.Windows.Forms.Button button_rolik;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_meter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_meter;
        private System.Windows.Forms.TextBox textBox_totalw;
        private System.Windows.Forms.TextBox textBox_rolik;
        private System.Windows.Forms.TextBox textBox_unitg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_net_weight_copy;
        private System.Windows.Forms.Button button_meter_copy;
        private System.Windows.Forms.TextBox textBox_net_weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_commget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_zaman;
    }
}

