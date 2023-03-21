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

namespace Winform_CoAn.GUI_Layer
{
    /// <summary>
    /// Interaction logic for FormLoGin.xaml
    /// </summary>
    public partial class FormLoGin : Window
    {
        public FormLoGin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormQuanLi formQuanLi = new FormQuanLi();
            formQuanLi.Show();
        }
    }
}
