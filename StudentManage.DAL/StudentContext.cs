using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.DAL
{
    public class StudentContext
    {
        QuanLySinhVienEntities dbContext = new QuanLySinhVienEntities();
        
        /// <summary>
        /// get all list student
        /// </summary>
        /// <returns></returns>
        public List<Student> LoadStudents()
        {
            return dbContext.Students.ToList();
        }
    }
}
