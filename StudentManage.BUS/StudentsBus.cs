using StudentManage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.BUS
{
    public class StudentsBus
    {
        StudentContext studentBUS = new StudentContext();
        /// <summary>
        /// get all list students
        /// </summary>
        /// <returns></returns>
        public List<Student> LoadStudents()
        {
            return studentBUS.LoadStudents();
        }
    }
}
