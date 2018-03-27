using Firebase.Xamarin.Database;
using RepostaryXamarinForms.Views;
using Xamarin.Forms;

namespace RepostaryXamarinForms
{
    public partial class App : Application
    {

        public static readonly FirebaseClient firebaseClient = new FirebaseClient("https://fir-blogapp-1e856.firebaseio.com/");
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new  ListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
