namespace QuanLyNhanSu.GUI
{
    partial class FrmThongKeNhanVienSapNghiHuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeNhanVienSapNghiHuu));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNhanVienSapNghiHuu = new System.Windows.Forms.RadioButton();
            this.rbtnNhanVienMoi = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrThongKeSinhNhat = new DevExpress.XtraGrid.GridControl();
            this.grvThongKeSinhNhat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIDANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTKNGANHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeSinhNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKeSinhNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(39, 469);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(466, 43);
            this.btnDong.TabIndex = 106;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(39, 420);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(466, 43);
            this.btnXuat.TabIndex = 107;
            this.btnXuat.Text = "Xuất ra file excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtnNhanVienSapNghiHuu);
            this.groupBox1.Controls.Add(this.rbtnNhanVienMoi);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Location = new System.Drawing.Point(39, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 152);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê nhân viên sắp nghỉ hưu";
            // 
            // rbtnNhanVienSapNghiHuu
            // 
            this.rbtnNhanVienSapNghiHuu.AutoSize = true;
            this.rbtnNhanVienSapNghiHuu.Location = new System.Drawing.Point(57, 63);
            this.rbtnNhanVienSapNghiHuu.Name = "rbtnNhanVienSapNghiHuu";
            this.rbtnNhanVienSapNghiHuu.Size = new System.Drawing.Size(138, 17);
            this.rbtnNhanVienSapNghiHuu.TabIndex = 14;
            this.rbtnNhanVienSapNghiHuu.TabStop = true;
            this.rbtnNhanVienSapNghiHuu.Text = "Nhân viên sắp nghỉ hưu";
            this.rbtnNhanVienSapNghiHuu.UseVisualStyleBackColor = true;
            // 
            // rbtnNhanVienMoi
            // 
            this.rbtnNhanVienMoi.AutoSize = true;
            this.rbtnNhanVienMoi.Location = new System.Drawing.Point(57, 29);
            this.rbtnNhanVienMoi.Name = "rbtnNhanVienMoi";
            this.rbtnNhanVienMoi.Size = new System.Drawing.Size(93, 17);
            this.rbtnNhanVienMoi.TabIndex = 13;
            this.rbtnNhanVienMoi.TabStop = true;
            this.rbtnNhanVienMoi.Text = "Nhân viên mới";
            this.rbtnNhanVienMoi.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(290, 90);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(149, 34);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Danh sách nhân viên";
            // 
            // dgrThongKeSinhNhat
            // 
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.RelationName = "Level3";
            this.dgrThongKeSinhNhat.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.dgrThongKeSinhNhat.Location = new System.Drawing.Point(538, 51);
            this.dgrThongKeSinhNhat.MainView = this.grvThongKeSinhNhat;
            this.dgrThongKeSinhNhat.Name = "dgrThongKeSinhNhat";
            this.dgrThongKeSinhNhat.Size = new System.Drawing.Size(696, 461);
            this.dgrThongKeSinhNhat.TabIndex = 116;
            this.dgrThongKeSinhNhat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThongKeSinhNhat});
            // 
            // grvThongKeSinhNhat
            // 
            this.grvThongKeSinhNhat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhanVienID,
            this.HoTen,
            this.BIDANH,
            this.DIACHI,
            this.NGAYSINH,
            this.MASOTHUE,
            this.GIOITINH,
            this.SOTKNGANHANG,
            this.SDT,
            this.Email,
            this.ChucVuID,
            this.PhongBanID});
            this.grvThongKeSinhNhat.GridControl = this.dgrThongKeSinhNhat;
            this.grvThongKeSinhNhat.Name = "grvThongKeSinhNhat";
            this.grvThongKeSinhNhat.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvThongKeSinhNhat.PaintStyleName = "Flat";
            this.grvThongKeSinhNhat.RowHeight = 30;
            // 
            // NhanVienID
            // 
            this.NhanVienID.Caption = "Mã nhân viên";
            this.NhanVienID.FieldName = "NhanVienID";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Width = 177;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HOTEN";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 0;
            this.HoTen.Width = 148;
            // 
            // BIDANH
            // 
            this.BIDANH.Caption = "Bí danh";
            this.BIDANH.FieldName = "BIDANH";
            this.BIDANH.Name = "BIDANH";
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Caption = "Ngày sinh";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // MASOTHUE
            // 
            this.MASOTHUE.Caption = "Mã số thuế";
            this.MASOTHUE.FieldName = "MASOTHUE";
            this.MASOTHUE.Name = "MASOTHUE";
            // 
            // GIOITINH
            // 
            this.GIOITINH.Caption = "Giới tính";
            this.GIOITINH.FieldName = "TENGIOITINH";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 1;
            this.GIOITINH.Width = 218;
            // 
            // SOTKNGANHANG
            // 
            this.SOTKNGANHANG.Caption = "Số tài khoản";
            this.SOTKNGANHANG.FieldName = "SOTKNGANHANG";
            this.SOTKNGANHANG.Name = "SOTKNGANHANG";
            // 
            // SDT
            // 
            this.SDT.Caption = "SĐT";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "EMAIL";
            this.Email.Name = "Email";
            // 
            // ChucVuID
            // 
            this.ChucVuID.Caption = "Chức vụ";
            this.ChucVuID.FieldName = "TENCV";
            this.ChucVuID.Name = "ChucVuID";
            this.ChucVuID.Visible = true;
            this.ChucVuID.VisibleIndex = 2;
            this.ChucVuID.Width = 142;
            // 
            // PhongBanID
            // 
            this.PhongBanID.Caption = "Đơn vị";
            this.PhongBanID.FieldName = "TENPB";
            this.PhongBanID.Name = "PhongBanID";
            this.PhongBanID.Visible = true;
            this.PhongBanID.VisibleIndex = 3;
            this.PhongBanID.Width = 153;
            // 
            // FrmThongKeNhanVienSapNghiHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.dgrThongKeSinhNhat);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKeNhanVienSapNghiHuu";
            this.Text = "FrmThongKeNhanVienSapNghiHuu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeSinhNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKeSinhNhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnNhanVienSapNghiHuu;
        private System.Windows.Forms.RadioButton rbtnNhanVienMoi;
        private DevExpress.XtraGrid.GridControl dgrThongKeSinhNhat;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThongKeSinhNhat;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn BIDANH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn MASOTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn SOTKNGANHANG;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuID;
        private DevExpress.XtraGrid.Columns.GridColumn PhongBanID;

    }
}