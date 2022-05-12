using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CriptoPlantas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Coleccion();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
