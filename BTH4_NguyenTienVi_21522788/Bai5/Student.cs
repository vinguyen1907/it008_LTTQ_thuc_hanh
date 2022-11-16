using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
        public class Student
        {
        int id;
        string name;
        string department;
        double point;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Department { get { return department; } set { department = value; } }
        public double Point { get { return point; } set { point = value; } }

        public Student()
        {
            id = 0;
            name = "";
            department = "";
            point = 0;
        }
        public Student(int id, string name, string department, double point)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.point = point;
        }
        public Student(Student student)
        {
            this.id = student.id;
            this.name = student.name;
            this.department = student.department;
            this.point = student.point;
        }
    }
}
