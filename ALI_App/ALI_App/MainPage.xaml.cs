﻿using System;
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
            string byNameKeyWord = byNameSearchEntry.Text;
            //DisplayAlert("Hello", "This is the Search by NAME button: " + name, "Ok");
            Navigation.PushAsync(new DataListView(byNameKeyWord));
        }

        private void byPlaceSearchButton_Clicked(object sender, EventArgs e)
        {
            string byPlaceKeyWord = byPlaceSearchEntry.Text;
            Navigation.PushAsync(new DataListView(byPlaceKeyWord));
            //DisplayAlert("Hello", "This is the Search by PLACE button: " + byPlaceKeyWord, "Ok");
        }
    }
}
