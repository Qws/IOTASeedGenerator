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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IOTASeedGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        bool showDonationAddress;
        bool seedDescriptionCreated = false;
        Generator generator = new Generator();
        Seed generatedSeed = new Seed();
        public MainPage()
        {
            this.InitializeComponent();
            showDonationAddress = false;
            SeedDescription.Opacity = 0;

        }

        private void GenerateSeed_Click(object sender, RoutedEventArgs e)
        {

            generatedSeed = generator.CreateSeed();
            SeedText.Text = generatedSeed.Value;
            if(seedDescriptionCreated == false)
            {
                TapToCopyFadeInEntrance.Begin();
                seedDescriptionCreated = true;
            }
        }

        private void SeedText_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ClipboardHandler ch = new ClipboardHandler();
            ch.SetClipboard(generatedSeed);
            FadeInOutTapCopy.Begin();
        }

        private void GenerateSeed_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
        }

        private void GenerateSeed_PointerExited(object sender, PointerRoutedEventArgs e)
        {
        }

        private void DonationButton_Click(object sender, RoutedEventArgs e)
        {
            if(showDonationAddress == false)
            {
                showDonationAddress = true;
                DonationGrid.Opacity = 100;
            }

            else
            {
                showDonationAddress = false;
                DonationGrid.Opacity = 0;
            }
        }
    }
}
