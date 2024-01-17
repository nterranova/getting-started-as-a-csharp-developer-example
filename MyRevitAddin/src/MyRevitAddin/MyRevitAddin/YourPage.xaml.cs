using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace MyRevitAddin
{
    /// <summary>
    /// Interaction logic for YourPage.xaml
    /// </summary>
    public partial class YourPage
    {
        private bool _firstLoad = true;

        public YourPage()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            var env = await CoreWebView2Environment.CreateAsync(
                userDataFolder: System.IO.Path.Combine(System.IO.Path.GetTempPath(), "YourApp"),
                options: new CoreWebView2EnvironmentOptions(allowSingleSignOnUsingOSPrimaryAccount: true));
            await WebView.EnsureCoreWebView2Async(env);

            WebView.NavigationCompleted += WebView_NavigationCompleted;

            WebView.Source = new Uri("https://www.google.com/");
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!_firstLoad)
                return;

            _firstLoad = false;
            WebView.Visibility = Visibility.Visible;
        }

        private void YourPage_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _firstLoad = true;
            WebView.Dispose();
        }
    }
}
