using System.Collections.Generic;
using SpyStore.Models;
using Xamarin.Forms;

namespace SpyStore.Assets
{
    public static class AbsoluteList
    {
        public static List<Products> RecordList = new List<Products>();
    }
    
    public class ProductList
    {
        public List<Products> GlobalProducts = new List<Products>();
        
        public void ChargeInitialProducts()
        {
            GlobalProducts.Add(new Products()
            {
                Name = "Rock", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel elit quis mi gravida condimentum. Sed nec leo est. " +
                              "Donec a viverra nisl. Nunc dignissim, lacus eu scelerisque laoreet, nunc sapien suscipit metus, nec dapibus quam massa id felis. Vivamus",
                Price =  150,
                Id = 0
            });
            GlobalProducts.Add(new Products()
            {
                Name = "Bill", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel elit quis mi gravida condimentum. Sed nec leo est. " +
                              "Donec a viverra nisl. Nunc dignissim, lacus eu scelerisque laoreet, nunc sapien suscipit metus, nec dapibus quam massa id felis. Vivamus",
                Price = 250,
                Id = 1
            });
            GlobalProducts.Add(new Products()
            {
                Name = "Rest", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel elit quis mi gravida condimentum. Sed nec leo est. " +
                              "Donec a viverra nisl. Nunc dignissim, lacus eu scelerisque laoreet, nunc sapien suscipit metus, nec dapibus quam massa id felis. Vivamus",
                Price = 50,
                Id = 2
            });
            GlobalProducts.Add(new Products()
            {
                Name = "Lotus", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel elit quis mi gravida condimentum. Sed nec leo est. " +
                              "Donec a viverra nisl. Nunc dignissim, lacus eu scelerisque laoreet, nunc sapien suscipit metus, nec dapibus quam massa id felis. Vivamus",
                Price = 450,
                Id = 3
            });
            
        }

        public string ComprobationSave(string save)
        {
            foreach (var element in GlobalProducts)
            {
                if (save == element.Name)
                {
                    save = "Se ha encontrado" + element.Name;
                }
            }

            return save;
        }
    }
    
}