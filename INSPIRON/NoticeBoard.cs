using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace INSPIRON
{
    public partial class NoticeBoard : Form
    {
        public NoticeBoard()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string To, Type_Message;
                To = txt_number.Text;
                Type_Message = txt_msg.Text;
                string baseurl = "http://api.clickatell.com/http/sendmsg?user=[20142022010]&password=[YcZZNYcUORCDIC]&api_id=3581001&to='" + To + "'&text='" + Type_Message + "'";
                //string baseurl = "http://api.clickatell.com/http/sendmsg?api_id=3411095&user=riponctg&password=SIgOPabRJQY&to='"+ To +"'&text='"+ Type_Message +"'";
                client.OpenRead(baseurl);
                MessageBox.Show("Message sent successfully !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_number.Text = "";
            txt_msg.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
