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
using System.Windows.Controls.Ribbon;

namespace npeimanovic_Client
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    /// 

    public partial class SettingsWindow : RibbonWindow
    {
        DataBaseSetUp dbsetup = new DataBaseSetUp();
        AccountingSetup accSetup = new AccountingSetup();
        FuelSetup fuelSetUp = new FuelSetup();

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void menuSelchanged(object sender, SelectionChangedEventArgs e)
        {
            if(Settings_database_Setup.IsSelected)
            {
                settingWindow.Children.Clear();
                settingWindow.Children.Add(dbsetup);

            }else if(Settings_Accounting_Setup.IsSelected)
            {
                settingWindow.Children.Clear();
                settingWindow.Children.Add(accSetup);
            }
            else if (Settings_Fuel_Setup.IsSelected)
            {
                settingWindow.Children.Clear();
                settingWindow.Children.Add(fuelSetUp);
            }

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }

   
}
