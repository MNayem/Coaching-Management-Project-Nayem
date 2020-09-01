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
using System.IO;

namespace INSPIRON
{
    public partial class Student_Profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=student_profile;Integrated Security=True");
        SqlCommand cmd;       //store procedure to execute
        string imgloc = "";
        public Student_Profile()
        {
            InitializeComponent();
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {

        }

        private void btn_browsePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dmj = new OpenFileDialog();
                dmj.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.* ";
                dmj.Title = "Select student Picture";
                if (dmj.ShowDialog() == DialogResult.OK)    //specifies identifires to execute the value of dialog box
                {
                    imgloc = dmj.FileName.ToString();
                    pictureStudent.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_savePic_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else if(txt_fname.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else if(txt_class.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else if(txt_address.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else if(txt_contact.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = ("insert into student_profile VALUES('" + txt_name.Text + "','" + txt_fname.Text + "','" + txt_class.Text + "','" + txt_address.Text + "','" + txt_contact.Text + "',@img)");
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + "Record(s) Saved !!!");
                    txt_name.Text = "";
                    txt_fname.Text = "";
                    txt_class.Text = "";
                    txt_address.Text = "";
                    txt_contact.Text = "";
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            txt_name.Text = "";
            txt_fname.Text = "";
            txt_class.Text = "";
            txt_address.Text = "";
            txt_contact.Text = "";
        }

        private void btn_showPic_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = ("select *from student_profile WHERE Name = '" + txt_name.Text +"'");
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand(sql,con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    txt_fname.Text = reader[1].ToString();
                    txt_class.Text = reader[2].ToString();
                    txt_address.Text = reader[3].ToString();
                    txt_contact.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    if(img == null)
                    {
                        pictureStudent.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureStudent.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("This Does not Exist in the Record !!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
