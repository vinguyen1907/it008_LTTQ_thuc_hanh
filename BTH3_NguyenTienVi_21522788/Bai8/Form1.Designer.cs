namespace Bai8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxMoney = new System.Windows.Forms.TextBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.ColumnOrder = new System.Windows.Forms.ColumnHeader();
            this.ColumnAccountNumber = new System.Windows.Forms.ColumnHeader();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnAddress = new System.Windows.Forms.ColumnHeader();
            this.ColumnMoney = new System.Windows.Forms.ColumnHeader();
            this.PnlInput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAddAndUpdate = new System.Windows.Forms.Button();
            this.PnlInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền trong tài khoản";
            // 
            // TextBoxAccountNumber
            // 
            this.TextBoxAccountNumber.Location = new System.Drawing.Point(255, 11);
            this.TextBoxAccountNumber.Name = "TextBoxAccountNumber";
            this.TextBoxAccountNumber.Size = new System.Drawing.Size(511, 27);
            this.TextBoxAccountNumber.TabIndex = 5;
            this.TextBoxAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAccountNumber_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(255, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(511, 27);
            this.TextBoxName.TabIndex = 6;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(255, 91);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(511, 27);
            this.TextBoxAddress.TabIndex = 7;
            // 
            // TextBoxMoney
            // 
            this.TextBoxMoney.Location = new System.Drawing.Point(255, 135);
            this.TextBoxMoney.Name = "TextBoxMoney";
            this.TextBoxMoney.Size = new System.Drawing.Size(511, 27);
            this.TextBoxMoney.TabIndex = 8;
            this.TextBoxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoney_KeyPress);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnOrder,
            this.ColumnAccountNumber,
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnMoney});
            this.ListView.FullRowSelect = true;
            this.ListView.Location = new System.Drawing.Point(4, 265);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(873, 282);
            this.ListView.TabIndex = 9;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // ColumnOrder
            // 
            this.ColumnOrder.Text = "STT";
            // 
            // ColumnAccountNumber
            // 
            this.ColumnAccountNumber.Text = "Mã tài khoản";
            this.ColumnAccountNumber.Width = 150;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Tên khách hàng";
            this.ColumnName.Width = 200;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.Text = "Địa chỉ";
            this.ColumnAddress.Width = 250;
            // 
            // ColumnMoney
            // 
            this.ColumnMoney.Text = "Số tiền";
            this.ColumnMoney.Width = 210;
            // 
            // PnlInput
            // 
            this.PnlInput.Controls.Add(this.TextBoxMoney);
            this.PnlInput.Controls.Add(this.TextBoxAddress);
            this.PnlInput.Controls.Add(this.TextBoxName);
            this.PnlInput.Controls.Add(this.TextBoxAccountNumber);
            this.PnlInput.Controls.Add(this.label5);
            this.PnlInput.Controls.Add(this.label4);
            this.PnlInput.Controls.Add(this.label3);
            this.PnlInput.Controls.Add(this.label2);
            this.PnlInput.Location = new System.Drawing.Point(4, 53);
            this.PnlInput.Name = "PnlInput";
            this.PnlInput.Size = new System.Drawing.Size(873, 168);
            this.PnlInput.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnDel);
            this.panel1.Controls.Add(this.BtnAddAndUpdate);
            this.panel1.Location = new System.Drawing.Point(224, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 32);
            this.panel1.TabIndex = 11;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(454, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 29);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(327, 3);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(94, 29);
            this.BtnDel.TabIndex = 1;
            this.BtnDel.Text = "Xóa";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAddAndUpdate
            // 
            this.BtnAddAndUpdate.Location = new System.Drawing.Point(169, 2);
            this.BtnAddAndUpdate.Name = "BtnAddAndUpdate";
            this.BtnAddAndUpdate.Size = new System.Drawing.Size(131, 29);
            this.BtnAddAndUpdate.TabIndex = 0;
            this.BtnAddAndUpdate.Text = "Thêm/Cập nhập";
            this.BtnAddAndUpdate.UseVisualStyleBackColor = true;
            this.BtnAddAndUpdate.Click += new System.EventHandler(this.BtnAddAndUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlInput);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlInput.ResumeLayout(false);
            this.PnlInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBoxAccountNumber;
        private TextBox TextBoxName;
        private TextBox TextBoxAddress;
        private TextBox TextBoxMoney;
        private ListView ListView;
        private Panel PnlInput;
        private Panel panel1;
        private Button BtnExit;
        private Button BtnDel;
        private Button BtnAddAndUpdate;
        private ColumnHeader ColumnOrder;
        private ColumnHeader ColumnAccountNumber;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnAddress;
        private ColumnHeader ColumnMoney;
    }
}