using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.QuanLyNhanSu
{
    public partial class frmTonGiao : Form
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        TONGIAODLL _tongiao;
        bool _them;
        int _id;
        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _tongiao = new TONGIAODLL();
            showHide(true);
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtTen.Enabled = !kt;
        }
        void loadData()
        {
            dgvDanhSach.DataSource = _tongiao.getList();
            dgvDanhSach.AutoGenerateColumns = true;
        }
  
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            showHide(false);
            _them = true;
            txtTen.Text = string.Empty;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            _them = false;
            showHide(false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tongiao.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            showHide(true);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            _them = false;
            showHide(true);
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TONGIAO tg = new TONGIAO();
                tg.TENTG = txtTen.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var tg = _tongiao.getItem(_id);
                tg.TENTG = txtTen.Text;
                _tongiao.Update(tg);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (dgvDanhSach.CurrentRow != null)
            {
                _id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["ID"].Value);
                txtTen.Text = dgvDanhSach.CurrentRow.Cells["TENTG"].Value.ToString();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
