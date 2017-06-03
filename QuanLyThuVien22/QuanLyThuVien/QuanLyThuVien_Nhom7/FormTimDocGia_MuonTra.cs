using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyThuVien_Nhom7
{
    public partial class FormTimDocGia_MuonTra : Form
    {
       
        public FormTimDocGia_MuonTra()
        {
            InitializeComponent();
        }

        private void FormTimDocGia_MuonTra_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //FormMuonTra.docgia =
            try
            {
                FormMuonTra mt = new FormMuonTra();
                mt.docgia = int.Parse(cmbDocGia.SelectedValue.ToString());
                this.Hide();
                mt.ShowDialog();
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain mt = new FormMain();
            this.Hide();
            mt.ShowDialog();
        }
    }
}
