using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using giuaky.Model;

namespace giuaky
{
    public partial class Form1 : Form
    {
        private Model1 dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new Model1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadDataGridViewSinhVien();
        }

        private void LoadComboBoxLop()
        {
            try
            {
                var listLop = dbContext.Lop.ToList();
                cbblop.DataSource = listLop;
                cbblop.DisplayMember = "TenLop";
                cbblop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lớp: " + ex.Message);
            }
        }

        private void LoadDataGridViewSinhVien()
        {
            try
            {
                // Sử dụng AsEnumerable() để thực hiện xử lý ngoài database
                var listSinhVien = dbContext.SinhVien
                    .Include("Lop")
                    .AsEnumerable()
                    .Select(sv => new
                    {
                        MSSV = sv.MaSV,
                        HoTen = sv.HoTenSV,
                        NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                        Lop = sv.Lop.TenLop
                    })
                    .ToList();

                dgvSinhVien.DataSource = listSinhVien; // Gán dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " + ex.Message);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtmssv.Text) || string.IsNullOrWhiteSpace(txtHoten.Text) || string.IsNullOrWhiteSpace(cbbNgaySinh.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                var sinhVien = new SinhVien
                {
                    MaSV = txtmssv.Text.Trim(),
                    HoTenSV = txtHoten.Text.Trim(),
                    NgaySinh = DateTime.Parse(cbbNgaySinh.Text),  // Chắc chắn rằng người dùng nhập ngày hợp lệ
                    MaLop = cbblop.SelectedValue.ToString()
                };

                dbContext.SinhVien.Add(sinhVien);
                dbContext.SaveChanges();
                MessageBox.Show("Thêm sinh viên thành công!");
                LoadDataGridViewSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow != null)
                {
                    string maSV = dgvSinhVien.CurrentRow.Cells["MSSV"].Value.ToString(); // Đảm bảo bạn sử dụng đúng tên cột
                    var sinhVien = dbContext.SinhVien.FirstOrDefault(sv => sv.MaSV == maSV);

                    if (sinhVien != null)
                    {
                        dbContext.SinhVien.Remove(sinhVien);
                        dbContext.SaveChanges();
                        MessageBox.Show("Xóa sinh viên thành công!");
                        LoadDataGridViewSinhVien(); // Tải lại danh sách sinh viên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message);
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow != null)
                {
                    string maSV = dgvSinhVien.CurrentRow.Cells["MSSV"].Value.ToString(); // Sử dụng tên cột đúng
                    var sinhVien = dbContext.SinhVien.FirstOrDefault(sv => sv.MaSV == maSV);

                    if (sinhVien != null)
                    {
                        sinhVien.HoTenSV = txtHoten.Text.Trim();
                        sinhVien.NgaySinh = DateTime.Parse(cbbNgaySinh.Text); // Cập nhật lại ngày sinh
                        sinhVien.MaLop = cbblop.SelectedValue.ToString(); // Cập nhật lại lớp

                        dbContext.SaveChanges();
                        MessageBox.Show("Sửa sinh viên thành công!");
                        LoadDataGridViewSinhVien(); // Tải lại danh sách sinh viên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sinh viên: " + ex.Message);
            }
        }
    private void btnthoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy từ khóa tìm kiếm từ TextBox
                string keyword = txtTimKiem.Text.Trim().ToLower(); // Chuyển thành chữ thường để tìm kiếm không phân biệt hoa thường

                // Kiểm tra nếu từ khóa rỗng
                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    return;
                }

                // Tìm sinh viên theo MSSV hoặc Họ tên
                var searchResults = dbContext.SinhVien
                    .Where(sv => sv.MaSV.Contains(keyword) || sv.HoTenSV.ToLower().Contains(keyword))
                    .Include("Lop") // Bao gồm thông tin lớp
                    .Select(sv => new
                    {
                        MSSV = sv.MaSV,
                        HoTen = sv.HoTenSV,
                        NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                        Lop = sv.Lop.TenLop
                    })
                    .ToList();

                // Hiển thị kết quả tìm kiếm vào DataGridView
                dgvSinhVien.DataSource = searchResults;

                if (searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào khớp với từ khóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tất cả các dòng trong DataGridView
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    // Kiểm tra xem dòng có phải là dòng mới không (không phải dòng trống)
                    if (row.IsNewRow) continue;

                    // Lấy giá trị từ các cột của DataGridView
                    string maSV = row.Cells["Column1"].Value.ToString();
                    string hoTen = row.Cells["Column2"].Value.ToString();
                    string ngaySinhText = row.Cells["Column3"].Value.ToString();
                    string tenLop = row.Cells["Column4"].Value.ToString();

                    // Tìm đối tượng SinhVien trong cơ sở dữ liệu
                    var sinhVien = dbContext.SinhVien.FirstOrDefault(sv => sv.MaSV == maSV);

                    // Nếu sinh viên đã tồn tại, cập nhật thông tin
                    if (sinhVien != null)
                    {
                        sinhVien.HoTenSV = hoTen;
                        sinhVien.NgaySinh = DateTime.Parse(ngaySinhText);
                        sinhVien.MaLop = dbContext.Lop.FirstOrDefault(lop => lop.TenLop == tenLop)?.MaLop;
                    }
                    else
                    {
                        // Nếu sinh viên chưa tồn tại, thêm mới
                        sinhVien = new SinhVien
                        {
                            MaSV = maSV,
                            HoTenSV = hoTen,
                            NgaySinh = DateTime.Parse(ngaySinhText),
                            MaLop = dbContext.Lop.FirstOrDefault(lop => lop.TenLop == tenLop)?.MaLop
                        };

                        dbContext.SinhVien.Add(sinhVien);
                    }
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                dbContext.SaveChanges();
                MessageBox.Show("Dữ liệu đã được lưu thành công!");
                LoadDataGridViewSinhVien(); // Tải lại dữ liệu mới sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

    }
}






