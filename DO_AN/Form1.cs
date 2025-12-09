using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Form1 : Form
    {
        quanLyXe qlx = new quanLyXe();
        AVLTree avl = new AVLTree();
        string path = Application.StartupPath + "\\car_sales_data.csv";
        List<Xe> dsXe = new List<Xe>();
        List<Xe> dsTrung = new List<Xe>(); 


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        { }

        private void btnGhiFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dsXe.Count > 0)
                {
                    qlx.GhiFileCSV("Xe_Chinh.csv", dsXe);
                }

                if (dsTrung.Count > 0)
                {
                    qlx.GhiFileCSV("Xe_Trung.csv", dsTrung);
                }

                MessageBox.Show("Đã lưu xong danh sách chính và danh sách trùng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        
        private void btnHienThiAVL_Click(object sender, EventArgs e)
        {
            try
            {
                List<Xe> ds = new List<Xe>();
                avl.InOrder(avl.Root, ds);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
                MessageBox.Show(" Hiển thị dữ liệu duyệt theo thứ tự InOrder!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi khi hiển thị cây AVL: " + ex.Message);
            }
        }

        
       

        private void btnDocFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu cũ
                dsXe.Clear();
                dsTrung.Clear();
                avl.Root = null;

                // 1️⃣ Đọc danh sách chính
                if (File.Exists("Xe_Chinh.csv"))
                {
                    dsXe = qlx.DocFileCSV("Xe_Chinh.csv");
                    foreach (var xe in dsXe)
                    {
                        avl.Root = avl.Insert(avl.Root, xe); // Thêm vào AVL
                    }
                }

                // 2️⃣ Đọc danh sách trùng
                if (File.Exists("Xe_Trung.csv"))
                {
                    dsTrung = qlx.DocFileCSV("Xe_Trung.csv");
                    foreach (var xe in dsTrung)
                    {
                        avl.Root = avl.Insert(avl.Root, xe); // Thêm vào AVL
                    }
                }

                // Hiển thị lên DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsXe;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvTrungID.DataSource = null;
                dgvTrungID.DataSource = dsTrung;
                dgvTrungID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                MessageBox.Show("Đã đọc xong file chính và file trùng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }

        }

        private void btnDoCaoCay_Click(object sender, EventArgs e)
        {
            int h = avl.GetTreeHeight();
            MessageBox.Show(" Chiều cao của cây AVL là: " + h);
        }

        private void btnHienThiTheoGia_Click(object sender, EventArgs e)
        {
            List<Xe> ds = new List<Xe>();
            avl.InOrder(avl.Root, ds);
            avl.Root = null;
            foreach (var xe in dsXe)
                avl.Root = avl.Insert1(avl.Root, xe);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MessageBox.Show(" Hiển thị dữ liệu theo Giá bán ");
        }

        private void demLa_Click(object sender, EventArgs e)
        {

            int leafCount = avl.soLa();
            MessageBox.Show(" Số lượng lá của cây AVL là: " + leafCount);
        }

        private void demTrai_Click(object sender, EventArgs e)
        {
            int count = avl.demLaLeft();
            MessageBox.Show($"Tổng số node bên trái: {count}");
        }

        private void demPhai_Click(object sender, EventArgs e)
        {
            int count = avl.demLaRight();
            MessageBox.Show($"Tổng số node bên phải: {count}");
        }

        private void find_Click(object sender, EventArgs e)
        {
            string raw = txtFind.Text.Trim();

            // Lọc chỉ lấy chữ số 0–9
            raw = System.Text.RegularExpressions.Regex.Replace(raw, "[^0-9]", "");

            if (!int.TryParse(raw, out int price))
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ để tìm!");
                return;
            }

            List<Xe> ds = avl.SearchByPrice(avl.Root, price);

            if (ds.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                MessageBox.Show($"Tìm thấy {ds.Count} xe có giá = {price}");
            }
            else
            {
                dataGridView1.DataSource = null;  // Clear bảng
                MessageBox.Show("Không tìm thấy xe nào theo giá này!");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Xe xe = new Xe
            {
                Id = int.Parse(txtId.Text),
                Manufacturer = txtHang.Text,
                Model = txtModel.Text,
                Engine_size = double.Parse(txtDongCo.Text),
                Fuel_type = txtNhienLieu.Text,
                Year_of_manufacture = int.Parse(txtNam.Text),
                Mileage = int.Parse(txtSoKm.Text),
                Price = int.Parse(txtPrice.Text)
            };

            avl.Root = avl.Insert(avl.Root, xe);

            bool isDuplicate = dsXe.Any(x => x.Id == xe.Id || x.Price == xe.Price);

            if (isDuplicate)
            {
                dsTrung.Add(xe);

                dgvTrungID.DataSource = null;
                dgvTrungID.DataSource = dsTrung;
                dgvTrungID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                MessageBox.Show("ID đã tồn tại! Node trùng được thêm vào bảng riêng.");
            }
            else
            {
                dsXe.Add(xe);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsXe;

                MessageBox.Show("Đã thêm xe mới vào AVL và danh sách chính.");
            }

        }
        private bool ValidateInput()
        {
            if (!int.TryParse(txtId.Text.Trim(), out _))
            {
                MessageBox.Show("ID phải là số nguyên!");
                return false;
            }

            if (!double.TryParse(txtDongCo.Text.Trim(), out _))
            {
                MessageBox.Show("Dung tích động cơ phải là số thực!");
                return false;
            }

            if (!int.TryParse(txtNam.Text.Trim(), out _))
            {
                MessageBox.Show("Năm sản xuất phải là số!");
                return false;
            }

            if (!int.TryParse(txtSoKm.Text.Trim(), out _))
            {
                MessageBox.Show("Số Km phải là số!");
                return false;
            }

            if (!int.TryParse(txtPrice.Text.Trim(), out _))
            {
                MessageBox.Show("Giá phải là số!");
                return false;
            }

            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtHang.Text = row.Cells["Manufacturer"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtDongCo.Text = row.Cells["Engine_size"].Value.ToString();
                txtNhienLieu.Text = row.Cells["Fuel_type"].Value.ToString();
                txtNam.Text = row.Cells["Year_of_manufacture"].Value.ToString();
                txtSoKm.Text = row.Cells["Mileage"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }
        private void dgvTrungID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrungID.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtHang.Text = row.Cells["Manufacturer"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtDongCo.Text = row.Cells["Engine_size"].Value.ToString();
                txtNhienLieu.Text = row.Cells["Fuel_type"].Value.ToString();
                txtNam.Text = row.Cells["Year_of_manufacture"].Value.ToString();
                txtSoKm.Text = row.Cells["Mileage"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // ==== Kiểm tra dòng chọn ở bảng TRÙNG ====
                if (dgvTrungID.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvTrungID.SelectedRows[0].Cells["Id"].Value);

                    var item = dsTrung.FirstOrDefault(x => x.Id == id);
                    if (item != null)
                        dsTrung.Remove(item);

                    // Cập nhật DataGridView
                    dgvTrungID.DataSource = null;
                    dgvTrungID.DataSource = dsTrung;
                    dgvTrungID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ghi lại file trùng
                    qlx.GhiFileCSV("Xe_Trung.csv", dsTrung);

                    MessageBox.Show($"Đã xóa xe TRÙNG có ID: {id}");
                    return;   // Ngăn không chạy xuống dưới
                }

                // ==== Kiểm tra dòng chọn ở bảng CHÍNH ====
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    // Xóa trong danh sách chính
                    var xeXoa = dsXe.FirstOrDefault(x => x.Id == id);
                    if (xeXoa != null)
                        dsXe.Remove(xeXoa);

                    // Xóa trong AVL
                    avl.Root = avl.Delete(avl.Root, id);

                    // Load lại DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dsXe;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ghi lại file chính
                    qlx.GhiFileCSV("Xe_Chinh.csv", dsXe);

                    MessageBox.Show($"Đã xóa xe có ID: {id}");
                    return;
                }

                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            int rowIndex = dataGridView1.SelectedRows[0].Index;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

            Xe xe = dsXe.FirstOrDefault(x => x.Id == id);
            if (xe == null)
            {
                MessageBox.Show("Không tìm thấy xe để sửa!");
                return;
            }

            xe.Manufacturer = txtHang.Text;
            xe.Model = txtModel.Text;
            xe.Engine_size = double.Parse(txtDongCo.Text);
            xe.Fuel_type = txtNhienLieu.Text;
            xe.Year_of_manufacture = int.Parse(txtNam.Text);
            xe.Mileage = int.Parse(txtSoKm.Text);
            xe.Price = int.Parse(txtPrice.Text);

            avl.Root = avl.Delete(avl.Root, id);
            avl.Root = avl.Insert(avl.Root, xe);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsXe;

            MessageBox.Show("Đã sửa thông tin xe!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn lưu các thay đổi vào file CSV trước khi thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    qlx.GhiFileCSV(path, dsXe);
                    MessageBox.Show("Đã lưu file CSV thành công!");
                    Application.Exit(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file CSV: " + ex.Message);
                }
            }
            else if (result == DialogResult.No)
            {
                
                Application.Exit();
            }
            else
            {

                return;
            }
        }

        private void btnHienThiTang_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLevel.Text.Trim(), out int level) || level < 1)
            {
                MessageBox.Show("Vui lòng nhập số tầng hợp lệ!");
                return;
            }

            List<Xe> ds = avl.GetNodesAtSpecificLevel(level);

            if (ds.Count == 0)
            {
                MessageBox.Show($"Tầng {level} không có node nào!");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MessageBox.Show($"Đã hiển thị {ds.Count} node ở tầng {level}!");
        }

        private void btnNode1Con_Click(object sender, EventArgs e)
        {
            List<Xe> list = new List<Xe>();
            GetNodesOneChild(avl.Root, list);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void btnNode2Con_Click(object sender, EventArgs e)
        {
            List<Xe> list = new List<Xe>();
            GetNodesTwoChild(avl.Root, list);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (list.Count == 0)
                MessageBox.Show("Không có node nào có 2 con!");

        }
        public void GetNodesOneChild(NodeAVL root, List<Xe> list)
        {
            if (root == null) return;

            if ((root.Left == null && root.Right != null) ||
                (root.Left != null && root.Right == null))
            {
                list.Add(root.Data); 
            }

            GetNodesOneChild(root.Left, list);
            GetNodesOneChild(root.Right, list);
        }

        public void GetNodesTwoChild(NodeAVL root, List<Xe> list)
        {
            if (root == null) return;

            // node có đúng 2 con
            if (root.Left != null && root.Right != null)
            {
                list.Add(root.Data);
            }

            GetNodesTwoChild(root.Left, list);
            GetNodesTwoChild(root.Right, list);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                int tongXeChinh = dsXe.Count;

                int tongXeTrung = dsTrung.Count;

                int tongGiaXeChinh = dsXe.Sum(x => x.Price);

                int tongGiaXeTrung = dsTrung.Sum(x => x.Price);

                string thongKe = $"Tổng số node: {tongXeChinh}\n" +
                                 $"Tổng số node: {tongXeTrung}\n";
                MessageBox.Show(thongKe, "Thống kê node", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtTim.Text.Trim(), out int price))
                {
                    MessageBox.Show("Vui lòng nhập giá hợp lệ!");
                    return;
                }

                int soLanTrung = dsTrung.Count(x => x.Price == price); 

                if (soLanTrung == 0)
                {
                    MessageBox.Show($"Không có xe nào có giá {price}!");
                }
                else
                {
                    MessageBox.Show($"Có {soLanTrung} xe có giá {price}!");
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm xe theo giá: " + ex.Message);
            }
        }
    }
    }
