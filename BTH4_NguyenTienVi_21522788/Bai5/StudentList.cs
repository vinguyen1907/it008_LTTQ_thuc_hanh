using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
     public class StudentList
    {
         List<Student> studentsList; 

        public StudentList()
        {
            studentsList = new List<Student>();
        }
        public int getAmountOfStudents()
        {
            return studentsList.Count;
        }
        public void AddStudent(Student student)
        {
            studentsList.Add(student);
        }
        public List<Student>  getSearchedList(String keyword)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in studentsList)
            {
                if (student.Name.Contains(keyword))
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}
