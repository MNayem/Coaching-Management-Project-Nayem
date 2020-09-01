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
    public partial class Teacher_Profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NAYEM;Initial Catalog=Teacher_Profile;Integrated Security=True");
        SqlCommand cmd;
        string imgloc = "";
        public Teacher_Profile()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teacher_Profile_Load(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dmj = new OpenFileDialog();
                dmj.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.* ";
                dmj.Title = "Select student Picture";
                if (dmj.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dmj.FileName.ToString();
                    pictureTeacher.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_savePic_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
                else if(txt_institute.Text == "")
            {
                MessageBox.Show("Please Give Your Full Information !!!");
            }
            else if(txt_subject.Text == "")
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
                string sql = ("insert into teacher_Profile VALUES('" + txt_name.Text + "','" + txt_institute.Text + "','" + txt_subject.Text + "','" + txt_contact.Text + "',@img)");
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
                txt_institute.Text = "";
                txt_subject.Text = "";
                txt_contact.Text = "";
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
           }
            txt_name.Text = "";
            txt_institute.Text = "";
            txt_subject.Text = "";
            txt_contact.Text = "";
        }

        private void btn_showPic_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = ("select *from teacher_Profile WHERE Name = '" + txt_name.Text + "'");
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    txt_institute.Text = reader[1].ToString();
                    txt_subject.Text = reader[2].ToString();
                    txt_contact.Text = reader[3].ToString();
                    byte[] img = (byte[])(reader[4]);
                    if (img == null)
                    {
                        pictureTeacher.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureTeacher.Image = Image.FromStream(ms);
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
    }
}
