using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UsingListview
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_SimpleListview_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleListview());
        }

        private void Btn_GroupListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroupListview());
        }
    }
}
