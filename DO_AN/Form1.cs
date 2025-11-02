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

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        { }

            // 🔘 Nút Đọc File
     

        // 🔘 Nút Ghi File
        private void btnGhiFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource == null)
                {
                    MessageBox.Show("Không có dữ liệu để ghi!");
                    return;
                }

                dsXe = (List<Xe>)dataGridView1.DataSource;
                qlx.GhiFileCSV(path, dsXe);
                MessageBox.Show("✅ Đã ghi file CSV thành công!\n" + Path.GetFullPath(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi ghi file CSV: " + ex.Message);
            }
        }

        // 🔘 Nút Hiển Thị Duyệt Cây (InOrder)
        private void btnHienThiAVL_Click(object sender, EventArgs e)
        {
            try
            {
                List<Xe> ds = new List<Xe>();
                avl.InOrder(avl.Root, ds);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
                MessageBox.Show("✅ Hiển thị dữ liệu duyệt theo thứ tự InOrder!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi hiển thị cây AVL: " + ex.Message);
            }
        }

        // 🔘 Nút Đo Chiều Cao Cây
       

        private void btnDocFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("File CSV không tồn tại!");
                    return;
                }

                dsXe = qlx.DocFileCSV(path);
  

                // Xây cây AVL


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dsXe;

                MessageBox.Show("✅ Đã đọc file CSV !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi đọc file: " + ex.Message);
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

            MessageBox.Show(" Hiển thị dữ liệu theo Giá bán (tăng dần)");
        }

        private void demLa_Click(object sender, EventArgs e)
        {

            int leafCount = avl.GetLeafCount();
            MessageBox.Show(" Số lượng lá của cây AVL là: " + leafCount);
        }

         
    }
}
