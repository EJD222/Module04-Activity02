using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04Activity02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTabPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabbedPageSample());
        }

        private async void OnCarouselPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CarouselPageSample());
        }
    }
}
