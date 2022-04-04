using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpyStore.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpyStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescriptionView : ContentPage
    {
        public DescriptionView(Products showProduct)
        {
            InitializeComponent();

            DisplayAlert("Bienvenido", showProduct.Name, "ok");
        }
    }
}