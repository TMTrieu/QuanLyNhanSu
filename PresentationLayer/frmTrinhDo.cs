using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PresentationLayer
{
    public partial class frmTrinhDo : Form
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }
        TRINHDODLL _trinhdo;
        bool _them;
        int _id;
        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _trinhdo = new TRINHDODLL();
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
            dgvDanhSach.DataSource = _trinhdo.getList();
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
                _trinhdo.Delete(_id);
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
                TRINH_DO td = new TRINH_DO();
                td.TENTD = txtTen.Text;
                _trinhdo.Add(td);
            }
            else
            {
                var td = _trinhdo.getItem(_id);
                    td.TENTD = txtTen.Text;
                    _trinhdo.Update(td);
                

            }
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvDanhSach.CurrentRow != null)
            {
                _id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["ID"].Value);
                txtTen.Text = dgvDanhSach.CurrentRow.Cells["TENTD"].Value.ToString();
            }
        }
    }
}
