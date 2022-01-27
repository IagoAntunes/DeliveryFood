using DeliveryApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DeliveryApp.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Categoria> CategoriasComida { get; set; }
        public ObservableCollection<Comida> ListaComidas { get; set; }
        public int ItensCesta { get; set; }
        public ICommand btnAdicionar { get; set; }

        public HomeViewModel()
        {
            btnAdicionar = new Command(Adicionar);
            CategoriasComida = new ObservableCollection<Categoria>()
            {
                new Categoria(){Nome="Sanduiche",Imagem="Burger"},
                new Categoria(){Nome="Comidas do Mar",Imagem="ComidaMarinha"},
                new Categoria(){Nome="Bebida",Imagem="Bebida"}
            };
            ListaComidas = new ObservableCollection<Comida>()
            {
                new Comida {  Nome="Chicken Royal", Tipo="Hamburger", Preco="$12",Imagem="HamburguerOpcao"},
                new Comida { Nome="King Loobster", Tipo="Seafood", Preco="$25", Imagem="HamburguerOpcao" },
                new Comida { Nome="Chicken Royal", Tipo="Hamburger", Preco="$12", Imagem="HamburguerOpcao"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Adicionar()
        {
            ItensCesta++;
        }

    }
}
