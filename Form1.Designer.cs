namespace QuanLySanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtID = new TextBox();
            txtTenSP = new TextBox();
            txtMota = new TextBox();
            label3 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtSoluong = new TextBox();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            label2 = new Label();
            label6 = new Label();
            dsSanpham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dsSanpham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(160, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(160, 87);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(252, 27);
            txtTenSP.TabIndex = 3;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(160, 140);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(252, 27);
            txtMota.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 143);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Mô tả:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(160, 200);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(252, 27);
            txtGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 203);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "Giá:";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(160, 254);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(252, 27);
            txtSoluong.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 257);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Số Lượng:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(624, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(734, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(852, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(852, 183);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 13;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(624, 185);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(222, 27);
            txtTimkiem.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(701, 140);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 15;
            label6.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // dsSanpham
            // 
            dsSanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsSanpham.Location = new Point(50, 306);
            dsSanpham.Name = "dsSanpham";
            dsSanpham.RowHeadersWidth = 51;
            dsSanpham.Size = new Size(922, 256);
            dsSanpham.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 601);
            Controls.Add(dsSanpham);
            Controls.Add(label6);
            Controls.Add(txtTimkiem);
            Controls.Add(btnTimkiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSoluong);
            Controls.Add(label5);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(txtMota);
            Controls.Add(label3);
            Controls.Add(txtTenSP);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dsSanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtTenSP;
        private TextBox txtMota;
        private Label label3;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtSoluong;
        private Label label5;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private Label label2;
        private Label label6;
        private DataGridView dsSanpham;
    }
}
