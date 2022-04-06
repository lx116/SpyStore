using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpyStore.Assets;
using SpyStore.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpyStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddView : ContentPage
    {
        private ProductList list = new ProductList();
        public AddView()
        {
            
            InitializeComponent();
            
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {
            Products product = new Products();
            
            if (!string.IsNullOrEmpty(EntryName.Text))
            {
                product.Name = EntryName.Text;
            }
            else
            {
                product.Name = "John Doe";
            }
            
            if (!string.IsNullOrEmpty(EntryPrice.Text))
            {
                product.Price = double.Parse(EntryPrice.Text);
            }
            else
            {
                product.Price = 404;
            }
            
            if (!string.IsNullOrEmpty(EntryId.Text))
            {
                product.Id = int.Parse(EntryPrice.Text);
            }
            else
            {
                Random random = new Random();
                product.Id = random.Next(2000,10000);
            }
            
            if (!string.IsNullOrEmpty(EntryDescription.Text))
            {
                product.Description = EntryDescription.Text;
            }
            else
            {
                product.Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel elit quis mi gravida condimentum. Sed nec leo est. " +
                    "Donec a viverra nisl. Nunc dignissim, lacus eu scelerisque laoreet, nunc sapien suscipit metus, nec dapibus quam massa id felis. Vivamus";
            }
            
            list.GlobalProducts.Add(product);
            
            AbsoluteList.RecordList.Add(product);
            

            DisplayAlert("EXITO", "Se ha creado el agente "+ product.Name+" con exito", "NICE");
            
            ClearCamps();
            
        }
        
        void ClearCamps()
        {
            EntryId.Text = "";
            EntryDescription.Text = "";
            EntryPrice.Text = "";
            EntryName.Text = "";
        }
    }
}