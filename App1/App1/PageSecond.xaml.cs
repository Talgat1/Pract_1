using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSecond : ContentPage
    {
        public PageSecond()
        {
            InitializeComponent();
        }
        private void project_List(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PageThird());
        }
    }
}