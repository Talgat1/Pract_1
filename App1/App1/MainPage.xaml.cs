using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Reg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFirst());
        }
        private async void Vhod(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageSecond());
        }
    }
}
