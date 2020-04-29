using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRGenerator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCodePage : ContentPage
    {

        int number;
        public QRCodePage(int n)
        {
            InitializeComponent();

            //BackgroundImageSource = "BG2.jpg";

            number = n;

            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 300;
            barcode.BarcodeOptions.Height = 300;
           // barcode.BarcodeOptions.Margin = 10;
            barcode.BarcodeValue = number.ToString();



        }

        private void backButtonClicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}