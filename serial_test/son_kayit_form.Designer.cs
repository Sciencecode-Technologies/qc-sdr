namespace serial_test
{
    partial class son_kayit_form
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
            this.dataGridView_son_kayit = new System.Windows.Forms.DataGridView();
            this.button_kapat = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_son_kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_son_kayit
            // 
            this.dataGridView_son_kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_son_kayit.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_son_kayit.Name = "dataGridView_son_kayit";
            this.dataGridView_son_kayit.Size = new System.Drawing.Size(659, 69);
            this.dataGridView_son_kayit.TabIndex = 0;
            // 
            // button_kapat
            // 
            this.button_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kapat.Location = new System.Drawing.Point(391, 87);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(137, 54);
            this.button_kapat.TabIndex = 1;
            this.button_kapat.Text = "Kapat";
            this.button_kapat.UseVisualStyleBackColor = true;
            this.button_kapat.Click += new System.EventHandler(this.button_kapat_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guncelle.Location = new System.Drawing.Point(534, 87);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(137, 54);
            this.button_guncelle.TabIndex = 2;
            this.button_guncelle.Text = "Yenile";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tüm Kayıtları Getir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // son_kayit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 152);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.dataGridView_son_kayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "son_kayit_form";
            this.ShowIcon = false;
            this.Text = "Son Kayıt";
            this.Load += new System.EventHandler(this.son_kayit_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_son_kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_son_kayit;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button1;
    }
}