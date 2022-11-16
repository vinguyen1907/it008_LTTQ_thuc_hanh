namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                ComboBoxFontFamily.Items.Add(font.Name);
            }
            ComboBoxFontFamily.Text = "Tahoma";
            ComboBoxFontSize.Text = "14";
        }
        // Menu trip
        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Txt file (*.txt)|*.txt|Rtf file (*.rtf)|*.rtf",
                Title = "Open text file"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save text files";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.FileName = "*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // Tool trip
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            Font newFont = fontDialog.Font;
            richTextBox1.SelectionFont = newFont;
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK || fontDialog1.ShowApply)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                ComboBoxFontFamily.Text = fontDialog1.Font.Name;
                ComboBoxFontSize.Text = fontDialog1.Font.Size.ToString();
            }
        }
        private void ComboBoxFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font newFont = new Font(ComboBoxFontFamily.Text, richTextBox1.SelectionFont.Size);
            richTextBox1.SelectionFont = newFont;
        }
        private void ComboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font newFont = new Font(richTextBox1.SelectionFont.Name, int.Parse(ComboBoxFontSize.Text));
            richTextBox1.SelectionFont = newFont;
        }
        private void ButtonBold_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            } else
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Bold);
            }
            richTextBox1.SelectionFont = newFont;
        }
        private void ButtonItalic_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Italic);
            }
            richTextBox1.SelectionFont = newFont;
        }
        private void ButtonUnderline_Click(object sender, EventArgs e)
        {
            Font newFont;
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                newFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Underline);
            }
            richTextBox1.SelectionFont = newFont;
        }
    }
}