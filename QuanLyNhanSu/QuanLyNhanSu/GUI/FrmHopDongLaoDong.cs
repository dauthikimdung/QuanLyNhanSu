using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FrmHopDongLaoDong : Form
    {
        BindingSource list = new BindingSource();
        public FrmHopDongLaoDong()
        {
            InitializeComponent();
            dgrHopDongLaoDong.DataSource = list;
            dtpNgayKi.DateTime = DateTime.Now;
            LoadcboLuong();
            LoadCboNhanVien();
            laodhopdonglaodong();
            AddHopDonglaoDongBinding();
        }
        void laodhopdonglaodong()
        {
            list.DataSource = HopDongLaoDongDAO.LoadHopDongLaoDong();
        }
        void LoadCboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.ValueMember = "NHANVIENID";
            cboNhanVien.DisplayMember = "HOTEN";
        }
        void LoadcboLuong()
        {
            cboLoaiLuong.DataSource = LuongDAO.LoadcboLuong();
            cboLoaiLuong.ValueMember = "LUONGID";
            cboLoaiLuong.DisplayMember = "LUONGID";
        }
        void AddHopDonglaoDongBinding()
        {
            cboNhanVien.DataBindings.Add(new Binding("SelectedValue", dgrHopDongLaoDong.DataSource, "NHANVIENID", true, DataSourceUpdateMode.Never));
            txbLoaiHopDong.DataBindings.Add(new Binding("Text", dgrHopDongLaoDong.DataSource, "LOAIHOPDONG", true, DataSourceUpdateMode.Never));
            dtpNgayKi.DataBindings.Add(new Binding("DateTime", dgrHopDongLaoDong.DataSource, "NGAYKY", true, DataSourceUpdateMode.Never));
            cboLoaiLuong.DataBindings.Add(new Binding("SelectedValue", dgrHopDongLaoDong.DataSource, "LUONGID", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                int idluong = (int)cboLoaiLuong.SelectedValue;
                string loaihd = txbLoaiHopDong.Text;
                DateTime ngayky = dtpNgayKi.DateTime;
                if (HopDongLaoDongDAO.InserthopDonglaoDong(idnv, loaihd, idluong, ngayky) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            laodhopdonglaodong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idhd = Convert.ToInt32(grvHopDongLaoDong.GetFocusedDataRow()["HOPDONGLAODONGID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                int idluong = (int)cboLoaiLuong.SelectedValue;
                string loaihd = txbLoaiHopDong.Text;
                DateTime ngayky = dtpNgayKi.DateTime;
                if (HopDongLaoDongDAO.UpdateHopDongLaoDong(idhd, idnv, loaihd, idluong, ngayky) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            laodhopdonglaodong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idhd = Convert.ToInt32(grvHopDongLaoDong.GetFocusedDataRow()["HOPDONGLAODONGID"].ToString());
                if (HopDongLaoDongDAO.DeleteHopDongLaoDong(idhd) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            laodhopdonglaodong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
