using DeliveryApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeliveryApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
     
      
        public Inicio()
        {
            InitializeComponent();
        }
        private void GoHome(object sender,EventArgs args)
        {
            App.Current.MainPage = new View.Home();
        }
    }
}