using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALI_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataListView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public DataListView(string searchKeyWord)
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item 1 " + searchKeyWord,
                "Item 2 " + searchKeyWord,
                "Item 3 " + searchKeyWord,
                "Item 4 " + searchKeyWord,
                "Item 5 " + searchKeyWord
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            string data = e.Item.ToString();

            await Navigation.PushAsync(new InfoPage(data));
            //await DisplayAlert("Title", "Teastin", "Alright");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
