using BusinessLayer;
using TransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class FormLoaiCa : Form
    {
        private BLL_LoaiCa _bllLoaiCa;
        private int _currentId;
        private bool _isAddNew;
        public FormLoaiCa()
        {
            InitializeComponent();
            _bllLoaiCa = new BLL_LoaiCa();
        }
        
        private void FormLoaiCa_Load(object sender, EventArgs e)
        {
            dGvLoaiCa.DataSource = _bllLoaiCa.GetList();
            ShowHide(true);
        }
        private void ShowHide(bool kt)
        {
            btLuu.Enabled = !kt;
            btHuy.Enabled = !kt;
            btSua.Enabled = kt;
            btThem.Enabled = kt;
            btXoa.Enabled = kt;
            btIn.Enabled = kt;
            btDong.Enabled = kt;
            txtLoaiCa.Enabled = !kt;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            _isAddNew = true;
            ShowHide(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            _isAddNew = false;
            ShowHide(false);
        }

        private void dGvLoaiCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dGvLoaiCa.Rows[e.RowIndex];
                _currentId = Convert.ToInt32(selectedRow.Cells["IDLOAICA"].Value);
                txtLoaiCa.Text = selectedRow.Cells["TENLOAICA"].Value.ToString();
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (_currentId == 0) return;

            if (MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _bllLoaiCa.Delete(_currentId);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isAddNew)
                {
                    // Add new item
                    var newLoaiCa = new DTO_LoaiCa();
                    {
                         = txtLoaiCa.Text;
                        // Add other properties as needed
                    }
                    _bllLoaiCa.Add(newLoaiCa);
                }
                else
                {
                    // Update existing item
                    var existingLoaiCa = _bllLoaiCa.GetItem(_currentId);
                    existingLoaiCa.TENLOAICA = txtLoaiCa.Text;
                    _bllLoaiCa.Update(existingLoaiCa);
                }

                // Refresh grid
                dGvLoaiCa.DataSource = _bllLoaiCa.GetList();
                ShowHide(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ShowHide(true);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            ShowHide(false);
        }
    }
}

