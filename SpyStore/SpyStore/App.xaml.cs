using System;
using SpyStore.Assets;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace SpyStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ProductList rock = new ProductList();
            
            rock.ChargeInitialProducts();
            
            MainPage = new NavigationPage(new ListView()){
                BarBackgroundColor = Color.FromHex("#082739"),
                BarTextColor = Color.White,
                
            };
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