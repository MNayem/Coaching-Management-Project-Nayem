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

namespace INSPIRON
{
    /// <summary>
    /// Interaction logic for Admin_Panel.xaml
    /// </summary>
    public partial class Admin_Panel : Window
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_admission_Click(object sender, RoutedEventArgs e)
        {
            Admission_Form ad = new Admission_Form();
            ad.Show();
        }

        private void btn_account_Click(object sender, RoutedEventArgs e)
        {
            Account_Section ac = new Account_Section();
            ac.Show();
        }

        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            Student_Profile stp = new Student_Profile();
            stp.Show();
        }

        private void btn_profile2_Click(object sender, RoutedEventArgs e)
        {
            Teacher_Profile t = new Teacher_Profile();
            t.Show();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            Student_Result str = new Student_Result();
            str.Show();
        }

        private void btn_syllabus_Click(object sender, RoutedEventArgs e)
        {
            Exam_Syllebus em = new Exam_Syllebus();
            em.Show();
        }

        private void btn_dashBoard_Click(object sender, RoutedEventArgs e)
        {
            NoticeBoard nn = new NoticeBoard();
            nn.Show();
        }
    }
}
