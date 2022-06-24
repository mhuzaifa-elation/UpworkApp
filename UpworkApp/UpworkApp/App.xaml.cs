using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UpworkApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ConceptTabbedPage();
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
