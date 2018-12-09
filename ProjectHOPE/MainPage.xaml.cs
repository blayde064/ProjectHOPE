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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectHOPE
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();

            // This is a static public property that allows downstream pages to get a handle to the MainPage instance
            // in order to call methods that are in this class.
            Current = this;

            // Caching your main page is good practice, this makes it snappy for the user to return to "home" of your app.
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // This page is always at the top of our in-app back stack.
            // Once it is reached there is no further back so we can always disable the title bar back UI when navigated here.
            // If you want to you can always to the Frame.CanGoBack check for all your pages and act accordingly.
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Splitter.IsPaneOpen = !Splitter.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<TextBlock> options = new List<TextBlock>();
            TextBlock temp = new TextBlock() { Text = "Production", Width = OptionsStack.Width };
            //temp.PointerPressed += Temp_PointerPressed;
            options.Add(temp);
            TextBlock temp1 = new TextBlock() { Text = "Page 2", Width = OptionsStack.Width };
            //temp1.PointerPressed += Temp1_PointerPressed;
            options.Add(temp1);
            TextBlock temp2 = new TextBlock() { Text = "Page 3", Width = OptionsStack.Width };
            //temp2.PointerPressed += Temp2_PointerPressed;
            options.Add(temp2);
            Options.ItemsSource = options;
            
            MainFrame.Navigate(typeof(Page1));

            
        }

        //private void Temp1_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    MainFrame.Navigate(typeof(Page2));
        //}

        //private void Temp2_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    MainFrame.Navigate(typeof(Page3));
        //}

        //private void Temp_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    MainFrame.Navigate(typeof(Page1));
        //}

        private void Options_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock temp = Options.SelectedItem as TextBlock;
            string option = temp.Text;
            switch (option)
            {
                case "Page 1":
                    MainFrame.Navigate(typeof(Page1));
                    break;
                case "Page 2":
                    MainFrame.Navigate(typeof(Page2));
                    break;
                case "Page 3":
                    MainFrame.Navigate(typeof(Page3));
                    break;
            }
            Splitter.IsPaneOpen = false;
        }

        private void MainFrame_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            return;
        }
    }
}
