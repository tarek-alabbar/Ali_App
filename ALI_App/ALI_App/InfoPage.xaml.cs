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
		public InfoPage (string testData)
		{
			InitializeComponent ();
            showDataLable.Text = testData;
            //Name.Text = "Text changed";
		}
	}
}