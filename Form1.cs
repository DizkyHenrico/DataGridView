using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            // TODO: This line of code loads data into the 'pRODIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.pRODIDataSet.mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.UserMhs' table. You can move, or remove it, as needed.
            this.userMhsTableAdapter.Fill(this.prodiTIDataSet.UserMhs);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa_Coba' table. You can move, or remove it, as needed.
            this.mahasiswa_CobaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa_Coba);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa_Coba' table. You can move, or remove it, as needed.
            this.mahasiswa_CobaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa_Coba);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasisa' table. You can move, or remove it, as needed.
            this.mahasisaTableAdapter.Fill(this.prodiTIDataSet.Mahasisa);

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Red;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.DarkViolet;
            this.dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.DarkSalmon;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
