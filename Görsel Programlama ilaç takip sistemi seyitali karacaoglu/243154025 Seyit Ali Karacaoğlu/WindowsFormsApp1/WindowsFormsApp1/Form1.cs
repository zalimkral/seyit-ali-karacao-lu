using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1 
{ 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
            txtÜrün.Text,
            txtKategori.Text,
            txtFiyat.Text
            );

            


            string girilenDeger = txtKategori.Text;

            // @ işareti kontrolü         
            if (girilenDeger.Contains("@"))
            {
                lbldurum.Text = "Geçerli bir mail adresi formatı olabilir.";
            }
            else if(girilenDeger.Contains("@") == false)
            {
                lbldurum.Text = "Geçersiz! Mail adresinde '@' işareti olmalı.";
            }
            else { lbldurum.Text = "Kayıt Eklendi"; }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtÜrün.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtFiyat.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txtKategori.Text;

                lbldurum.Text = "Kayıt Güncellendi";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                lbldurum.Text = "Kayıt Silindi";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtÜrün.Clear();
            txtFiyat.Clear();
            txtKategori.Clear();
            

            lbldurum.Text = "Alanlar Temizlendi";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtÜrün.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtFiyat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Ürün";
            dataGridView1.Columns[1].Name = "Kategori";
            dataGridView1.Columns[2].Name = "Fiyat";
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != menuStrip1 && ctrl != textBox1)
                {
                    ctrl.Visible = false;
                }
            }

            textBox1.Visible = true;
            textBox1.Text = "Bu program bir stok takip uygulamasıdır.\r\nGeliştirici: Sen";

        }
    }   
}