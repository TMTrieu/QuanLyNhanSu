using System;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace PresentationLayer
{
    public partial class DepartmentForm : Form
    {
        BLLPhongBan bllPB;
        bool isAdding = false; // Kiểm tra trạng thái Thêm/Sửa
        int selectedID = -1; // ID của phòng ban đang được chọn
        public DepartmentForm()
        {
            InitializeComponent();
        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            isAdding = false;
            bllPB = new BLLPhongBan();
            _showHide(true);
            loadData();
        }

        void _showHide(bool kt)
        {
            btLuu.Enabled = !kt;
            btHuy.Enabled = !kt;
            btThem.Enabled = kt;
            btSua.Enabled = kt;
            btXoa.Enabled = kt;
            btDong.Enabled = kt;
            btIn.Enabled = kt;
            txtTen.Enabled = !kt;
        }
        void loadData()
        {
            gvDSPhongBan.DataSource = bllPB.getList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            _showHide(false);
            isAdding = true;
            txtTen.Text = string.Empty;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            _showHide(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                bllPB.Delete(selectedID);
                loadData();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            loadData();
            isAdding = false;
            _showHide(true);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            _showHide(true);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {

        }

        void SaveData()
        {
            if (isAdding)
            {
                PHONGBAN dt = new PHONGBAN();
                dt.TENPB = txtTen.Text;
                bllPB.Add(dt);
            }
            else
            {
                var dt = bllPB.getItem(selectedID);
                dt.TENPB = txtTen.Text;
                bllPB.Update(dt);
            }
        }

        private void gvDSPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedID = int.Parse(gvDSPhongBan.GetFocusedRowCellValue("IDPB").ToString());
            //txtTen.Text = gvDSPhongBan.GetFocusedRowCellValue("TENPB").ToString();
            if (gvDSPhongBan.SelectedRows.Count > 0)
            {
                selectedID = int.Parse(gvDSPhongBan.SelectedRows[0].Cells["IDPB"].Value.ToString());
                txtTen.Text = gvDSPhongBan.SelectedRows[0].Cells["TENPB"].Value.ToString();
            }
        }
    }
}
