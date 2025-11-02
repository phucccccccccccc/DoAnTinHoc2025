
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
            this.btnDoCaoCay.Location = new System.Drawing.Point(496, 2);
            this.btnDoCaoCay.Name = "btnDoCaoCay";
            this.btnDoCaoCay.Size = new System.Drawing.Size(195, 52);
            this.btnDoCaoCay.TabIndex = 4;
            this.btnDoCaoCay.Text = "Tính Độ Cao Cây";
            this.btnDoCaoCay.UseVisualStyleBackColor = true;
            this.btnDoCaoCay.Click += new System.EventHandler(this.btnDoCaoCay_Click);
            // 
            // btnHienThiTheoGia
            // 
            this.btnHienThiTheoGia.Location = new System.Drawing.Point(185, 2);
            this.btnHienThiTheoGia.Name = "btnHienThiTheoGia";
            this.btnHienThiTheoGia.Size = new System.Drawing.Size(269, 66);
            this.btnHienThiTheoGia.TabIndex = 5;
            this.btnHienThiTheoGia.Text = "Duyệt Cây Theo Giá";
            this.btnHienThiTheoGia.UseVisualStyleBackColor = true;
            this.btnHienThiTheoGia.Click += new System.EventHandler(this.btnHienThiTheoGia_Click);
            // 
            // demLa
            // 
            this.demLa.Location = new System.Drawing.Point(495, 75);
            this.demLa.Name = "demLa";
            this.demLa.Size = new System.Drawing.Size(195, 56);
            this.demLa.TabIndex = 6;
            this.demLa.Text = "SO LÁ";
            this.demLa.UseVisualStyleBackColor = true;
            this.demLa.Click += new System.EventHandler(this.demLa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 534);
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

        }

        #endregion

        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnDoCaoCay;
        private System.Windows.Forms.Button btnHienThiTheoGia;
        private System.Windows.Forms.Button demLa;
    }
}

