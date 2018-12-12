using ProjectHOPE.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ProjectHOPE.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pageWISelection : Page
    {

        public List<Classes.WorkInstruction> workInstructions; 

        public pageWISelection()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            workInstructions = new List<Classes.WorkInstruction>();

            SqlConnection conn = new SqlConnection(csObjectHolder.csObjectHolder.ObjectHolderInstance().HOPEConnectionString);
            string query = "SELECT * FROM WorkInstructions";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workInstructions.Add( new Classes.WorkInstruction(reader["Location"].ToString(), reader["AssemblyNumber"].ToString(), reader["AssemblyDescription"].ToString(), reader["Series"].ToString(), reader["WorkInstructionName"].ToString()));
                    }
                }
                conn.Close();
            }

            dataGrid.ItemsSource = workInstructions;
        }

        private void DataGrid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pageWorkInstructions), ((WorkInstruction) dataGrid.SelectedItem).AssemblyNumber) ;
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
