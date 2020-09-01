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
    public partial class About_Video : Form
    {
        public About_Video()
        {
            InitializeComponent();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if(OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_choose.Text = OpenFileDialog1.FileName;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = txt_choose.Text;            //URL = Uniform Resource Location and URI = Uniform Resource Identifirer
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
