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
    public partial class Incom : Form
    {
        public Incom()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        private void btn_show_Click(object sender, EventArgs e)
        {
            string constring = (@"Data Source=NAYEM;Initial Catalog=Income;Integrated Security=True");
            SqlConnection con = new SqlConnection(constring);
            cmd = new SqlCommand("select *from Income",con);
            try
            {
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Income;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into Income VALUES('"+ txt_name.Text +"','"+ txt_class.Text +"','"+ txt_amount.Text +"','"+ txt_date.Text +"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully !!!");
            txt_name.Text = "";
            txt_class.Text = "";
            txt_amount.Text = "";
            txt_date.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Income;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("update Income SET Name = '"+ txt_name.Text +"',Class = '"+ txt_class.Text +"',Amount = '"+ txt_amount.Text +"',payment_Date = '"+ txt_date.Text +"' WHERE Name = '"+ txt_name.Text +"' and Class = '"+ txt_class.Text +"' and Amount = '"+ txt_amount.Text +"' and payment_Date = '"+ txt_date.Text +"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully !!!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Income;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from Income WHERE Name = '"+ txt_name.Text +"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted SuccessFully !!!");
            txt_name.Text = "";
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            int M = 0, N = 0;
            for(N = 0; N < dataGridView1.Rows.Count; ++N)
            {
                M += Convert.ToInt32(dataGridView1.Rows[N].Cells[2].Value);
            }
            label7.Text = M.ToString();
        }
    }
}
