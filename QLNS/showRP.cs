using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class showRP : Form
    {
        public showRP()
        {
            InitializeComponent();

        }

        private void showRP_Load(object sender, EventArgs e)
        {
            //string query = "SELECT NHANVIEN.MANV, NHANVIEN.HOTEN, NHANVIEN.GIOITINH, CHUCVU.TENCV, PHONGBAN.TENPB FROM NHANVIEN, CHUCVU, PHONGBAN WHERE NHANVIEN.MACV = CHUCVU.MACV AND NHANVIEN.MAPB = PHONGBAN.MAPB";

            string query = "SELECT NHANVIEN.MANV AS MANV, NHANVIEN.HOTEN AS HOTEN,NHANVIEN.GIOITINH AS GIOITINH, CHUCVU.TENCV AS TENCV,PHONGBAN.TENPB AS TENPB FROM NHANVIEN, CHUCVU, PHONGBAN WHERE NHANVIEN.MAPB = PHONGBAN.MAPB AND NHANVIEN.MACV = CHUCVU.MACV";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            CrystalReport1 rp = new CrystalReport1();
            rp.SetDataSource(dt);
            cRPV.ReportSource = rp;
        }
    }
}
