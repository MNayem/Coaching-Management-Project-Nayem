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
    /// Interaction logic for Account_Section.xaml
    /// </summary>
    public partial class Account_Section : Window
    {
        public Account_Section()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_sms_Click(object sender, RoutedEventArgs e)
        {
            Remainder_SMS_for_student rsfs = new Remainder_SMS_for_student();
            rsfs.Show();
        }

        private void btn_fee_Click(object sender, RoutedEventArgs e)
        {
            Student_Fee st = new Student_Fee();
            st.Show();
        }

        private void btn_income_Click(object sender, RoutedEventArgs e)
        {
            Incom i = new Incom();
            i.Show();
        }

        private void btn_cost_Click(object sender, RoutedEventArgs e)
        {
            Cost c = new Cost();
            c.Show();
        }

        private void btn_profit_Click(object sender, RoutedEventArgs e)
        {
            Profit p = new Profit();
            p.Show();
        }
    }
}
