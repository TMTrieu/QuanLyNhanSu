using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DataLayer;


namespace PresentationLayer.QuanLyNhanSu
{
    public partial class frmDanToc : Form
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        DANTOCDLL _dantoc;
        bool _them;
        int _id;
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _dantoc = new DANTOCDLL();
            showHide(true);
            loadData();
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
            dgvDanhSach.DataSource = _dantoc.getList();
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
                _dantoc.Delete(_id);
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
                DANTOC dt = new DANTOC();
                dt.TENDT = txtTen.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDT = txtTen.Text;
                _dantoc.Update(dt);
            }
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                _id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["ID"].Value);
                txtTen.Text = dgvDanhSach.CurrentRow.Cells["TENDT"].Value.ToString();
            }


        }
    }
}
