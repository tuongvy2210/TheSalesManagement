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
    public partial class frmQuanLyNhomHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool ktThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        public frmQuanLyNhomHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhomHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            LayDuLieu();
            KhoaMo(true);
        }

        public void LayDuLieu()
        {
            da = new SqlDataAdapter("Select * From T_NhomHang", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgvNhomHang.DataSource = dt;
            lblSoNhomHang.Text = "Có " + (dt.Rows.Count) + " nhóm hàng.";
        }

        public void KhoaMo(bool b)
        {
            dgvNhomHang.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaNhom.ReadOnly = b;
            txtTenNhom.ReadOnly = b;

            btnGhi.Enabled = !b;
            btnKhong.Enabled = !b;
        }

        public bool ktTrungThem(string maNhap)
        {

            sql = "Select * From T_NhomHang Where MaNhom =N'" + maNhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        public bool ktTrungSua(string maNhap)
        {

            sql = "Select *From T_NhomHang Where MaNhom =N'" + maNhap + "'and MaNhom<> N'" + maCu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        private void dgvNhomHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvNhomHang.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvNhomHang.Rows[e.RowIndex];
                        txtMaNhom.Text = row.Cells[0].Value.ToString();
                        txtTenNhom.Text = row.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhom.Clear();
            txtTenNhom.Clear();
            ktThem = true;
            KhoaMo(false);
            txtMaNhom.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhom.Text == "") return;
            maCu = txtMaNhom.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaNhom.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhom.Text == "") return;
            DialogResult kq = MessageBox.Show("Xác nhận xóa nhóm hàng " + txtMaNhom.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from T_NhomHang where MaNhom = N'" + txtMaNhom.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtMaNhom.Text = "";
                txtTenNhom.Text = "";
                LayDuLieu();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaNhom.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhóm.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNhom.Focus(); 
                return;
            }
            if (txtTenNhom.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenNhom.Focus(); 
                return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtMaNhom.Text) == true)
                {
                    MessageBox.Show("Mã nhóm đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaNhom.Text) == true)
                {
                    MessageBox.Show("Mã nhóm đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into T_NhomHang(MaNhom,TenNhom) values(N'" + txtMaNhom.Text + "',N'" + txtTenNhom.Text + "')";
            else
                sql = "update T_NhomHang set MaNhom=N'" + txtMaNhom.Text + "', TenNhom=N'" + txtTenNhom.Text + "' where MaNhom=N'" + maCu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            LayDuLieu();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgvNhomHang_CellMouseClick(sender, vt);
            return;
        }

        
    }
}
