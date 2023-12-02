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
    /// Interaction logic for QuanLySinhVien.xaml
    /// </summary>
    public partial class QuanLySinhVien : Window
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThemSinhVien f = new ThemSinhVien();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SuaSinhVien f = new SuaSinhVien();
            f.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu sinh viên này không?", "Agreement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
