﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //void openForm(Type typeForm)
        //{
        //    foreach(var frm in MdiChildren)
        //    {
        //        if (frm.GetType() == typeForm)
        //        {
        //            frm.Activate();
        //            return;
        //        }
        //    }
        //    Form f = (Form)Activate.CreateAccessibilityInstance(typeForm);
        //    f.MdiParent = this;
        //    f.Show();
        //}

        private void CreateTab(string tStrbtName, Form frm) // hàm thêm form vào tabcontrol
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
            frm.FormBorderStyle = FormBorderStyle.Sizable;
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
            CreateTab("Doi mat khau", new TestFrm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btPhongBan_Click(object sender, EventArgs e)
        {
            CreateTab("Phòng Ban", new DepartmentForm());
            //DepartmentForm frm = new DepartmentForm();
            //frm.Show();
        }
    }
}
