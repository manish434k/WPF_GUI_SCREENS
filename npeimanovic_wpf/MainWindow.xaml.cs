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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : RibbonWindow
    {
        static bool flag =false;
        CurrentUser curruser= new CurrentUser();
        EmailSetup emailSetup = new EmailSetup();
        UserProfile usrProf = new UserProfile();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RibbonControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentUser_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        public void RibbonControl_SelectionChanged()
        {
            // Do something
            mainLeft.Children.Add(emailSetup);
            
        }
        public void RemoveEmailSetup()
        {
            mainLeft.Children.Clear();
            
        }
        public void RemoveOldUserControl()
        {
            mainLeft.Children.Clear();
            mainright.Children.Clear();
        }
        public void addUser()
        {
            mainLeft.Children.Add(curruser);
            mainright.Children.Add(usrProf);
        }
    }
}
