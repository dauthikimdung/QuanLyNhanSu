namespace QuanLyNhanSu.GUI
{
    partial class FrmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopDongLaoDong));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiLuong = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayKi = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLoaiHopDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrHopDongLaoDong = new DevExpress.XtraGrid.GridControl();
            this.grvHopDongLaoDong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HopDongLaoDongID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHopDongLaoDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHopDongLaoDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh sách hợp lao động";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(980, 372);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(252, 43);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(722, 372);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(252, 43);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(722, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(510, 43);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(722, 470);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(510, 43);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboLoaiLuong);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayKi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbLoaiHopDong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(722, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 278);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng lao động";
            // 
            // cboLoaiLuong
            // 
            this.cboLoaiLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLuong.FormattingEnabled = true;
            this.cboLoaiLuong.Location = new System.Drawing.Point(181, 224);
            this.cboLoaiLuong.Name = "cboLoaiLuong";
            this.cboLoaiLuong.Size = new System.Drawing.Size(197, 21);
            this.cboLoaiLuong.TabIndex = 19;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(181, 107);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(197, 21);
            this.cboNhanVien.TabIndex = 18;
            // 
            // dtpNgayKi
            // 
            this.dtpNgayKi.EditValue = new System.DateTime(2017, 7, 3, 22, 36, 56, 178);
            this.dtpNgayKi.Location = new System.Drawing.Point(181, 54);
            this.dtpNgayKi.Name = "dtpNgayKi";
            this.dtpNgayKi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dtpNgayKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKi.Size = new System.Drawing.Size(132, 22);
            this.dtpNgayKi.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Loại lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhân viên";
            // 
            // txbLoaiHopDong
            // 
            this.txbLoaiHopDong.Location = new System.Drawing.Point(181, 166);
            this.txbLoaiHopDong.Name = "txbLoaiHopDong";
            this.txbLoaiHopDong.Size = new System.Drawing.Size(245, 20);
            this.txbLoaiHopDong.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày kí";
            // 
            // dgrHopDongLaoDong
            // 
            gridLevelNode1.RelationName = "Level1";
            this.dgrHopDongLaoDong.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgrHopDongLaoDong.Location = new System.Drawing.Point(15, 34);
            this.dgrHopDongLaoDong.MainView = this.grvHopDongLaoDong;
            this.dgrHopDongLaoDong.Name = "dgrHopDongLaoDong";
            this.dgrHopDongLaoDong.Size = new System.Drawing.Size(678, 479);
            this.dgrHopDongLaoDong.TabIndex = 15;
            this.dgrHopDongLaoDong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHopDongLaoDong});
            // 
            // grvHopDongLaoDong
            // 
            this.grvHopDongLaoDong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HopDongLaoDongID,
            this.NgayKy,
            this.LoaiHopDong,
            this.LoaiLuong,
            this.NhanVienID,
            this.gridColumn1});
            this.grvHopDongLaoDong.GridControl = this.dgrHopDongLaoDong;
            this.grvHopDongLaoDong.Name = "grvHopDongLaoDong";
            this.grvHopDongLaoDong.OptionsBehavior.ReadOnly = true;
            this.grvHopDongLaoDong.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvHopDongLaoDong.PaintStyleName = "Flat";
            this.grvHopDongLaoDong.RowHeight = 30;
            // 
            // HopDongLaoDongID
            // 
            this.HopDongLaoDongID.Caption = "Mã hợp đồng lao động";
            this.HopDongLaoDongID.FieldName = "HOPDONGLAODONGID";
            this.HopDongLaoDongID.Name = "HopDongLaoDongID";
            this.HopDongLaoDongID.Visible = true;
            this.HopDongLaoDongID.VisibleIndex = 0;
            this.HopDongLaoDongID.Width = 116;
            // 
            // NgayKy
            // 
            this.NgayKy.Caption = "Ngày ký";
            this.NgayKy.FieldName = "NGAYKY";
            this.NgayKy.Name = "NgayKy";
            this.NgayKy.Visible = true;
            this.NgayKy.VisibleIndex = 2;
            this.NgayKy.Width = 133;
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.Caption = "Loại hợp đồng";
            this.LoaiHopDong.FieldName = "LOAIHOPDONG";
            this.LoaiHopDong.Name = "LoaiHopDong";
            this.LoaiHopDong.Visible = true;
            this.LoaiHopDong.VisibleIndex = 3;
            this.LoaiHopDong.Width = 136;
            // 
            // LoaiLuong
            // 
            this.LoaiLuong.Caption = "Loại lương";
            this.LoaiLuong.FieldName = "LUONGID";
            this.LoaiLuong.Name = "LoaiLuong";
            this.LoaiLuong.Visible = true;
            this.LoaiLuong.VisibleIndex = 4;
            this.LoaiLuong.Width = 129;
            // 
            // NhanVienID
            // 
            this.NhanVienID.Caption = "Nhân viên";
            this.NhanVienID.FieldName = "HOTEN";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = true;
            this.NhanVienID.VisibleIndex = 1;
            this.NhanVienID.Width = 147;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "NHANVIENID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // FrmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrHopDongLaoDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHopDongLaoDong";
            this.Text = "FrmHopDongLaoDong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHopDongLaoDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHopDongLaoDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbLoaiHopDong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgrHopDongLaoDong;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHopDongLaoDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.DateEdit dtpNgayKi;
        private System.Windows.Forms.ComboBox cboLoaiLuong;
        private DevExpress.XtraGrid.Columns.GridColumn HopDongLaoDongID;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKy;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}