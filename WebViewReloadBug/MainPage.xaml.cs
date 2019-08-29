using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewReloadBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            webView.Source = "https://www.google.com";
        }
        private void NextButton_OnClicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = "https://www.youtube.com" };
            webView.Reload();
        }
    }
}
