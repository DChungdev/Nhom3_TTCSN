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

namespace QuanLy
{
    /// <summary>
    /// Interaction logic for QuanLyMonHoc.xaml
    /// </summary>
    public partial class QuanLyMonHoc : Window
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Them t = new Them();
            t.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?",
                                                "Hỏi xóa",
                                                MessageBoxButton.YesNo,
                                                MessageBoxImage.Question);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sua sua = new Sua();
            sua.Show();
        }
    }
}
