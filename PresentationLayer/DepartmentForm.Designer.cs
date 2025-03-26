namespace PresentationLayer
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.gvDSPhongBan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.btHuy = new System.Windows.Forms.ToolStripButton();
            this.btDong = new System.Windows.Forms.ToolStripButton();
            this.btIn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSPhongBan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTen);
            this.splitContainer1.Panel1.Controls.Add(this.lbTen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvDSPhongBan);
            this.splitContainer1.Size = new System.Drawing.Size(872, 287);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(130, 21);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(294, 28);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "S";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(73, 21);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(52, 22);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên: ";
            // 
            // gvDSPhongBan
            // 
            this.gvDSPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvDSPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenPB});
            this.gvDSPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDSPhongBan.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvDSPhongBan.Location = new System.Drawing.Point(0, 0);
            this.gvDSPhongBan.Name = "gvDSPhongBan";
            this.gvDSPhongBan.RowTemplate.Height = 28;
            this.gvDSPhongBan.Size = new System.Drawing.Size(872, 209);
            this.gvDSPhongBan.TabIndex = 0;
            this.gvDSPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSPhongBan_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TENPB";
            this.TenPB.HeaderText = "Phòng Ban";
            this.TenPB.Name = "TenPB";
            this.TenPB.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btThem,
            this.btSua,
            this.btXoa,
            this.btLuu,
            this.btHuy,
            this.btDong,
            this.btIn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btThem
            // 
            this.btThem.Image = global::PresentationLayer.Properties.Resources.icons8_transfer_32;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 29);
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::PresentationLayer.Properties.Resources.icons8_faith_32;
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(70, 29);
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::PresentationLayer.Properties.Resources.icons8_quit_32;
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 29);
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::PresentationLayer.Properties.Resources.icons8_contract_32;
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(69, 29);
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Image = global::PresentationLayer.Properties.Resources.icons8_layoff_32;
            this.btHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(72, 29);
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::PresentationLayer.Properties.Resources.icons8_password_34;
            this.btDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(85, 29);
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btIn
            // 
            this.btIn.Image = global::PresentationLayer.Properties.Resources.icons8_payroll_32;
            this.btIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(55, 29);
            this.btIn.Text = "In";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 319);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSPhongBan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.DataGridView gvDSPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.ToolStripButton btHuy;
        private System.Windows.Forms.ToolStripButton btDong;
        private System.Windows.Forms.ToolStripButton btIn;
    }
}