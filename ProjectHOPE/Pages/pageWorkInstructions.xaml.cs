using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Pdf;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectHOPE.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pageWorkInstructions : Page
    {
        private MainPage rootPage = MainPage.Current;
        private PdfDocument pdfDocument;
        private Classes.WorkInstruction WI;
        Point scrollMousePoint = new Point();
        double hOff = 1;
        private double totalX = 0;
        private double totalY = 0;
        private string asNumber;


        public pageWorkInstructions()
        {
            this.InitializeComponent();

        }


        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(csObjectHolder.csObjectHolder.ObjectHolderInstance().HOPEConnectionString);
            string query = "SELECT * FROM WorkInstructions WHERE AssemblyNumber = @name";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", asNumber);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.WI = new Classes.WorkInstruction(reader["Location"].ToString(), reader["AssemblyNumber"].ToString(), reader["AssemblyDescription"].ToString(), reader["Series"].ToString(), reader["WorkInstructionName"].ToString());
                    }
                }
                conn.Close();
            }
            uint pageNum = 0;
            SqlConnection conn1 = new SqlConnection(csObjectHolder.csObjectHolder.ObjectHolderInstance().HOPEConnectionString);
            string work = "WorkStation" + rootPage.location.WorkStation;
            string query1 = "SELECT "+work+" FROM WorkInstructionDisplayTemplates WHERE Series = @name";
            using (SqlCommand cmd = new SqlCommand(query1, conn1))
            {
                cmd.Parameters.AddWithValue("@name", this.WI.Series);
                conn1.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.WriteLine(reader[work].ToString());
                        pageNum =Convert.ToUInt32(reader[work].ToString());
                    }
                }
                conn1.Close();
            }


            //var picker = new FileOpenPicker();
            //picker.FileTypeFilter.Add(".pdf");
            //StorageFile file = await picker.PickSingleFileAsync();
            //Debug.WriteLine(file.Path);
            //File.SetAttributes(this.WI.Location, System.IO.FileAttributes.Normal);
            //File.Copy(this.WI.Location, @"C:\Users\bdill\Documents");
            StorageFile file = await StorageFile.GetFileFromPathAsync(this.WI.Location);
            pdfDocument = await PdfDocument.LoadFromFileAsync(file);
            using (PdfPage page = pdfDocument.GetPage(pageNum-1))
            {
                var stream = new InMemoryRandomAccessStream();
                await page.RenderToStreamAsync(stream);
                BitmapImage src = new BitmapImage();
                imPage.Source = src;
                await src.SetSourceAsync(stream);
            }

            //ScrollView.Width = this.Width/2;
            //ScrollView.Height = imPage.Height;
        }

        private void ImPage_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            imPage.Opacity = .4;
        }

        private void ImPage_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            this.Transform.TranslateX += e.Delta.Translation.X;
            totalX += e.Delta.Translation.X;
            this.Transform.TranslateY += e.Delta.Translation.Y;
            totalY += e.Delta.Translation.X;
        }

        private void ImPage_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            imPage.Opacity = 1;
        }

        private void ScrollView_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            //Debug.WriteLine(ScrollView.ZoomFactor);
            //if (ScrollView.ZoomFactor < 1.1)
            //{
            //    this.Transform.TranslateX += totalX;
            //    this.Transform.TranslateY += totalY;
            //    totalY = 0;
            //    totalX = 0;
            //}
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            asNumber = (string)e.Parameter;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pageWISelection));
        }
    }
}
