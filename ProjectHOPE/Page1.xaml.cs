using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectHOPE
{
    /// <summary>
    /// Log in page, will skip this function if the computer is in the tblStations with a valid work type(production, office, etc) and location (test, packing, or WIs)
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbUsername.Text.Equals("user") || (tbUsername.Text.Equals("admin") && tbPassword.Text.Equals("admin"))){
                this.Frame.Navigate(typeof(pageProductionMainMenu));
            }
        }
    }
}
