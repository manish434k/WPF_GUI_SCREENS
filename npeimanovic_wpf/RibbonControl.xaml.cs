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
        private void edit_clicked(object sender, RoutedEventArgs e)
        {
            UserControlAddEdit subWindow = new UserControlAddEdit();
            subWindow.title.Content = "Edit User";
            subWindow.Show();
        }  
        
        private void selchanged(object sender, SelectionChangedEventArgs e)
        {
            if (Email_Setup.IsSelected)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).RemoveOldUserControl();
                ((MainWindow)System.Windows.Application.Current.MainWindow).RibbonControl_SelectionChanged();
            }
            else
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).RemoveEmailSetup();
               ((MainWindow)System.Windows.Application.Current.MainWindow).addUser();
            }
        }

    }
}
