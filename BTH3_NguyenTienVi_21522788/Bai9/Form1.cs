using System.Windows.Forms.VisualStyles;

namespace Bai9
{
    public partial class Form1 : Form
    {
        List<SinhVien> DS = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = DS;
            string[] CN = { "Công Nghệ Phần Mềm", "Hệ Thống Thông Tin", "Khoa Học Máy Tính", "Kỹ Thuật Máy Tính", "Thương Mại Điện Tử" };
            TxtChuyenNganh.Items.AddRange(CN);
            dataGridView1.Columns[0].HeaderCell.Value = "MSSV";
            dataGridView1.Columns[1].HeaderCell.Value = "Họ Tên";
            dataGridView1.Columns[2].HeaderCell.Value = "Chuyên Ngành";
            dataGridView1.Columns[3].HeaderCell.Value = "Giới Tính";
            dataGridView1.Columns[4].HeaderCell.Value = "Số Môn";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(VerifyInput())
            {
                int index = Find(TxtMSSV.Text);
                if(index == -1)
                {
                    AddRecord();
                    ClearFields();
                }
                else
                {
                    DS.RemoveAt(index);
                    AddRecord();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadGrid()
        {
            var source = new BindingSource(DS, null);
            dataGridView1.DataSource = source;
        }
        private void AddRecord()
        {
            SinhVien model = new SinhVien();
            model.MaSV = TxtMSSV.Text;
            model.HoTen = TxtHoTen.Text;
            model.ChuyenNganh = TxtChuyenNganh.Text;
            if (RBtnNam.Checked)
            {
                model.GioiTinh = RBtnNam.Text;
            }
            else
            {
                model.GioiTinh = RBtnNu.Text;
            }
            string[] MonHoc = TxtMonHocConfirm.Text.Split("\n");
            foreach (var monhoc in MonHoc)
            {
                model.CacMonHocThamGia.Add(monhoc);
            }
            model.SoMonHoc = model.CacMonHocThamGia.Count;
            DS.Add(model);
            ReloadGrid();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            TxtMonHocConfirm.Text += TxtMonHoc.Text;
            TxtMonHoc.Text = "";
        }

        private void BtnRetract_Click(object sender, EventArgs e)
        {
            TxtMonHoc.Text += TxtMonHocConfirm.Text;
            TxtMonHocConfirm.Text = "";
        }

        private bool VerifyInput()
        {
            bool result = true;
            if(TxtMSSV.Text == "" || TxtHoTen.Text == "" || TxtChuyenNganh.Text == "" || TxtMonHocConfirm.Text == "")
            {
                result = false;
            }
            return result;
        }
        private int Find(string mssv)
        {
            return DS.FindIndex(x => mssv == x.MaSV);
        }
        private void ClearFields()
        {
            TxtMSSV.Text = TxtHoTen.Text = TxtChuyenNganh.Text = TxtMonHoc.Text = TxtMonHocConfirm.Text = "";
            RBtnNam.Checked = RBtnNu.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClearFields();
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                int TargetIndex = Find(row.Cells[0].Value.ToString());
                SinhVien temp = DS.ElementAt(TargetIndex);
                TxtMSSV.Text = temp.MaSV;
                TxtHoTen.Text = temp.HoTen;
                TxtChuyenNganh.Text = temp.ChuyenNganh;
                if (temp.GioiTinh == "Nam")
                    RBtnNam.Checked = true;
                else
                    RBtnNu.Checked = true;
                foreach (var monhoc in temp.CacMonHocThamGia)
                {
                    TxtMonHocConfirm.Text += monhoc + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(TxtMSSV.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin sinh viên này?", "Yes/No", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DS.RemoveAt(Find(TxtMSSV.Text));
                    ReloadGrid();
                    ClearFields();
                }
            }
        }
    }
}