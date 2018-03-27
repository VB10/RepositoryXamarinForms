using System;
using System.Collections.Generic;
using RepostaryXamarinForms.Model;
using RepostaryXamarinForms.Service;
using Xamarin.Forms;

namespace RepostaryXamarinForms.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            Title = "Repostary Example";

            Device.BeginInvokeOnMainThread(async () =>
            {
                var service = new HardwareService();
                _lst.BindingContext = await service.Getlist<Blog2>();

            });

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddPage(), true);
        }

        async void Handle_Refreshing(object sender, System.EventArgs e)
        {
            var service = new HardwareService();
            _lst.BindingContext = await service.Getlist<Blog>();
            _lst.IsRefreshing = false;
        }
    }
}
