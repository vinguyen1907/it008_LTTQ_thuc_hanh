namespace Bai9
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMonHocConfirm = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBtnNam = new System.Windows.Forms.RadioButton();
            this.RBtnNu = new System.Windows.Forms.RadioButton();
            this.TxtChuyenNganh = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRetract = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TxtMonHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMonHocConfirm);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.TxtChuyenNganh);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnRetract);
            this.groupBox1.Controls.Add(this.BtnConfirm);
            this.groupBox1.Controls.Add(this.TxtMonHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // TxtMonHocConfirm
            // 
            this.TxtMonHocConfirm.AcceptsReturn = true;
            this.TxtMonHocConfirm.AllowDrop = true;
            this.TxtMonHocConfirm.Location = new System.Drawing.Point(489, 281);
            this.TxtMonHocConfirm.Multiline = true;
            this.TxtMonHocConfirm.Name = "TxtMonHocConfirm";
            this.TxtMonHocConfirm.ReadOnly = true;
            this.TxtMonHocConfirm.Size = new System.Drawing.Size(231, 119);
            this.TxtMonHocConfirm.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Controls.Add(this.RBtnNam);
            this.flowLayoutPanel1.Controls.Add(this.RBtnNu);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 40);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // RBtnNam
            // 
            this.RBtnNam.AutoSize = true;
            this.RBtnNam.Location = new System.Drawing.Point(3, 3);
            this.RBtnNam.Name = "RBtnNam";
            this.RBtnNam.Size = new System.Drawing.Size(62, 24);
            this.RBtnNam.TabIndex = 2;
            this.RBtnNam.TabStop = true;
            this.RBtnNam.Text = "Nam";
            this.RBtnNam.UseVisualStyleBackColor = true;
            // 
            // RBtnNu
            // 
            this.RBtnNu.AutoSize = true;
            this.RBtnNu.Location = new System.Drawing.Point(71, 3);
            this.RBtnNu.Name = "RBtnNu";
            this.RBtnNu.Size = new System.Drawing.Size(50, 24);
            this.RBtnNu.TabIndex = 3;
            this.RBtnNu.TabStop = true;
            this.RBtnNu.Text = "Nữ";
            this.RBtnNu.UseVisualStyleBackColor = true;
            // 
            // TxtChuyenNganh
            // 
            this.TxtChuyenNganh.DisplayMember = "Công Nghệ Phần Mềm";
            this.TxtChuyenNganh.FormattingEnabled = true;
            this.TxtChuyenNganh.Location = new System.Drawing.Point(338, 131);
            this.TxtChuyenNganh.Name = "TxtChuyenNganh";
            this.TxtChuyenNganh.Size = new System.Drawing.Size(382, 28);
            this.TxtChuyenNganh.TabIndex = 16;
            this.TxtChuyenNganh.ValueMember = "Công Nghệ Phần Mềm";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(435, 424);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 29);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Xóa Chọn";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(260, 424);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 29);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Lưu Thông Tin";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRetract
            // 
            this.BtnRetract.Location = new System.Drawing.Point(435, 343);
            this.BtnRetract.Name = "BtnRetract";
            this.BtnRetract.Size = new System.Drawing.Size(37, 29);
            this.BtnRetract.TabIndex = 13;
            this.BtnRetract.Text = "<";
            this.BtnRetract.UseVisualStyleBackColor = true;
            this.BtnRetract.Click += new System.EventHandler(this.BtnRetract_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(435, 308);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(37, 29);
            this.BtnConfirm.TabIndex = 12;
            this.BtnConfirm.Text = ">";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TxtMonHoc
            // 
            this.TxtMonHoc.AcceptsReturn = true;
            this.TxtMonHoc.AllowDrop = true;
            this.TxtMonHoc.Location = new System.Drawing.Point(187, 281);
            this.TxtMonHoc.Multiline = true;
            this.TxtMonHoc.Name = "TxtMonHoc";
            this.TxtMonHoc.Size = new System.Drawing.Size(231, 119);
            this.TxtMonHoc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên Ngành";
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(338, 74);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(382, 27);
            this.TxtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // TxtMSSV
            // 
            this.TxtMSSV.Location = new System.Drawing.Point(338, 20);
            this.TxtMSSV.Name = "TxtMSSV";
            this.TxtMSSV.Size = new System.Drawing.Size(227, 27);
            this.TxtMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 498);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 338);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 848);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhập Liệu Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox TxtChuyenNganh;
        private Button BtnDelete;
        private Button BtnSave;
        private Button BtnRetract;
        private Button BtnConfirm;
        private TextBox TxtMonHoc;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtHoTen;
        private Label label2;
        private TextBox TxtMSSV;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton RBtnNam;
        private RadioButton RBtnNu;
        private TextBox TxtMonHocConfirm;
        private string[] CN = { "Công Nghệ Phần Mềm", "Hệ Thống Thông Tin", "Kỹ Thuật Máy Tính", "Khoa Học Máy Tính", "Thương Mại Điện Tử" };
    }
}