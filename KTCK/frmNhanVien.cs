using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KTCK
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool kiemTraThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        bool dtpFlag = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();

            LayDuLieu();
            TrangThaiNutChucNang(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtPhai.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtThanhPho.Clear();
            txtDienThoai.Clear();
           

            kiemTraThem = true;
            TrangThaiNutChucNang(false);
            txtMaNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //ktra chua co ma thì không làm gì cả thoát khỏi thr tục
            if (txtMaNhanVien.Text == "") return;
            //luu ma cu de biet minh sua tren ban ghi nao
            maCu = txtMaNhanVien.Text;

            kiemTraThem = false;
            TrangThaiNutChucNang(false);
            txtMaNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa nhân viên có mã " 
                + txtMaNhanVien.Text + " không?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from T_NhanVien where MaNV = N'" + txtMaNhanVien.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                txtMaNhanVien.Clear();
                txtTenNhanVien.Clear();
                txtPhai.Clear();
                txtChucVu.Clear();
                txtDiaChi.Clear();
                txtThanhPho.Clear();
                txtDienThoai.Clear();


                LayDuLieu();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNhanVien.Focus(); return;
            }
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenNhanVien.Focus(); return;
            }
            if (!dtpFlag)
            {
                MessageBox.Show("Chưa nhập ngày sinh nhân viên.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpNgaySinh.Focus(); return;
            }
            if (txtPhai.Text == "")
            {
                MessageBox.Show("Chưa nhập phái nhân viên.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhai.Focus(); return;
            }
            if (txtChucVu.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtChucVu.Focus(); return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiaChi.Focus(); return;
            }
            if (txtThanhPho.Text == "")
            {
                MessageBox.Show("Chưa nhập thành phố/tỉnh.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtThanhPho.Focus(); return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDienThoai.Focus(); return;
            }
            if (kiemTraThem == true)
            {
                if (KiemTraTrungThem(txtMaNhanVien.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (KiemTraTrungSua(txtMaNhanVien.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (kiemTraThem == true)
                sql = "insert into T_NhanVien(MaNV,HoTen,NgaySinh,Phai,ChucVu,DiaChi,TP_Tinh,DienThoai) " + "values(N'" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text + "',N'" +dtpNgaySinh.Value + "',N'" + txtPhai.Text + "',N'" + txtChucVu.Text + "',N'" + txtDiaChi.Text + "',N'" + txtThanhPho.Text + "',N'" + txtDienThoai.Text + "')";
            else
                sql = "update T_NhanVien set MaNV = N'" + txtMaNhanVien.Text + "',HoTen = N'" + txtTenNhanVien.Text + "',NgaySinh = N'" + dtpNgaySinh.Value + "',Phai = N'" + txtPhai.Text + "',ChucVu = N'" + txtChucVu.Text + "',DiaChi = N'" + txtDiaChi.Text + "',TP_Tinh = N'" + txtThanhPho.Text + "',DienThoai = N'" + txtDienThoai.Text + "'where MaNV = N'" + maCu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            TrangThaiNutChucNang(true);
            LayDuLieu();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            TrangThaiNutChucNang(true);
            dgvKhachHang_CellMouseClick(sender, vt);
            return;
        }
        public void TrangThaiNutChucNang(bool b)
        {
            dgvNhanVien.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaNhanVien.ReadOnly = b;
            txtTenNhanVien.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtThanhPho.ReadOnly = b;
            txtDienThoai.ReadOnly = b;

            btnLuu.Enabled = !b;
            btnBoQua.Enabled = !b;
        }

        public void LayDuLieu()
        {
                string maNV = txtMaNhanVienTimKiem.Text;
                string hoTen = txtHoTenTimKiem.Text;

                // Xử lý khi cả hai trường tìm kiếm đều rỗng
                if (string.IsNullOrEmpty(maNV) && string.IsNullOrEmpty(hoTen))
                {
                    // Lấy toàn bộ dữ liệu
                    da = new SqlDataAdapter("SELECT * FROM T_NhanVien", conn);
                }
                else
                {
                    // Lấy dữ liệu tương ứng với MaNV và HoTen
                    string query = "SELECT * FROM T_NhanVien WHERE ";

                    // Xử lý tìm kiếm theo MaNV
                    if (!string.IsNullOrEmpty(maNV))
                    {
                        query += "MaNV LIKE N'%" + maNV + "%' ";
                    }

                    // Xử lý tìm kiếm theo HoTen
                    if (!string.IsNullOrEmpty(hoTen))
                    {
                        if (!string.IsNullOrEmpty(maNV))
                        {
                            query += "OR ";
                        }
                        query += "HoTen LIKE N'%" + hoTen + "%' ";
                    }

                    da = new SqlDataAdapter(query, conn);
                }

                dt = new DataTable();
                da.Fill(dt);

                dgvNhanVien.DataSource = dt;
                lblSoLuongKhachHang.Text = "Số lượng nhân viên là: " + (dgvNhanVien.RowCount - 1);
            


        }

        public bool KiemTraTrungThem(string maNhap)
        {
            sql = "Select * from T_NhanVien where MaNV=N'" + maNhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)//KIEM TRA có dữ liệu hay không có dữ liệu thì true
                return true;
            else
                return false;
        }
        public bool KiemTraTrungSua(string maNhap)
        {
            sql = "Select * from T_NhanVien where MaNV =N'" + maNhap + "' and MaNV<> N'" + maCu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvNhanVien.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                        txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                        txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                        dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                        txtPhai.Text = row.Cells[3].Value.ToString();
                        txtChucVu.Text = row.Cells[4].Value.ToString();
                        txtDiaChi.Text = row.Cells[5].Value.ToString();
                        txtThanhPho.Text = row.Cells[6].Value.ToString();
                        txtDienThoai.Text = row.Cells[7].Value.ToString();

                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtpFlag = true;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
