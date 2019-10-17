using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingListview.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingListview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimpleListview : ContentPage
	{
        public ObservableCollection<Flower> Flowers;
		public SimpleListview ()
		{
			InitializeComponent ();
            Flowers = new ObservableCollection<Flower>();
            AssignValue();
            lv_Flower.ItemsSource = Flowers;
        }

        private void AssignValue()
        {
            Flowers.Add(new Flower()
            {
                Name = "Đón xuân",
                Description = "Hoa cúc các màu: trắng, vàng, cam",
                Price = 50000,
                Image = "img_SpringFlower.jpg"
            });

            Flowers.Add(new Flower()
            {
                Name = "Hồn nhiên",
                Description = "Hoa cúc các màu: vàng, cam, lá măng",
                Price = 60000,
                Image = "img_InnocentFlower.jpg"
            });

            Flowers.Add(new Flower()
            {
                Name = "Tím thủy chung",
                Description = "Hoa cúc tím",
                Price = 45000,
                Image = "img_VioletFlower.jpg"
            });
        }
    }
}