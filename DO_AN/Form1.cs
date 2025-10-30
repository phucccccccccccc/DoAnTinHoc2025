using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Form1 : Form
    {
        quanLyXe qlx = new quanLyXe();
        AVLTree avl = new AVLTree();  // ✅ thêm cây AVL

        string path = Application.StartupPath + "\\car_sales_data.csv";
        List<Xe> dsXe = new List<Xe>();

        public Form1()
        {
            InitializeComponent();
        }

     private void Form1_Load_1(object sender, EventArgs e)
{
    try
    {
        if (!File.Exists(path))
        {
            MessageBox.Show("File CSV không tồn tại!");
            return;
        }

        dsXe = qlx.DocFileCSV(path);
        dataGridView1.DataSource = dsXe;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi đọc file CSV: " + ex.Message);
    }
}

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
                MessageBox.Show("✅ Đã ghi lại file CSV thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi ghi file CSV: " + ex.Message);
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
                MessageBox.Show("Hiển thị dữ liệu duyệt theo thứ tự InOrder (Cây AVL)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị cây AVL: " + ex.Message);
            }
        }
    }
    }

