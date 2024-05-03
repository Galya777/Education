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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationServices
{
    /// <summary>
    /// Interaction logic for OrderCourse.xaml
    /// </summary>
    public partial class OrderCourse : UserControl
    { 
     OrderServiceEventArgs orderServiceEventArgs=new OrderServiceEventArgs();
        public OrderCourse()
        {
          
            List<Course> courses = new List<Course>();
            for (int i = 0; i < courses.Count; i++)
            {
               cboTypes.Items.Add(courses.ElementAt(i).ServiceType);
            }
            
            InitializeComponent();
        }
        public string getTitle()
        {
            return cboTitles.Text;
        }
        private void order_Click(object sender, RoutedEventArgs e)
        {
            orderServiceEventArgs.Order.Invoke(sender, orderServiceEventArgs);
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            txtQty.Text = "0";
        }
    }
}
