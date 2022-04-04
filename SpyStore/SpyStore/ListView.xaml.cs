using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SpyStore.Assets;
using SpyStore.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpyStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage, INotifyPropertyChanged
    {
        public ICommand TestReload { get; set; }
        
        public ICommand GoToDetailCommand { get; set; }

        private Products _selectedProduct;

        public Products SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Products> _blist;
        
        public ObservableCollection<Products> BList
        {
            get { return _blist;}
            set { _blist = value; OnPropertyChanged(); }
        }

        public ListView()
        {
            InitializeComponent();

            

            ProductList list = new ProductList();
            
            list.ChargeInitialProducts();

            BList = new ObservableCollection<Products>();
            
            foreach (var elements in list.GlobalProducts)
            {
                BList.Add(new Products()
                {
                    Id = elements.Id,
                    Name = elements.Name,
                    Description = elements.Description,
                    Price = elements.Price
                });
            }
            
            
            TestReload = new Command(() =>
            {

                var NewElements = AbsoluteList.RecordList.Except(list.GlobalProducts).ToList();
                
                foreach (var listItem in NewElements)
                {
                    BList.Add(new Products()
                    {
                        Id = listItem.Id,
                        Name = listItem.Name,
                        Description = listItem.Description,
                        Price = listItem.Price
                    });
                    list.GlobalProducts.Add(listItem);
                }
            });
            
            GoToDetailCommand = new Command(() =>
            {
                if (SelectedProduct != null)
                {
                    Products sendProducts = new Products();
                    sendProducts.Name = SelectedProduct.Name;
                    sendProducts.Id = SelectedProduct.Id;
                    sendProducts.Description = SelectedProduct.Description;
                    sendProducts.Price = SelectedProduct.Price;
                    
                    Navigation.PushAsync (new DescriptionView(sendProducts));
                    
                }
            });
            
            BindingContext = this;

        }
        
        async void OnNextPageButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new AddView());
        }
    }
}