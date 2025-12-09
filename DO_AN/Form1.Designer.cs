
namespace DO_AN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnDoCaoCay = new System.Windows.Forms.Button();
            this.btnHienThiTheoGia = new System.Windows.Forms.Button();
            this.demLa = new System.Windows.Forms.Button();
            this.demTrai = new System.Windows.Forms.Button();
            this.demPhai = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtNhienLieu = new System.Windows.Forms.TextBox();
            this.txtDongCo = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSoKm = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvTrungID = new System.Windows.Forms.DataGridView();
            this.btnHienThiTang = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnNode1Con = new System.Windows.Forms.Button();
            this.btnNode2Con = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrungID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(19, 71);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(147, 61);
            this.btnGhiFile.TabIndex = 0;
            this.btnGhiFile.Text = "GHI";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 343);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(19, 5);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(147, 56);
            this.btnDocFile.TabIndex = 3;
            this.btnDocFile.Text = "DOC";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click_1);
            // 
            // btnDoCaoCay
            // 
            this.btnDoCaoCay.Location = new System.Drawing.Point(191, 5);
            this.btnDoCaoCay.Name = "btnDoCaoCay";
            this.btnDoCaoCay.Size = new System.Drawing.Size(129, 56);
            this.btnDoCaoCay.TabIndex = 4;
            this.btnDoCaoCay.Text = "Tính Độ Cao Cây";
            this.btnDoCaoCay.UseVisualStyleBackColor = true;
            this.btnDoCaoCay.Click += new System.EventHandler(this.btnDoCaoCay_Click);
            // 
            // btnHienThiTheoGia
            // 
            this.btnHienThiTheoGia.Location = new System.Drawing.Point(19, 220);
            this.btnHienThiTheoGia.Name = "btnHienThiTheoGia";
            this.btnHienThiTheoGia.Size = new System.Drawing.Size(147, 73);
            this.btnHienThiTheoGia.TabIndex = 5;
            this.btnHienThiTheoGia.Text = "Duyệt Cây Theo Giá";
            this.btnHienThiTheoGia.UseVisualStyleBackColor = true;
            this.btnHienThiTheoGia.Click += new System.EventHandler(this.btnHienThiTheoGia_Click);
            // 
            // demLa
            // 
            this.demLa.Location = new System.Drawing.Point(19, 140);
            this.demLa.Name = "demLa";
            this.demLa.Size = new System.Drawing.Size(147, 67);
            this.demLa.TabIndex = 6;
            this.demLa.Text = "SO LÁ";
            this.demLa.UseVisualStyleBackColor = true;
            this.demLa.Click += new System.EventHandler(this.demLa_Click);
            // 
            // demTrai
            // 
            this.demTrai.Location = new System.Drawing.Point(191, 140);
            this.demTrai.Name = "demTrai";
            this.demTrai.Size = new System.Drawing.Size(129, 67);
            this.demTrai.TabIndex = 7;
            this.demTrai.Text = "Đếm số Node Trái";
            this.demTrai.UseVisualStyleBackColor = true;
            this.demTrai.Click += new System.EventHandler(this.demTrai_Click);
            // 
            // demPhai
            // 
            this.demPhai.Location = new System.Drawing.Point(191, 76);
            this.demPhai.Name = "demPhai";
            this.demPhai.Size = new System.Drawing.Size(129, 56);
            this.demPhai.TabIndex = 8;
            this.demPhai.Text = "Đếm số Node Phải";
            this.demPhai.UseVisualStyleBackColor = true;
            this.demPhai.Click += new System.EventHandler(this.demPhai_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(448, 18);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(124, 23);
            this.find.TabIndex = 9;
            this.find.Text = "Tìm theo giá";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(342, 20);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 22);
            this.txtFind.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(792, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(593, 66);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(178, 22);
            this.txtHang.TabIndex = 12;
            // 
            // txtNhienLieu
            // 
            this.txtNhienLieu.Location = new System.Drawing.Point(593, 204);
            this.txtNhienLieu.Name = "txtNhienLieu";
            this.txtNhienLieu.Size = new System.Drawing.Size(178, 22);
            this.txtNhienLieu.TabIndex = 13;
            // 
            // txtDongCo
            // 
            this.txtDongCo.Location = new System.Drawing.Point(593, 157);
            this.txtDongCo.Name = "txtDongCo";
            this.txtDongCo.Size = new System.Drawing.Size(178, 22);
            this.txtDongCo.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(593, 110);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(178, 22);
            this.txtModel.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(593, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 22);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtSoKm
            // 
            this.txtSoKm.Location = new System.Drawing.Point(593, 286);
            this.txtSoKm.Name = "txtSoKm";
            this.txtSoKm.Size = new System.Drawing.Size(178, 22);
            this.txtSoKm.TabIndex = 17;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(593, 242);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(178, 22);
            this.txtNam.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(593, 328);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 22);
            this.txtPrice.TabIndex = 19;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(792, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(792, 327);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1134, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 88);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTrungID
            // 
            this.dgvTrungID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrungID.Location = new System.Drawing.Point(741, 356);
            this.dgvTrungID.Name = "dgvTrungID";
            this.dgvTrungID.RowHeadersWidth = 51;
            this.dgvTrungID.RowTemplate.Height = 24;
            this.dgvTrungID.Size = new System.Drawing.Size(496, 342);
            this.dgvTrungID.TabIndex = 23;
            this.dgvTrungID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrungID_CellClick);
            // 
            // btnHienThiTang
            // 
            this.btnHienThiTang.Location = new System.Drawing.Point(448, 74);
            this.btnHienThiTang.Name = "btnHienThiTang";
            this.btnHienThiTang.Size = new System.Drawing.Size(124, 27);
            this.btnHienThiTang.TabIndex = 24;
            this.btnHienThiTang.Text = "Xuất tầng";
            this.btnHienThiTang.UseVisualStyleBackColor = true;
            this.btnHienThiTang.Click += new System.EventHandler(this.btnHienThiTang_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(342, 76);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 22);
            this.txtLevel.TabIndex = 25;
            // 
            // btnNode1Con
            // 
            this.btnNode1Con.Location = new System.Drawing.Point(450, 173);
            this.btnNode1Con.Name = "btnNode1Con";
            this.btnNode1Con.Size = new System.Drawing.Size(127, 23);
            this.btnNode1Con.TabIndex = 26;
            this.btnNode1Con.Text = "Node 1 con";
            this.btnNode1Con.UseVisualStyleBackColor = true;
            this.btnNode1Con.Click += new System.EventHandler(this.btnNode1Con_Click);
            // 
            // btnNode2Con
            // 
            this.btnNode2Con.Location = new System.Drawing.Point(448, 220);
            this.btnNode2Con.Name = "btnNode2Con";
            this.btnNode2Con.Size = new System.Drawing.Size(127, 23);
            this.btnNode2Con.TabIndex = 27;
            this.btnNode2Con.Text = "Node 2 con";
            this.btnNode2Con.UseVisualStyleBackColor = true;
            this.btnNode2Con.Click += new System.EventHandler(this.btnNode2Con_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(448, 260);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(129, 73);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "Ds Node chính và node Trùng";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(344, 129);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(97, 22);
            this.txtTim.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Số lần trùng của node";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnNode2Con);
            this.Controls.Add(this.btnNode1Con);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnHienThiTang);
            this.Controls.Add(this.dgvTrungID);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtSoKm);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtDongCo);
            this.Controls.Add(this.txtNhienLieu);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.find);
            this.Controls.Add(this.demPhai);
            this.Controls.Add(this.demTrai);
            this.Controls.Add(this.demLa);
            this.Controls.Add(this.btnHienThiTheoGia);
            this.Controls.Add(this.btnDoCaoCay);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGhiFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrungID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnDoCaoCay;
        private System.Windows.Forms.Button btnHienThiTheoGia;
        private System.Windows.Forms.Button demLa;
        private System.Windows.Forms.Button demTrai;
        private System.Windows.Forms.Button demPhai;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtNhienLieu;
        private System.Windows.Forms.TextBox txtDongCo;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSoKm;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvTrungID;
        private System.Windows.Forms.Button btnHienThiTang;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnNode1Con;
        private System.Windows.Forms.Button btnNode2Con;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button button1;
    }
}

