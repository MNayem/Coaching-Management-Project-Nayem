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
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;      //Represent a set of data commands and a database connection
        DataTable dt;
        private void btn_show_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=NAYEM;Initial Catalog=Income1;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from Income1",conDataBase);
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
                RowsColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=NAYEM;Initial Catalog=cost1;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from cost1", conDataBase);
            try
            {
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();    //Cover the data source for a form = bindingsource
                bsource.DataSource = dt;
                dataGridView2.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Income1;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into income1 VALUES('"+ txt_name.Text +"','"+ txt_class.Text +"','"+ txt_amount.Text+"','" + dateTimePicker1.Value.ToString("MM/dd/yyyy")+"')",con);
            cmd.ExecuteNonQuery();       //controls number of rows affected
            con.Close();
            MessageBox.Show("Data Inserted Successfully !!!");
            txt_name.Text = "";
            txt_class.Text = "";
            txt_amount.Text = "";
            //txt_date.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Income1;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from Income1 WHERE Name ='" + txt_name.Text +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully !!!");
            txt_name.Text = "";
        }

        private void btn_insert2_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=profit3;Integrated Security=True");
            //con.Open();
            //cmd = new SqlCommand("insert into profit3 VALUES('" + txt_date2.Text + "','" + txt_tp.Text + "','" + txt_ep.Text + "','" + txt_computer.Text + "','"+ txt_others.Text +"')", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Data Inserted Successfully !!!");
            //txt_date2.Text = "";
            //txt_tp.Text = "";
            //txt_ep.Text = "";
            //txt_computer.Text = "";
            //txt_others.Text = "";
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=cost1;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into cost1 VALUES('" + dateTimePicker2.Value.ToString("MM/dd/yyyy")+"','" + txt_tp.Text +"','" + txt_ep.Text +"','" + txt_computer.Text + "','" + txt_others.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully !!!");
            //txt_date2.Text = "";
            txt_tp.Text = "";
            txt_ep.Text = "";
            txt_computer.Text = "";
            txt_others.Text = "";
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=cost1;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from cost1 WHERE Payment_Date = '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", con);
            cmd.ExecuteNonQuery();     //execute and returns the number of rows affected
            con.Close();
            MessageBox.Show("Data Deleted Successfully !!!");
            //txt_date2.Text = "";
        }

        private void btn_update2_Click(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[2].Value);
            }
            label12.Text = B.ToString();
        }

        private void btn_total_cost_Click(object sender, EventArgs e)
        {
            //int M = 0, N = 0;
            //for (M = 0; M < dataGridView2.Rows.Count; ++M)
            //{
                //N += Convert.ToInt32(dataGridView2.Rows[M].Cells[5].Value);
            //}
            //label18.Text = N.ToString();
            label18.Text = (Convert.ToInt32(label24.Text) + Convert.ToInt32(label25.Text) + Convert.ToInt32(label26.Text) + Convert.ToInt32(label27.Text)).ToString();
        }

        private void btn_profit_Click(object sender, EventArgs e)
        {
            label21.Text = (Convert.ToInt32(label12.Text) - Convert.ToInt32(label18.Text)).ToString();
        }

        private void btn_total_tp_Click(object sender, EventArgs e)
        {
            int P = 0, Q = 0;
            for (P = 0; P < dataGridView2.Rows.Count; ++P)
            {
                Q += Convert.ToInt32(dataGridView2.Rows[P].Cells[1].Value);
            }
            label24.Text = Q.ToString();
        }

        private void btn_total_ep_Click(object sender, EventArgs e)
        {
            int R = 0, S = 0;
            for(R = 0; R < dataGridView2.Rows.Count; ++R)
            {
                S += Convert.ToInt32(dataGridView2.Rows[R].Cells[2].Value);
            }
            label25.Text = S.ToString();
        }

        private void btn_computer_Click(object sender, EventArgs e)
        {
            int H = 0, G = 0;
            for(H = 0; H < dataGridView2.Rows.Count; ++H)
            {
                G += Convert.ToInt32(dataGridView2.Rows[H].Cells[3].Value);
            }
            label26.Text = G.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int K = 0, L = 0;
            for (K = 0; K < dataGridView2.Rows.Count; ++K)
            {
                L += Convert.ToInt32(dataGridView2.Rows[K].Cells[4].Value);
            }
            label27.Text = L.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(comboBox4.Text == "Name")
            {
                con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=profit1;Integrated Security=True");
                sda = new SqlDataAdapter("select *from profit1 WHERE Name like '" + txt_search.Text + "%'",con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(comboBox4.Text == "Class")
            {
                con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=profit1;Integrated Security=True");
                sda = new SqlDataAdapter("select *from profit1 WHERE Class like '" + txt_search.Text + "%'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_search2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Date")
            {
                con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=profit3;Integrated Security=True");
                sda = new SqlDataAdapter("select *from profit3 WHERE Payment_Date like '" + dateTimePicker2.MinDate + "%'",con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            //else if(comboBox5.Text == "Computer")
            //{
                //con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=profit3;Integrated Security=True");
                //sda = new SqlDataAdapter("select *from profit3 WHERE Computer like '" + txt_computer.Text + "%'", con);
                //dt = new DataTable();
                //sda.Fill(dt);
                //dataGridView2.DataSource = dt;
            //}
        }
        private void RowsColor()
        {
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                int date = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (date <= 2500)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if(date <= 3000)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (date > 3000)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }

        private void btn_m_a_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = dateTimePicker1.Value;
            //while(d = comboBox1.Text)
            //{

            //}
        }
    }
}
