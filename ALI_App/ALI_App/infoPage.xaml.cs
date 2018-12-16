using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALI_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		public InfoPage (string data)
		{
            Label label = new Label
            {
                Text = "Hello World " + data
            };

            Content = new StackLayout
            {
                Children =
                {
                    label
                }
            };
            Title = "The Info Page";
		}
	}
}