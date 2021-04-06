using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ITXamarin.Helpers;
using ITXamarin.Models;
using Xamarin.Forms;
namespace ITXamarin.ViewModels
{
     public class MainPageViewModel :BaseViewModel
    {
        public ObservableCollection<Cliente> Clientes { get; set; }
        public ObservableCollection<Clientes> ClientesModel { get; set; }
        public ICommand SearchCommand { get; set; }
        public MainPageViewModel()
        {
            SearchCommand =
                new Command(async (text) =>
                {
                    string url = "";
                    var service =
                    new HttpHelper<Clientes>();
                    var clientes =
                        await service.GetRestServiceDataAsync(url);
                    Clientes = new ObservableCollection<Cliente>(clientes.cliente);

                });
        }
        public async Task LoadClients() {
            var url = "http://192.168.1.1:64777//Service1.svc/getClientesSQL";
            var service =
                new HttpHelper<Clientes>();
            var clientes = await service.GetRestServiceDataAsync(url);
            Clientes = new ObservableCollection<Cliente>(clientes.cliente);
        }

    }
}