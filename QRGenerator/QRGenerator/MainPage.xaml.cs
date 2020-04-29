using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using ZXing;
using ZXing.Net.Mobile.Forms;

namespace QRGenerator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //ZXingBarcodeImageView barcode;
        //ZXingBarcodeImageView barcode2;

        public MainPage()
        {
            InitializeComponent();
            //BackgroundImageSource = "BG1.jpg";
            //numberEntry.Focus();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //numberEntry.Focus();
            
           // numberEntry.Text = "    ";
           // numberEntry.TextColor = Color.White;
            numberEntry.CursorPosition = 0;
            //numberEntry.On<iOS>().SetCursorColor(Color.LimeGreen);
            //var n = numberEntry.On<Android>().SetCursorColor(Color.LimeGreen);
            numberEntry.HorizontalTextAlignment = TextAlignment.Center;
        }

        private async void generateButtonClicked(object sender, EventArgs e)
        {
            if (numberEntry.Text == null)
            {
                await DisplayAlert("Alert", "Please enter value that you want to be carried in the QR Code", "OK");
                return;
            }

            if (numberEntry.Text.Length <= 0)
            {
                await DisplayAlert("Alert", "Please enter value that you want to be carried in the QR Code", "OK");
                return;
            }
            //decimal value;
            int number=0;
            //bool is_decimal = Decimal.TryParse(numberEntry.Text, out value);
            bool is_int = Int32.TryParse(numberEntry.Text, out number);
            
                //bool is_int = numberEntry.Text.All(char.IsDigit);
            if (!is_int)
            {
                await DisplayAlert("Alert", "Please enter integer values only", "OK");
                return;
            }
                        //int number = Int32.Parse(numberEntry.Text);

            await Navigation.PushAsync(new QRCodePage(number));

        }

        private void EntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 0)
            {
               // numberEntry.TextColor = Color.Black;
            }
        }
    }
}
