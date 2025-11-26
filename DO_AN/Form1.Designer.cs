
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(19, 66);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(140, 66);
            this.btnGhiFile.TabIndex = 0;
            this.btnGhiFile.Text = "GHI";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(12, 0);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(147, 56);
            this.btnDocFile.TabIndex = 3;
            this.btnDocFile.Text = "DOC";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click_1);
            // 
            // btnDoCaoCay
            // 
            this.btnDoCaoCay.Location = new System.Drawing.Point(330, 9);
            this.btnDoCaoCay.Name = "btnDoCaoCay";
            this.btnDoCaoCay.Size = new System.Drawing.Size(106, 52);
            this.btnDoCaoCay.TabIndex = 4;
            this.btnDoCaoCay.Text = "Tính Độ Cao Cây";
            this.btnDoCaoCay.UseVisualStyleBackColor = true;
            this.btnDoCaoCay.Click += new System.EventHandler(this.btnDoCaoCay_Click);
            // 
            // btnHienThiTheoGia
            // 
            this.btnHienThiTheoGia.Location = new System.Drawing.Point(185, 2);
            this.btnHienThiTheoGia.Name = "btnHienThiTheoGia";
            this.btnHienThiTheoGia.Size = new System.Drawing.Size(123, 66);
            this.btnHienThiTheoGia.TabIndex = 5;
            this.btnHienThiTheoGia.Text = "Duyệt Cây Theo Giá";
            this.btnHienThiTheoGia.UseVisualStyleBackColor = true;
            this.btnHienThiTheoGia.Click += new System.EventHandler(this.btnHienThiTheoGia_Click);
            // 
            // demLa
            // 
            this.demLa.Location = new System.Drawing.Point(196, 76);
            this.demLa.Name = "demLa";
            this.demLa.Size = new System.Drawing.Size(81, 56);
            this.demLa.TabIndex = 6;
            this.demLa.Text = "SO LÁ";
            this.demLa.UseVisualStyleBackColor = true;
            this.demLa.Click += new System.EventHandler(this.demLa_Click);
            // 
            // demTrai
            // 
            this.demTrai.Location = new System.Drawing.Point(463, 13);
            this.demTrai.Name = "demTrai";
            this.demTrai.Size = new System.Drawing.Size(85, 44);
            this.demTrai.TabIndex = 7;
            this.demTrai.Text = "Đếm số Node Trái";
            this.demTrai.UseVisualStyleBackColor = true;
            this.demTrai.Click += new System.EventHandler(this.demTrai_Click);
            // 
            // demPhai
            // 
            this.demPhai.Location = new System.Drawing.Point(463, 76);
            this.demPhai.Name = "demPhai";
            this.demPhai.Size = new System.Drawing.Size(100, 56);
            this.demPhai.TabIndex = 8;
            this.demPhai.Text = "Đếm số Node Phải";
            this.demPhai.UseVisualStyleBackColor = true;
            this.demPhai.Click += new System.EventHandler(this.demPhai_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(760, 66);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 9;
            this.find.Text = "button1";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(626, 62);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 534);
            this.Controls.Add(this.txtPrice);
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
        private System.Windows.Forms.TextBox txtPrice;
    }
}

