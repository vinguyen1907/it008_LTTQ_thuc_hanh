namespace Bai5
{
    public partial class Form1 : Form
    {
         StudentList studentList;
        
        public Form1()
        {
            InitializeComponent();

            studentList = new StudentList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new ();
            form2.ShowDialog();
            if (form2.id != null && form2.name != null && form2.point != null)
            {
                Student newStudent = new Student(int.Parse(form2.id), form2.name, form2.department, double.Parse(form2.point));
                studentList.AddStudent(newStudent);
                dataGridView1.Rows.Add(studentList.getAmountOfStudents(), newStudent.Id, newStudent.Name, newStudent.Department, newStudent.Point);
            }    
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new ();
            form.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Student> result = studentList.getSearchedList(textBoxSearchKeyword.Text);
            foreach (var student in result.Select((value, index) => new {value, index}))
            {
                dataGridView1.Rows.Add(student.index + 1, student.value.Id, student.value.Name, student.value.Department, student.value.Point);
            }    
        }
    }
}