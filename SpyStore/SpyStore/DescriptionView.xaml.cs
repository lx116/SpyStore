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

            Description.Text = showProduct.Description;
            Name.Text = showProduct.Name;
            Price.Text = Convert.ToString(showProduct.Price);
            Id.Text = Convert.ToString(showProduct.Id);
        }

        private void AlertDipaly(object sender, EventArgs e)
        {
            DisplayAlert("ERROR", "Contrato falldio", "ok");
        }
    }
}