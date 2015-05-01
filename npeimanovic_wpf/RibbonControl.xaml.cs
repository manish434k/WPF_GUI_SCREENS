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
using System.Windows.Controls.Ribbon;

namespace npeimanovic_wpf
{
    /// <summary>
    /// Interaction logic for RibbonControl.xaml
    /// </summary>
    public partial class RibbonControl : Ribbon
    {
        public RibbonControl()
        {
            InitializeComponent();
        }
        private void add_clicked(object sender, RoutedEventArgs e)
        {
            UserControlAddEdit subWindow = new UserControlAddEdit();
            subWindow.Show();
        }
    }
}
