namespace DesktopApp
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
            cbQuan = new ComboBox();
            cbLoaiHinh = new ComboBox();
            cbPhapLy = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDuDoan = new Button();
            label5 = new Label();
            lblGiaDuKien = new Label();
            label8 = new Label();
            numDienTich = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numDienTich).BeginInit();
            SuspendLayout();
            // 
            // cbQuan
            // 
            cbQuan.Font = new Font("Segoe UI", 26.25F);
            cbQuan.FormattingEnabled = true;
            cbQuan.Items.AddRange(new object[] { "Quận Cầu Giấy", "Quận Hai Bà Trưng", "Quận Hà Đông", "Quận Hoàng Mai", "Quận Long Biên", "Quận Nam Từ Liêm", "Huyện Thanh Trì", "Quận Đống Đa", "Quận Ba Đình", "Quận Thanh Xuân", "Quận Bắc Từ Liêm", "Quận Tây Hồ", "Huyện Hoài Đức", "Huyện Gia Lâm", "Huyện Chương Mỹ", "Quận Hoàn Kiếm", "Thị xã Sơn Tây", "Huyện Đông Anh", "Huyện Mê Linh", "Huyện Thường Tín", "Huyện Thanh Oai", "Huyện Sóc Sơn", "Huyện Đan Phượng", "Huyện Phúc Thọ", "Huyện Thạch Thất", "Huyện Quốc Oai" });
            cbQuan.Location = new Point(200, 19);
            cbQuan.Name = "cbQuan";
            cbQuan.Size = new Size(460, 55);
            cbQuan.TabIndex = 0;
            // 
            // cbLoaiHinh
            // 
            cbLoaiHinh.Font = new Font("Segoe UI", 26.25F);
            cbLoaiHinh.FormattingEnabled = true;
            cbLoaiHinh.Items.AddRange(new object[] { "Nhà ngõ, hẻm", "Nhà mặt phố, mặt tiền", "Nhà biệt thự", "Nhà phố liền kề" });
            cbLoaiHinh.Location = new Point(200, 98);
            cbLoaiHinh.Name = "cbLoaiHinh";
            cbLoaiHinh.Size = new Size(460, 55);
            cbLoaiHinh.TabIndex = 2;
            // 
            // cbPhapLy
            // 
            cbPhapLy.Font = new Font("Segoe UI", 26.25F);
            cbPhapLy.FormattingEnabled = true;
            cbPhapLy.Items.AddRange(new object[] { "Đã có sổ", "Đang chờ sổ", "Chưa có sổ", "Giấy tờ khác" });
            cbPhapLy.Location = new Point(200, 173);
            cbPhapLy.Name = "cbPhapLy";
            cbPhapLy.Size = new Size(460, 55);
            cbPhapLy.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 47);
            label1.TabIndex = 4;
            label1.Text = "Quận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F);
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(161, 47);
            label3.TabIndex = 6;
            label3.Text = "Loại hình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F);
            label4.Location = new Point(21, 176);
            label4.Name = "label4";
            label4.Size = new Size(134, 47);
            label4.TabIndex = 7;
            label4.Text = "Pháp lý";
            // 
            // btnDuDoan
            // 
            btnDuDoan.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDuDoan.ForeColor = Color.Navy;
            btnDuDoan.Location = new Point(21, 316);
            btnDuDoan.Name = "btnDuDoan";
            btnDuDoan.Size = new Size(201, 73);
            btnDuDoan.TabIndex = 8;
            btnDuDoan.Text = "Dự đoán";
            btnDuDoan.UseVisualStyleBackColor = true;
            btnDuDoan.Click += btnDuDoan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(21, 403);
            label5.Name = "label5";
            label5.Size = new Size(380, 47);
            label5.TabIndex = 9;
            label5.Text = "Giá thị trường dự kiến: ";
            // 
            // lblGiaDuKien
            // 
            lblGiaDuKien.AutoSize = true;
            lblGiaDuKien.Font = new Font("Segoe UI", 26.25F);
            lblGiaDuKien.ForeColor = Color.Navy;
            lblGiaDuKien.Location = new Point(382, 403);
            lblGiaDuKien.Name = "lblGiaDuKien";
            lblGiaDuKien.Size = new Size(0, 47);
            lblGiaDuKien.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F);
            label8.Location = new Point(11, 259);
            label8.Name = "label8";
            label8.Size = new Size(157, 47);
            label8.TabIndex = 13;
            label8.Text = "Diện tích";
            // 
            // numDienTich
            // 
            numDienTich.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDienTich.Location = new Point(200, 256);
            numDienTich.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numDienTich.Name = "numDienTich";
            numDienTich.Size = new Size(120, 54);
            numDienTich.TabIndex = 17;
            numDienTich.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 482);
            Controls.Add(numDienTich);
            Controls.Add(label8);
            Controls.Add(lblGiaDuKien);
            Controls.Add(label5);
            Controls.Add(btnDuDoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbPhapLy);
            Controls.Add(cbLoaiHinh);
            Controls.Add(cbQuan);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "House Price Forecast in HaNoi, VietNam";
            ((System.ComponentModel.ISupportInitialize)numDienTich).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbQuan;
        private ComboBox cbLoaiHinh;
        private ComboBox cbPhapLy;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnDuDoan;
        private Label label5;
        private Label lblGiaDuKien;
        private Label label8;
        private NumericUpDown numDienTich;
    }
}
