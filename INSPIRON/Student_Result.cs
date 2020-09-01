using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSPIRON
{
    public partial class Student_Result : Form
    {
        public Student_Result()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            Class_Ten ct = new Class_Ten();
            ct.Show();
        }
    }
}
