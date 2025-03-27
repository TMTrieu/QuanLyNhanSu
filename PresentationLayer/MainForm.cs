using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;


using PresentationLayer.QuanLyNhanSu;



namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }

        private void OpenTab(string tStrbtName, Form frm) // hàm thêm form vào tabcontrol

        {
            foreach (TabPage tab in tabControlContent.TabPages)     // kiểm tra tab bật lên có sẵn chưa
            {
                if (tab.Text == tStrbtName)
                {
                    tabControlContent.SelectedTab = tab; // chuyển sang tab đó
                    return;
                }
            }
            TabPage newTab = new TabPage(tStrbtName); // lay ten cua tStrbt de tao tab moi
            frm.TopLevel = false;   //   nhúng Form vào TabPage
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Form sẽ giãn theo TabPage
            frm.ShowIcon= false;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
           
            frm.Text = ""; 

            // Xử lý sự kiện khi form đóng
            frm.FormClosing += (s, e) =>
            {
                tabControlContent.TabPages.Remove(newTab); // Xóa tab khi form đóng
            };

            // Thêm form vào TabPage
            newTab.Controls.Add(frm);
            tabControlContent.TabPages.Add(newTab); // Thêm TabPage vào TabControl
            tabControlContent.SelectedTab = newTab;
            frm.Show();
        }

        private void tStrbtResetPassword_Click(object sender, EventArgs e)
        {
            OpenTab("Đổi mật khẩu", new TestFrm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            CreateTab("Dân tộc", new frmDanToc());
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            CreateTab("Tôn giáo", new frmTonGiao());
        }

        private void btPhongBan_Click(object sender, EventArgs e)
        {
            CreateTab("Phòng Ban", new DepartmentForm());
            //DepartmentForm frm = new DepartmentForm();
            //frm.Show();
        }

        private void tStrbtShiftType_Click(object sender, EventArgs e)
        {
            OpenTab("Loại ca", new FormLoaiCa());
        }
    }

        //private void btnDanToc_Click(object sender, EventArgs e)
        //{
        //    frmDanToc frm = new frmDanToc();
        //    frm.Show();
        //}

        //private void btnTonGiao_Click(object sender, EventArgs e)
        //{
        //    frmTonGiao frm= new frmTonGiao();
        //    frm.Show();
        //}
    }

