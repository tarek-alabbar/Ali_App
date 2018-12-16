using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ALI_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void byNameSearchButton_Clicked(object sender, EventArgs e)
        {
            string name = byNameSearchEntry.Text;
            //DisplayAlert("Hello", "This is the Search by NAME button: " + name, "Ok");
            Navigation.PushAsync(new DataListView());
        }

        private void byPlaceSearchButton_Clicked(object sender, EventArgs e)
        {
            string place = byPlaceSearchEntry.Text;
            DisplayAlert("Hello", "This is the Search by PLACE button: " + place, "Ok");
        }
    }
}
