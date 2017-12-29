using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManage.DAL;
using StudentManage.BUS;

namespace StudentManage.Forms
{
    public partial class frmStudnemanagement : Form
    {
        StudentsBus studentBUS = new StudentsBus();
        public frmStudnemanagement()
        {
            InitializeComponent();
            LoadInit();
        }

        private void LoadInit()
        {
            dgvStudents.DataSource = studentBUS.LoadStudents();
        }
    }
}
