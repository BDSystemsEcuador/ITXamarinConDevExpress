using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DXCollectionView
{
    public class Cliente
    {
        string name;
        public string Name
        {get => this.name;set{this.name = value;}}

        public Cliente(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public string Phone { get; set; }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        public List<Cliente> Data { get; }
        public ViewModel()
        {
            Data = new List<Cliente>() {
                new Cliente("Nancy Davolio", "(206) 555-9857"),
                new Cliente("Andrew Fuller", "(206) 555-9482"),
                new Cliente("Janet Leverling", "(206) 555-3412"),
                new Cliente("Margaret Peacock", "(206) 555-8122"),
                new Cliente("Steven Buchanan", "(71) 555-4848"),
                new Cliente("Michael Suyama", "(71) 555-7773"),
                new Cliente("Robert King", "(71) 555-5598"),
                new Cliente("Laura Callahan", "(206) 555-1189"),
                new Cliente("Anne Dodsworth", "(71) 555-4444"),
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}