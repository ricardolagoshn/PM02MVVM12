using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02MVVM12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.PageOrdenes();
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
