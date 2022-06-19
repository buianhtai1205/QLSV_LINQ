using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLSV_LinQ.BS_layer;

namespace QLSV_LinQ
{
    public partial class frmQuanLy : Form
    {
        string err;
        BLSinhVien dbSV = new BLSinhVien();
        bool themSV;
        BLMonHoc dbMH = new BLMonHoc();
        bool themMH;
        BLKhoa dbKhoa = new BLKhoa();
        bool themKhoa;
        BLLop dbLop = new BLLop();
        bool themLop;
        BLDiem dbDiem = new BLDiem();
        bool themDiem;

        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            loadMonHoc();
            loadSinhVien();
            loadKhoa();
            loadLop();
            loadDiem();
        }


        #region SinhVien
        void loadSinhVien()
        {
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvSV.DataSource = dbSV.LaySinhVien();
                // Thay đổi độ rộng cột
                dtgvSV.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtMaSV.ResetText();
                this.txtMaLop.ResetText();
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();
                this.txtEmail.ResetText();
                this.txtGioiTinh.ResetText();
                this.txtHoTenSV.ResetText();
                this.txtMatKhau.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuSV.Enabled = false;
                this.btnHuySV.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewSinhViens.Enabled = true;
                this.btnThemSV.Enabled = true;
                this.btnSuaSV.Enabled = true;
                this.btnXoaSV.Enabled = true;

                dtgvSV_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }
        private void btnViewSinhViens_Click(object sender, EventArgs e)
        {
            loadSinhVien();
        }

