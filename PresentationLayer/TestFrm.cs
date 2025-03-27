﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class TestFrm : Form
    {
        public TestFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TestFrm_Load(object sender, EventArgs e)
        {
            loadthu();
            button2.Location = new Point(this.ClientSize.Width - button2.Width - 10, 10);
        }

        BLTest bl = new BLTest();
        DataTable tb_main = new DataTable();

        private void loadthu()
        {
            tb_main = bl.BLtb();
            dataGridView1.DataSource = tb_main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
