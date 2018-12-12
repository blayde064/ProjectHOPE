using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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

            // I want this page to be always cached so that we don't have to add logic to save/restore state for the checkbox.
            this.NavigationCacheMode = NavigationCacheMode.Required;
            //MainPage.Current.Frame.BackStack.Add(new PageStackEntry(typeof(Page1), null, null));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User login = User.AttemptLogin(tbUsername.Text, tbPassword.Text);
            if (login != null)
            {
                MainPage.Current.user = login;
                this.Frame.Navigate(typeof(pageProductionMainMenu));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainPage.Current.user != null)
            //User login = User.AttemptLogin("user", "");
                this.Frame.Navigate(typeof(pageProductionMainMenu));
            
        }

        private void TbUsername_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter) Button_Click(null,null);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame.CanGoBack)
            {
                // If we have pages in our in-app backstack and have opted in to showing back, do so
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                // Remove the UI from the title bar if there are no pages in our in-app back stack
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }
    }
}