        private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSV.CurrentCell != null)
            {
                int r = dtgvSV.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaSV.Text = dtgvSV.Rows[r].Cells[0].Value.ToString();
                this.txtMaLop.Text = dtgvSV.Rows[r].Cells[7].Value.ToString();
                this.txtEmail.Text = dtgvSV.Rows[r].Cells[2].Value.ToString();
                this.txtMatKhau.Text = dtgvSV.Rows[r].Cells[3].Value.ToString();
                this.txtHoTenSV.Text = dtgvSV.Rows[r].Cells[1].Value.ToString();
                this.txtGioiTinh.Text = dtgvSV.Rows[r].Cells[4].Value.ToString();
                this.txtDienThoai.Text = dtgvSV.Rows[r].Cells[6].Value.ToString();
                this.txtDiaChi.Text = dtgvSV.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            // Kích hoạt Thêm
            themSV = true;
            // Xóa trống các đối tượng trong panel
            this.txtMaSV.ResetText();
            this.txtMaLop.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtEmail.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtHoTenSV.ResetText();
            this.txtMatKhau.ResetText();
            // Cho phép thao tác trên Lưu/Hủy
            this.btnLuuSV.Enabled = true;
            this.btnHuySV.Enabled = true;
            // Không cho phép thao tác trên Thêm/Sửa/Xóa
            this.btnThemSV.Enabled = false;
            this.btnSuaSV.Enabled = false;
            this.btnXoaSV.Enabled = false;
            // Đưa con trỏ chuột đến txtMaSV
            this.txtMaSV.Focus();
        }

        private void btnTaoMK_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            this.txtMatKhau.Text = mk;
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            if (themSV)
            {
                try
                {
                    BLSinhVien blSV = new BLSinhVien();
                    blSV.ThemSinhVien(
                            this.txtMaSV.Text.Trim(),
                            this.txtMaLop.Text.Trim(),
                            this.txtEmail.Text.Trim(),
                            this.txtMatKhau.Text.Trim(),
                            this.txtHoTenSV.Text.Trim(),
                            this.txtGioiTinh.Text.Trim(),
                            this.txtDienThoai.Text.Trim(),
                            this.txtDiaChi.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadSinhVien();
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Không thêm được, Lỗi rồi! " + err);
                }
            }
            else
            {
                try
                {
                    BLSinhVien blSV = new BLSinhVien();
                    blSV.CapNhatSinhVien(
                            this.txtMaSV.Text.Trim(),
                            this.txtMaLop.Text.Trim(),
                            this.txtEmail.Text.Trim(),
                            this.txtMatKhau.Text.Trim(),
                            this.txtHoTenSV.Text.Trim(),
                            this.txtGioiTinh.Text.Trim(),
                            this.txtDienThoai.Text.Trim(),
                            this.txtDiaChi.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadSinhVien();
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi! " + err);
                }
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            // Kích hoạt sửa
            themSV = false;
            // Cho phép thao tác Lưu/Hủy
            dtgvSV_CellClick(null, null);
            this.btnLuuSV.Enabled = true;
            this.btnHuySV.Enabled = true;
            // Không cho thao tác Thêm/Xóa/Xem
            this.btnThemSV.Enabled = false;
            this.btnXoaSV.Enabled = false;
            this.btnViewSinhViens.Enabled = false;
            this.txtMaSV.Enabled = false;
            // Đưa con trỏ chuột đến MaSV
            this.txtMaLop.Focus();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thự tự dòng hiện hành
                int r = dtgvSV.CurrentCell.RowIndex;
                // Lấy MaSV hiện hành
                string strMaSV = dtgvSV.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbSV.XoaSinhVien(strMaSV, ref err);
                    // Cập nhật lại DataGridView 
                    loadSinhVien();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại. Lỗi rồi! " + err);
            }
        }

        private void btnHuySV_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong panel
            this.txtMaSV.ResetText();
            this.txtMaLop.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtEmail.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtHoTenSV.ResetText();
            this.txtMatKhau.ResetText();
            // Không cho thao tác trên các nút Lưu/Hủy
            this.btnLuuSV.Enabled = false;
            this.btnHuySV.Enabled = false;
            // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
            this.btnViewSinhViens.Enabled = true;
            this.btnThemSV.Enabled = true;
            this.btnSuaSV.Enabled = true;
            this.btnXoaSV.Enabled = true;

            dtgvSV_CellClick(null, null);
        }

        private void txtSearchSV_Click(object sender, EventArgs e)
        {
            this.txtSearchSV.ResetText();
            this.txtSearchSV.Focus();
        }

        private void txtSearchSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strSearch = this.txtSearchSV.Text.Trim();
                try
                {
                    // Đưa dữ liệu lên datagridview
                    dtgvSV.DataSource = dbSV.LaySinhVien(strSearch);
                    // Thay đổi độ rộng cột
                    dtgvSV.AutoResizeColumns();
                    // Xóa trống các đối tượng trong panel
                    this.txtMaSV.ResetText();
                    this.txtMaLop.ResetText();
                    this.txtDiaChi.ResetText();
                    this.txtDienThoai.ResetText();
                    this.txtEmail.ResetText();
                    this.txtGioiTinh.ResetText();
                    this.txtHoTenSV.ResetText();
                    this.txtMatKhau.ResetText();
                    // Không cho thao tác trên các nút Lưu/Hủy
                    this.btnLuuSV.Enabled = false;
                    this.btnHuySV.Enabled = false;
                    // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                    this.btnViewSinhViens.Enabled = true;
                    this.btnThemSV.Enabled = true;
                    this.btnSuaSV.Enabled = true;
                    this.btnXoaSV.Enabled = true;

                    dtgvSV_CellClick(null, null);

                }
                catch
                {
                    MessageBox.Show("Không tìm kiếm được dữ liệu. Lỗi rồi! ");
                }
            }
        }

        #endregion SinhVien

        #region MonHoc
        void loadMonHoc()
        {
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvMonHoc.DataSource = dbMH.LayMonHoc();
                // Thay đổi độ rộng cột
                dtgvMonHoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtMaMonHoc.ResetText();
                this.txtTenMonHoc.ResetText();
                this.txtSoTinChiMonHoc.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuMH.Enabled = false;
                this.btnHuyMH.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewMonHoc.Enabled = true;
                this.btnAddMonHoc.Enabled = true;
                this.btnEditMonHoc.Enabled = true;
                this.btnDeleteMonHoc.Enabled = true;

                dtgvMonHoc_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }

        private void dtgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMonHoc.CurrentCell != null)
            {
                int r = dtgvMonHoc.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaMonHoc.Text = dtgvMonHoc.Rows[r].Cells[0].Value.ToString();
                this.txtTenMonHoc.Text = dtgvMonHoc.Rows[r].Cells[1].Value.ToString();
                this.txtSoTinChiMonHoc.Text = dtgvMonHoc.Rows[r].Cells[2].Value.ToString();
            }
        }

        private void btnViewMonHoc_Click(object sender, EventArgs e)
        {
            loadMonHoc();
        }

        private void btnAddMonHoc_Click(object sender, EventArgs e)
        {
            // Kích hoạt Thêm
            themMH = true;
            // Xóa trống các đối tượng trong panel
            this.txtMaMonHoc.ResetText();
            this.txtTenMonHoc.ResetText();
            this.txtSoTinChiMonHoc.ResetText();
            // Cho phép thao tác trên Lưu/Hủy
            this.btnLuuMH.Enabled = true;
            this.btnHuyMH.Enabled = true;
            // Không cho phép thao tác trên Thêm/Sửa/Xóa
            this.btnAddMonHoc.Enabled = false;
            this.btnEditMonHoc.Enabled = false;
            this.btnDeleteMonHoc.Enabled = false;
            // Đưa con trỏ chuột đến txtMaMonHoc
            this.txtMaMonHoc.Focus();
        }

        private void btnEditMonHoc_Click(object sender, EventArgs e)
        {
            // Kích hoạt sửa
            themMH = false;
            // Cho phép thao tác Lưu/Hủy
            dtgvMonHoc_CellClick(null, null);
            this.btnLuuMH.Enabled = true;
            this.btnHuyMH.Enabled = true;
            // Không cho thao tác Thêm/Xóa/Xem
            this.btnAddMonHoc.Enabled = false;
            this.btnDeleteMonHoc.Enabled = false;
            this.btnViewMonHoc.Enabled = false;
            this.txtMaMonHoc.Enabled = false;
            // Đưa con trỏ chuột đến txtTenMonHoc
            this.txtTenMonHoc.Focus();
        }

        private void btnHuyMH_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong panel
            this.txtMaMonHoc.ResetText();
            this.txtTenMonHoc.ResetText();
            this.txtSoTinChiMonHoc.ResetText();
            // Không cho thao tác trên các nút Lưu/Hủy
            this.btnLuuMH.Enabled = false;
            this.btnHuyMH.Enabled = false;
            // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
            this.btnViewMonHoc.Enabled = true;
            this.btnAddMonHoc.Enabled = true;
            this.btnEditMonHoc.Enabled = true;
            this.btnDeleteMonHoc.Enabled = true;

            dtgvMonHoc_CellClick(null, null);
        }

        private void btnLuuMH_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            if (themMH)
            {
                try
                {
                    BLMonHoc blMH = new BLMonHoc();
                    blMH.ThemMonHoc(
                            this.txtMaMonHoc.Text.Trim(),
                            this.txtTenMonHoc.Text.Trim(),
                            this.txtSoTinChiMonHoc.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadMonHoc();
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Không thêm được, Lỗi rồi! " + err);
                }
            }
            else
            {
                try
                {
                    BLMonHoc blMH = new BLMonHoc();
                    blMH.CapNhatMonHoc(
                            this.txtMaMonHoc.Text.Trim(),
                            this.txtTenMonHoc.Text.Trim(),
                            this.txtSoTinChiMonHoc.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadMonHoc();
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi! " + err);
                }
            }
        }

        private void btnDeleteMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thự tự dòng hiện hành
                int r = dtgvMonHoc.CurrentCell.RowIndex;
                // Lấy MaMH hiện hành
                string strMaMH = dtgvMonHoc.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbMH.XoaMonHoc(strMaMH, ref err);
                    // Cập nhật lại DataGridView 
                    loadMonHoc();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại. Lỗi rồi! " + err);
            }
        }

        private void txtSearchMonHoc_Click(object sender, EventArgs e)
        {
            this.txtSearchMonHoc.ResetText();
            this.txtSearchMonHoc.Focus();
        }

        private void txtSearchMonHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strSearch = this.txtSearchMonHoc.Text.Trim();
                try
                {
                    try
                    {
                        // Đưa dữ liệu lên datagridview
                        dtgvMonHoc.DataSource = dbMH.LayMonHoc(strSearch);
                        // Thay đổi độ rộng cột
                        dtgvMonHoc.AutoResizeColumns();
                        // Xóa trống các đối tượng trong panel
                        this.txtMaMonHoc.ResetText();
                        this.txtTenMonHoc.ResetText();
                        this.txtSoTinChiMonHoc.ResetText();
                        // Không cho thao tác trên các nút Lưu/Hủy
                        this.btnLuuMH.Enabled = false;
                        this.btnHuyMH.Enabled = false;
                        // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                        this.btnViewMonHoc.Enabled = true;
                        this.btnAddMonHoc.Enabled = true;
                        this.btnEditMonHoc.Enabled = true;
                        this.btnDeleteMonHoc.Enabled = true;

                        dtgvMonHoc_CellClick(null, null);

                    }
                    catch
                    {
                        MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
                    }
                }
                catch
                {
                    MessageBox.Show("Không tìm kiếm được dữ liệu. Lỗi rồi! ");
                }
            }
        }

        #endregion MonHoc

        #region Khoa
        void loadKhoa()
        {
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvKhoa.DataSource = dbKhoa.LayKhoa();
                // Thay đổi độ rộng cột
                dtgvKhoa.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtMaKhoa.ResetText();
                this.txtTenKhoa.ResetText();
                this.txtNBD.ResetText();
                this.txtNKT.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuKhoa.Enabled = false;
                this.btnHuyKhoa.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewKhoa.Enabled = true;
                this.btnAddKhoa.Enabled = true;
                this.btnEditKhoa.Enabled = true;
                this.btnDeleteKhoa.Enabled = true;

                dtgvKhoa_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvKhoa.CurrentCell != null)
            {
                int r = dtgvKhoa.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaKhoa.Text = dtgvKhoa.Rows[r].Cells[0].Value.ToString();
                this.txtTenKhoa.Text =
                dtgvKhoa.Rows[r].Cells[1].Value.ToString();
                this.txtNBD.Text = dtgvKhoa.Rows[r].Cells[2].Value.ToString();
                this.txtNKT.Text = dtgvKhoa.Rows[r].Cells[3].Value.ToString();

            }
        }

        private void btnViewKhoa_Click(object sender, EventArgs e)
        {
            loadKhoa();
        }

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            // Kích hoạt Thêm
            themKhoa = true;
            // Xóa trống các đối tượng trong panel
            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();
            this.txtNBD.ResetText();
            this.txtNKT.ResetText();
            // Cho phép thao tác trên Lưu/Hủy
            this.btnLuuKhoa.Enabled = true;
            this.btnHuyKhoa.Enabled = true;
            // Không cho phép thao tác trên Thêm/Sửa/Xóa
            this.btnAddKhoa.Enabled = false;
            this.btnEditKhoa.Enabled = false;
            this.btnDeleteKhoa.Enabled = false;
            // Đưa con trỏ chuột đến txtMaKhoa
            this.txtMaKhoa.Focus();
        }

        private void btnEditKhoa_Click(object sender, EventArgs e)
        {
            // Kích hoạt sửa
            themKhoa = false;
            // Cho phép thao tác Lưu/Hủy
            dtgvKhoa_CellClick(null, null);
            this.btnLuuKhoa.Enabled = true;
            this.btnHuyKhoa.Enabled = true;
            // Không cho thao tác Thêm/Xóa/Xem
            this.btnAddKhoa.Enabled = false;
            this.btnDeleteKhoa.Enabled = false;
            this.btnViewKhoa.Enabled = false;
            this.txtMaKhoa.Enabled = false;
            // Đưa con trỏ chuột đến txtTenKhoa
            this.txtTenKhoa.Focus();
        }

        private void btnHuyKhoa_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong panel
            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();
            this.txtNBD.ResetText();
            this.txtNKT.ResetText();
            // Không cho thao tác trên các nút Lưu/Hủy
            this.btnLuuKhoa.Enabled = false;
            this.btnHuyKhoa.Enabled = false;
            // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
            this.btnViewKhoa.Enabled = true;
            this.btnAddKhoa.Enabled = true;
            this.btnEditKhoa.Enabled = true;
            this.btnDeleteKhoa.Enabled = true;

            dtgvKhoa_CellClick(null, null);
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            if (themKhoa)
            {
                try
                {
                    BLKhoa blK = new BLKhoa();
                    blK.ThemKhoa(
                            this.txtMaKhoa.Text.Trim(),
                            this.txtTenKhoa.Text.Trim(),
                            this.txtNBD.Text.Trim(),
                            this.txtNKT.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadKhoa();
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Không thêm được, Lỗi rồi! " + err);
                }
            }
            else
            {
                try
                {
                    BLKhoa blK = new BLKhoa();
                    blK.CapNhatKhoa(
                            this.txtMaKhoa.Text.Trim(),
                            this.txtTenKhoa.Text.Trim(),
                            this.txtNBD.Text.Trim(),
                            this.txtNKT.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadKhoa();
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi! " + err);
                }
            }
        }

        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thự tự dòng hiện hành
                int r = dtgvKhoa.CurrentCell.RowIndex;
                // Lấy MaSV hiện hành
                string strMaKhoa = dtgvKhoa.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbKhoa.XoaKhoa(strMaKhoa, ref err);
                    // Cập nhật lại DataGridView 
                    loadKhoa();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại. Lỗi rồi! " + err);
            }
        }

        #endregion Khoa

        #region Lop
        void loadLop()
        {
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvLop.DataSource = dbLop.LayLop();
                // Thay đổi độ rộng cột
                dtgvLop.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtIDLop.ResetText();
                this.txtIDKhoa.ResetText();
                this.txtTenNganh.ResetText();
                this.txtTenLop.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuLop.Enabled = false;
                this.btnHuyLop.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewLop.Enabled = true;
                this.btnAddLop.Enabled = true;
                this.btnEditLop.Enabled = true;
                this.btnDeleteLop.Enabled = true;

                dtgvLop_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvLop.CurrentCell != null)
            {
                int r = dtgvLop.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtIDLop.Text = dtgvLop.Rows[r].Cells[0].Value.ToString();
                this.txtIDKhoa.Text = dtgvLop.Rows[r].Cells[1].Value.ToString();
                this.txtTenNganh.Text = dtgvLop.Rows[r].Cells[2].Value.ToString();
                this.txtTenLop.Text = dtgvLop.Rows[r].Cells[3].Value.ToString();

            }
        }

        private void btnViewLop_Click(object sender, EventArgs e)
        {
            loadLop();
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            // Kích hoạt Thêm
            themLop = true;
            // Xóa trống các đối tượng trong panel
            this.txtIDLop.ResetText();
            this.txtIDKhoa.ResetText();
            this.txtTenNganh.ResetText();
            this.txtTenLop.ResetText();
            // Cho phép thao tác trên Lưu/Hủy
            this.btnLuuLop.Enabled = true;
            this.btnHuyLop.Enabled = true;
            // Không cho phép thao tác trên Thêm/Sửa/Xóa
            this.btnAddLop.Enabled = false;
            this.btnEditLop.Enabled = false;
            this.btnDeleteLop.Enabled = false;
            // Đưa con trỏ chuột đến txtIDLop
            this.txtIDLop.Focus();
        }

        private void btnEditLop_Click(object sender, EventArgs e)
        {
            // Kích hoạt sửa
            themLop = false;
            // Cho phép thao tác Lưu/Hủy
            dtgvLop_CellClick(null, null);
            this.btnLuuLop.Enabled = true;
            this.btnHuyLop.Enabled = true;
            // Không cho thao tác Thêm/Xóa/Xem
            this.btnAddLop.Enabled = false;
            this.btnDeleteLop.Enabled = false;
            this.btnViewLop.Enabled = false;
            this.txtIDLop.Enabled = false;
            // Đưa con trỏ chuột đến txtIDKhoa
            this.txtIDKhoa.Focus();
        }

        private void btnHuyLop_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong panel
            this.txtIDLop.ResetText();
            this.txtIDKhoa.ResetText();
            this.txtTenNganh.ResetText();
            this.txtTenLop.ResetText();
            // Không cho thao tác trên các nút Lưu/Hủy
            this.btnLuuLop.Enabled = false;
            this.btnHuyLop.Enabled = false;
            // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
            this.btnViewLop.Enabled = true;
            this.btnAddLop.Enabled = true;
            this.btnEditLop.Enabled = true;
            this.btnDeleteLop.Enabled = true;

            dtgvLop_CellClick(null, null);
        }

        private void btnLuuLop_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            if (themLop)
            {
                try
                {
                    BLLop blL = new BLLop();
                    blL.ThemLop(
                            this.txtIDLop.Text.Trim(),
                            this.txtIDKhoa.Text.Trim(),
                            this.txtTenNganh.Text.Trim(),
                            this.txtTenLop.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadLop();
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Không thêm được, Lỗi rồi! " + err);
                }
            }
            else
            {
                try
                {
                    BLLop blL = new BLLop();
                    blL.CapNhatLop(
                            this.txtIDLop.Text.Trim(),
                            this.txtIDKhoa.Text.Trim(),
                            this.txtTenNganh.Text.Trim(),
                            this.txtTenLop.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadLop();
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi! " + err);
                }
            }
        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thự tự dòng hiện hành
                int r = dtgvLop.CurrentCell.RowIndex;
                // Lấy MaLop hiện hành
                string strMaLop = dtgvLop.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbLop.XoaLop(strMaLop, ref err);
                    // Cập nhật lại DataGridView 
                    loadLop();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại. Lỗi rồi! " + err);
            }
        }

        #endregion Lop

        #region Diem
        void loadDiem()
        {
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvDiem.DataSource = dbDiem.LayDiem();
                // Thay đổi độ rộng cột
                dtgvDiem.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtIDSV.ResetText();
                this.txtHTSV.ResetText();
                this.txtTL.ResetText();
                this.txtTMH.ResetText();
                this.txtDQT.ResetText();
                this.txtDT.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuDiem.Enabled = false;
                this.btnHuyDiem.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewDiem.Enabled = true;
                this.btnAddDiem.Enabled = true;
                this.btnEditDiem.Enabled = true;
                this.btnDeleteDiem.Enabled = true;

                dtgvDiem_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }

        private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDiem.CurrentCell != null)
            {
                int r = dtgvDiem.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtIDSV.Text = dtgvDiem.Rows[r].Cells[0].Value.ToString();
                this.txtHTSV.Text = dtgvDiem.Rows[r].Cells[1].Value.ToString();
                this.txtTL.Text = dtgvDiem.Rows[r].Cells[2].Value.ToString();
                this.txtTMH.Text = dtgvDiem.Rows[r].Cells[3].Value.ToString();
                this.txtDQT.Text = dtgvDiem.Rows[r].Cells[4].Value.ToString();
                this.txtDT.Text = dtgvDiem.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void btnViewDiem_Click(object sender, EventArgs e)
        {
            loadDiem();
        }

        private void txtSearchDiem_Click(object sender, EventArgs e)
        {
            this.txtSearchDiem.ResetText();
            this.txtSearchDiem.Focus();
        }

        private void btnSearchDiem_Click(object sender, EventArgs e)
        {
            string strSearch = this.txtSearchDiem.Text.Trim();
            try
            {
                // Đưa dữ liệu lên datagridview
                dtgvDiem.DataSource = dbDiem.LayDiem(strSearch);
                // Thay đổi độ rộng cột
                dtgvDiem.AutoResizeColumns();
                // Xóa trống các đối tượng trong panel
                this.txtIDSV.ResetText();
                this.txtHTSV.ResetText();
                this.txtTL.ResetText();
                this.txtTMH.ResetText();
                this.txtDQT.ResetText();
                this.txtDT.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy
                this.btnLuuDiem.Enabled = false;
                this.btnHuyDiem.Enabled = false;
                // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
                this.btnViewDiem.Enabled = true;
                this.btnAddDiem.Enabled = true;
                this.btnEditDiem.Enabled = true;
                this.btnDeleteDiem.Enabled = true;

                //dtgvMonHoc_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi rồi! ");
            }
        }

        private void btnAddDiem_Click(object sender, EventArgs e)
        {
            // Kích hoạt Thêm
            themDiem = true;
            // Xóa trống các đối tượng trong panel
            this.txtIDSV.ResetText();
            this.txtHTSV.ResetText();
            this.txtTL.ResetText();
            this.txtTMH.ResetText();
            this.txtDQT.ResetText();
            this.txtDT.ResetText();
            // Cho phép thao tác trên Lưu/Hủy
            this.btnLuuDiem.Enabled = true;
            this.btnHuyDiem.Enabled = true;
            // Không cho phép thao tác trên Thêm/Sửa/Xóa
            this.btnAddDiem.Enabled = false;
            this.btnEditDiem.Enabled = false;
            this.btnDeleteDiem.Enabled = false;
            // Đưa con trỏ chuột đến txtIDSV
            this.txtIDSV.Focus();
        }

        private void btnEditDiem_Click(object sender, EventArgs e)
        {
            // Kích hoạt sửa
            themDiem = false;
            // Cho phép thao tác Lưu/Hủy
            dtgvDiem_CellClick(null, null);
            this.btnLuuDiem.Enabled = true;
            this.btnHuyDiem.Enabled = true;
            // Không cho thao tác Thêm/Xóa/Xem
            this.btnAddDiem.Enabled = false;
            this.btnDeleteDiem.Enabled = false;
            this.btnViewDiem.Enabled = false;
            this.txtIDSV.Enabled = false;
            this.txtHTSV.Enabled = false;
            this.txtTL.Enabled = false;
            this.txtTMH.Enabled = false;
            // Đưa con trỏ chuột đến txtDQT
            this.txtDQT.Focus();
        }

        private void btnHuyDiem_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong panel
            this.txtIDSV.ResetText();
            this.txtHTSV.ResetText();
            this.txtTL.ResetText();
            this.txtTMH.ResetText();
            this.txtDQT.ResetText();
            this.txtDT.ResetText();
            // Không cho thao tác trên các nút Lưu/Hủy
            this.btnLuuDiem.Enabled = false;
            this.btnHuyDiem.Enabled = false;
            // Cho phép thao tác trên các nút Xem/Thêm/Sửa/Xóa
            this.btnViewDiem.Enabled = true;
            this.btnAddDiem.Enabled = true;
            this.btnEditDiem.Enabled = true;
            this.btnDeleteDiem.Enabled = true;

            dtgvDiem_CellClick(null, null);
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            if (themDiem)
            {
                try
                {
                    BLDiem blD = new BLDiem();
                    blD.ThemDiem(
                            this.txtIDSV.Text.Trim(),
                            this.txtHTSV.Text.Trim(),
                            this.txtTL.Text.Trim(),
                            this.txtTMH.Text.Trim(),
                            this.txtDQT.Text.Trim(),
                            this.txtDT.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadDiem();
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Không thêm được, Lỗi rồi! " + err);
                }
            }
            else
            {
                try
                {
                    BLDiem blD = new BLDiem();
                    blD.CapNhatDiem(
                            this.txtIDSV.Text.Trim(),
                            this.txtTMH.Text.Trim(),
                            this.txtDQT.Text.Trim(),
                            this.txtDT.Text.Trim(),
                            ref err
                        );
                    //Load lại data
                    loadDiem();
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi! " + err);
                }
            }
        }

        private void btnDeleteDiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thự tự dòng hiện hành
                int r = dtgvDiem.CurrentCell.RowIndex;
                // Lấy MaSV hiện hành
                string strMaSV = dtgvDiem.Rows[r].Cells[0].Value.ToString();
                string strTenMH = dtgvDiem.Rows[r].Cells[3].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbDiem.XoaDiem(strMaSV,strTenMH, ref err);
                    // Cập nhật lại DataGridView 
                    loadDiem();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại. Lỗi rồi! " + err);
            }
        }

        #endregion Diem
    }
}
