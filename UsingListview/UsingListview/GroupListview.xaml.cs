using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingListview.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingListview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupListview : ContentPage
	{
		public GroupListview ()
		{
			InitializeComponent ();
            FlowerType flowerTypes = new FlowerType();
            flowerList.ItemsSource = flowerTypes.FlowerTypes;
        }
	}
}