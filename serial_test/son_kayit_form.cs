using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace serial_test
{
    public partial class son_kayit_form : Form
    {
        public son_kayit_form()
        {
            InitializeComponent();
        }

        public string[] lastData_form1 = new string[6];
        public Button show_skf;
        private void son_kayit_form_Load(object sender, EventArgs e)
        {
            dataGridView_son_kayit.ReadOnly = true;
            dataGridView_son_kayit.AllowUserToDeleteRows = false;

            dataGridView_son_kayit.ColumnCount = 6;
            dataGridView_son_kayit.Columns[0].Name = "Rolik Ağırlık";
            dataGridView_son_kayit.Columns[1].Name = "Toplam Ağırlık";
            dataGridView_son_kayit.Columns[2].Name = "Metre";
            dataGridView_son_kayit.Columns[3].Name = "Birim Gramaj";
            dataGridView_son_kayit.Columns[4].Name = "Net Ağırlık";
            dataGridView_son_kayit.Columns[5].Name = "Zaman";

            dataGridView_son_kayit.Columns[5].Width = 115;

            dataGridView_son_kayit.Rows.Add(
                lastData_form1[0],
                lastData_form1[1],
                lastData_form1[2],
                lastData_form1[3],
                lastData_form1[4],
                lastData_form1[5]);

            // Grid Ayarlari
        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            show_skf.Enabled = true;
            this.Close();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            dataGridView_son_kayit.Rows.Clear();
            dataGridView_son_kayit.Rows.Add(
                lastData_form1[0],
                lastData_form1[1],
                lastData_form1[2],
                lastData_form1[3],
                lastData_form1[4],
                lastData_form1[5]);
        }
    }
}
