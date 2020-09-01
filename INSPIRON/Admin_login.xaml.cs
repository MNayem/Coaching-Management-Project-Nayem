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
    /// Interaction logic for Admin_login.xaml
    /// </summary>
    public partial class Admin_login : Window
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void btn_login1_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=NAYEM;Initial Catalog=admin_login;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string commandstring = "select *from admin_Login where User_Name = '"+ txt_username.Text +"' and Passoword = '"+ txt_password.Password +"'";
            SqlCommand cmd = new SqlCommand(commandstring,con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //con.Close();
            int count = 0;
            while(dr.Read())
            {
                count += 1;
            }
            if(count == 1)
            {
                MessageBox.Show("Welcome !!!");
                Admin_Panel aa = new Admin_Panel();
                aa.Show();
            }
            //else if(count > 1)
            //{
                //MessageBox.Show("Invalid User Name Or Password !!!");
            //}
            else
            {
                MessageBox.Show("Wrong!!!..... Please Enter Your Valid User Name and Password !!!");
            }
            txt_username.Text = "";
            txt_password.Password = "";
        }

        private void btn_cancel1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
