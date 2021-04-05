using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using ITXamarin.Data;
using ITXamarin.ViewModels;

namespace ITXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }
        public MainPage()
        {
            DevExpress.XamarinForms.CollectionView.Initializer.Init();
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new MainPageViewModel();
            this.BindingContext = ViewModel;
            await ViewModel.LoadClients();
        }
    }
}
