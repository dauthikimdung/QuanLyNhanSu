using QuanLyNhanSu.DAO;
using QuanLyNhanSu.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmMain : Form
    {
        public FrmMain(int type)
        {
            InitializeComponent();
            LoadButton(type);
        }
        void LoadButton(int type)
        {
            if(type == 0)
            {
                barBangCap.Enabled = false;
                barBaoHiemXaHoi.Enabled = false;
                barBaoHiemYTe.Enabled = false;
                barDanhMucChucVu.Enabled = false;
                barDanhMucPhongBan.Enabled = false;
                barHopDongLaoDong.Enabled = false;
                barQuanLyNhanVien.Enabled = false;
                barQuaTrinhCongTac.Enabled = false;
                barQuaTrinhHocTap.Enabled = false;
                barThongKeDangVien.Enabled = false;
                barThongKeNhanVienSapNghiHuu.Enabled = false;
                barThongKeSinhNhatTheoThang.Enabled = false;
                barThongKeTheoNhanVien.Enabled = false;
                barThongTinDang.Enabled = false;
                barThongTinGiaDinh.Enabled = false;
                barThongTinKhenThuongKiLuat.Enabled = false;
                barThongTinTaiSan.Enabled = false;
                barUser.Enabled = false;
            }
        }
        #region sự kiện mở các form
        private void barDanhMucChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyChucVu quanlychucvu = new FrmQuanLyChucVu();
            quanlychucvu.TopLevel = false;
            quanlychucvu.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(quanlychucvu);
            quanlychucvu.Show();
        }

        private void barDanhMucPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyPhongBan frmtg = new FrmQuanLyPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien frmtg = new FrmQuanLyNhanVien();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barHopDongLaoDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHopDongLaoDong frmtg = new FrmHopDongLaoDong();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barBaoHiemXaHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBaoHiemXaHoi frmtg = new FrmBaoHiemXaHoi();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barBaoHiemYTe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBaoHiemYTe frmtg = new FrmBaoHiemYTe();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuaTrinhCongTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuaTrinhCongTac frmtg = new FrmQuaTrinhCongTac();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barBangCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBangCap frmtg = new FrmBangCap();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuaTrinhHocTap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuaTrinhHocTap frmtg = new FrmQuaTrinhHocTap();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongTinGiaDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinGiaDinh frmtg = new FrmThongTinGiaDinh();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongTinDang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinDang frmtg = new FrmThongTinDang();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongTinKhenThuongKiLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhenThuongKiLuat frmtg = new FrmKhenThuongKiLuat();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongTinTaiSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinTaiSan frmtg = new FrmThongTinTaiSan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongKeTheoNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongKeNhanVienTheoPhongBan frmtg = new FrmThongKeNhanVienTheoPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChamCong frmtg = new FrmChamCong();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongKeNhanVienSapNghiHuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongKeNhanVienSapNghiHuu frmtg = new FrmThongKeNhanVienSapNghiHuu();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongKeSinhNhatTheoThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongKeSinhNhatTheoThang frmtg = new FrmThongKeSinhNhatTheoThang();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQLChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChamCong frmtg = new FrmChamCong();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }
        private void barUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUser frmtg = new FrmUser();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
