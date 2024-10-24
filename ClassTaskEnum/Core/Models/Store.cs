using Core.Helpers.Enums;
using Core.Helpers;

namespace Core.Models
{
    public class Store
    {
        private Product[] _products;
        public Store()
        {
            _products = new Product[0];
        }


        public void ShowAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"Product no: {product.No}\nName: {product.Name}\nPrice: {product.Price}\nType: {product.Type}\n");
            }
        }

        public static void ShowAllProducts(Product[] products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Product no: {product.No}\nName: {product.Name}\nPrice: {product.Price}\nType: {product.Type}\n");
            }
        }


        public void AddProduct()
        {
            try
            {
                string name = Helper.GetStringInput("Name of the product: ");
                double price = Helper.GetDoubleInput("Price of the product: ");
                Types type = Helper.GetTypesInput("Select the product's type:\n1 - Baker\t2 - Drink\t3 - Meat\t4 - Diary\n");

                Product product = new Product(name, price, type);

                Array.Resize(ref _products, _products.Length + 1);
                _products[^1] = product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = new Product[0];
            foreach (Product product in _products)
            {
                if (product.No != no)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[^1] = product;
                }
            }
            _products = newProducts;
        }


        public Product GetProductByNo(int? no)
        {
            foreach (Product product in _products)
            {
                if (product.No == no) return product;
            }
            return null;
        }


        public Product[] FilterProductsByType(Types type)
        {
            Product[] filteredProducts = new Product[0];
            foreach (Product product in _products)
            {
                if (product.Type == type)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[^1] = product;
                }
            }
            return filteredProducts;

        }


        public Product[] FilterProductsByName(string name)
        {
            Product[] filteredProducts = new Product[0];
            foreach (Product product in _products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[^1] = product;
                }
            }
            return filteredProducts;
        }
    }
}
