using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INSPIRON
{
    public partial class Class_Ten : Form
    {
        public double first, second, result;
        char oper;
        public Class_Ten()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=student_result;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into student_result VALUES('" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + txt_name.Text + "','" + txt_phy.Text + "','" + txt_che.Text + "','" + txt_bio.Text + "','" + txt_gm.Text + "','" + txt_hm.Text + "','" + txt_tm.Text + "','" + txt_om.Text + "','" + txt_percentage.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Result Saved !!!");
            txt_name.Text = "";
            txt_phy.Text = "";
            txt_che.Text = "";
            txt_bio.Text = "";
            txt_gm.Text = "";
            txt_hm.Text = "";
            txt_tm.Text = "";
            txt_om.Text = "";
            txt_percentage.Text = "";
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=NAYEM;Initial Catalog=student_result;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from student_result ;", conDataBase);
            try
            {
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=student_result;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from student_result where Name = '" + txt_name.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Result Deleted !!!");
            txt_name.Text = "";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + ".";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(screen.Text);
            oper = '+';
            screen.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(screen.Text);
            oper = '-';
            screen.Text = "";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(screen.Text);
            oper = '*';
            screen.Text = "";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(screen.Text);
            oper = '/';
            screen.Text = "";
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (screen.Text != "")
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(screen.Text);
            if (oper == '+')
                result = first + second;
            else if (oper == '-')
                result = first - second;
            else if (oper == '*')
                result = first * second;
            else if (oper == '/')
                result = first / second;
            screen.Text = result.ToString();
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
