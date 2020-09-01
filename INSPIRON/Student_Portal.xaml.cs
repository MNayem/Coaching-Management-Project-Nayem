using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace INSPIRON
{
    /// <summary>
    /// Interaction logic for Student_Portal.xaml
    /// </summary>
    public partial class Student_Portal : Window
    {
        public Student_Portal()
        {
            InitializeComponent();
        }

        private void btn_login1_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=NAYEM;Initial Catalog=Stdnt_login;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string commandstring = "select *from stdnt_login where Student_ID = '" + txt_stdntid.Text + "' and Passward = '" + txt_pwd.Password + "'";
            SqlCommand cmd = new SqlCommand(commandstring, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //con.Close();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Welcome !!!");
                Student_Section sta = new Student_Section();
                sta.Show();
            }
            else if (count > 1)
            {
                MessageBox.Show("Invalid User Name Or Password !!!");
            }
            else
            {
                MessageBox.Show("Please Enter Your Valid User Name and Password !!!");
            }
            txt_stdntid.Text = "";
            txt_pwd.Password = "";
        }

        private void btn_cancel1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
