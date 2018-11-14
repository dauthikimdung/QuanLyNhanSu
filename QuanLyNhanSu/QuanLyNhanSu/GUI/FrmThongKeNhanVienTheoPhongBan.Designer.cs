namespace QuanLyNhanSu.GUI
{
    partial class FrmThongKeNhanVienTheoPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeNhanVienTheoPhongBan));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKePhongBan = new DevExpress.XtraEditors.SimpleButton();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThongKeChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeSinhNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKeSinhNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Danh sách nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnThongKePhongBan);
            this.groupBox1.Controls.Add(this.cboPhongBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 129);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê nhân viên theo phòng ban";
            // 
            // btnThongKePhongBan
            // 
            this.btnThongKePhongBan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThongKePhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKePhongBan.Image")));
            this.btnThongKePhongBan.Location = new System.Drawing.Point(277, 75);
            this.btnThongKePhongBan.Name = "btnThongKePhongBan";
            this.btnThongKePhongBan.Size = new System.Drawing.Size(149, 34);
            this.btnThongKePhongBan.TabIndex = 12;
            this.btnThongKePhongBan.Text = "Thống kê";
            this.btnThongKePhongBan.Click += new System.EventHandler(this.btnThongKePhongBan_Click);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(108, 37);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(318, 21);
            this.cboPhongBan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnThongKeChucVu);
            this.groupBox2.Controls.Add(this.cboChucVu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 129);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê nhân viên theo chức vụ";
            // 
            // btnThongKeChucVu
            // 
            this.btnThongKeChucVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThongKeChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeChucVu.Image")));
            this.btnThongKeChucVu.Location = new System.Drawing.Point(277, 75);
            this.btnThongKeChucVu.Name = "btnThongKeChucVu";
            this.btnThongKeChucVu.Size = new System.Drawing.Size(149, 34);
            this.btnThongKeChucVu.TabIndex = 12;
            this.btnThongKeChucVu.Text = "Thống kê";
            this.btnThongKeChucVu.Click += new System.EventHandler(this.btnThongKeChucVu_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(108, 37);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(318, 21);
            this.cboChucVu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ";
            // 
            // btnXuat
            // 
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(37, 426);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(466, 43);
            this.btnXuat.TabIndex = 101;
            this.btnXuat.Text = "Xuất ra file excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(37, 475);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(466, 43);
            this.btnDong.TabIndex = 100;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgrThongKeSinhNhat
            // 
            this.dgrThongKeSinhNhat.Location = new System.Drawing.Point(509, 99);
            this.dgrThongKeSinhNhat.MainView = this.grvThongKeSinhNhat;
            this.dgrThongKeSinhNhat.Name = "dgrThongKeSinhNhat";
            this.dgrThongKeSinhNhat.Size = new System.Drawing.Size(675, 419);
            this.dgrThongKeSinhNhat.TabIndex = 114;
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
            // FrmThongKeNhanVienTheoPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.dgrThongKeSinhNhat);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKeNhanVienTheoPhongBan";
            this.Text = "FrmThongKeTheoNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeSinhNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKeSinhNhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThongKePhongBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnThongKeChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnDong;
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