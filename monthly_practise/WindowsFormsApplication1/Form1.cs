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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        private void btn_show_Click(object sender, EventArgs e)
        {
           string constring = @"Data Source=NAYEM;Initial Catalog=practise;Integrated Security=True";
           SqlConnection consdataBase = new SqlConnection(constring);
           cmd = new SqlCommand("select *from practise", consdataBase);
            try
            {
                sda = new SqlDataAdapter();        //new () = Initialize a new instances of the system
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                sda.Update(dt);
                //RowsColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=practise;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into practise VALUES('" + txt_name.Text + "','" + txt_class.Text + "','" + txt_amount.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
            cmd.ExecuteNonQuery();       //controls number of rows affected
            con.Close();
            MessageBox.Show("Data Inserted Successfully !!!");
            txt_name.Text = "";
            txt_class.Text = "";
            txt_amount.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=practise;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from practise WHERE Name ='" + txt_name.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully !!!");
            txt_name.Text = "";
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = dateTimePicker1.Value;
            if(comboBox1.Text = 1)
            { 
              
            }
            else if(comboBox1.Text = 2)
            {

            }
            else if (comboBox1.Text = 3)
            {

            }
            else if (comboBox1.Text = 4)
            {

            }
            else if (comboBox1.Text = 5)
            {

            }
            else if (comboBox1.Text = 6)
            {

            }
            else if (comboBox1.Text = 7)
            {

            }
            else if (comboBox1.Text = 8)
            {

            }
            else if (comboBox1.Text = 9)
            {

            }
            else if (comboBox1.Text = 10)
            {

            }
            else if (comboBox1.Text = 11)
            {

            }
            else if (comboBox1.Text = 12)
            {

            }
           
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
             int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[2].Value);
            }
            label5.Text = B.ToString();
        }
    }
}
