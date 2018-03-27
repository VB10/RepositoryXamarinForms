using System;
using System.Collections.Generic;
using RepostaryXamarinForms.Model;
using RepostaryXamarinForms.Service;
using Xamarin.Forms;

namespace RepostaryXamarinForms.Views
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
            Title = "Save data";
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var data = new Blog();
            data.desc = _desc.Text;
            data.image = "https://images.sftcdn.net/images/t_optimized,f_auto/p/ce2ece60-9b32-11e6-95ab-00163ed833e7/260663710/the-test-fun-for-friends-screenshot.jpg";
            data.res = _switch.IsToggled;
            data.title = _title.Text;

            var service = new HardwareService();

           var res = await service.Postlist<Blog>(data);

            if (res) await Navigation.PopAsync(true);
            else
            {
                await DisplayAlert("Hata", "bir sorun", "okey");
            }


        }
    }
}
