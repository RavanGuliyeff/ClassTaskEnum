using Core.Models;
using Core.Helpers;

namespace ClassTaskEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store store = new Store();

            bool c = false;
            do
            {
                string choice = Helper.GetStringInput("1 - Show all products\n2 - Add new product\n3 - Remove Product\n4 - Search product\n0 - Close app\n\n");

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("__All products__\n");
                        store.ShowAllProducts();
                        break;

                    case "2":
                        Console.WriteLine("__Add product__\n");
                        store.AddProduct();
                        break;

                    case "3":
                        Console.WriteLine("__Remove product__\n");
                        store.RemoveProductByNo(Helper.GetIntInput("Enter product number:"));
                        Console.WriteLine("The current state of the products:\n\n");
                        store.ShowAllProducts();
                        break;

                    case "4":
                        do
                        {
                            string subChoice = Helper.GetStringInput("__Search Product__\n\n1 - By product no\t2 - By name\t3 - By type\t0 - Exit to main menu\n\n");
                            switch (subChoice)
                            {
                                case "1":
                                    Product sProduct = store.GetProductByNo(Helper.GetIntInput("Enter product number:"));
                                    if (sProduct != null) Console.WriteLine($"Product no: {sProduct.No}\nName: {sProduct.Name}\nPrice: {sProduct.Price}\nType: {sProduct.Type}\n\n");
                                    else Console.WriteLine("There is no such product");
                                    break;

                                case "2":
                                    Product[] sProductsByName = store.FilterProductsByName(Helper.GetStringInput("Enter product name:"));
                                    if (sProductsByName != null) Store.ShowAllProducts(sProductsByName);
                                    else Console.WriteLine("There is no such products");
                                    break;

                                case "3":
                                    Product[] sProductsByType = store.FilterProductsByType(Helper.GetTypesInput("Select product type:\n1 - Baker\t2 - Drink\t3 - Meat\t4 - Diary\n\n"));
                                    if (sProductsByType != null) Store.ShowAllProducts(sProductsByType);
                                    else Console.WriteLine("There is no such products");
                                    break;

                                case "0":
                                    c = true;
                                    break;

                                default:
                                    break;
                            }
                        }
                        while (!c);
                        c = false;
                        break;

                    case "0":
                        c = true;
                        break;

                    default:
                        break;
                }
            }
            while (!c);
        }
    }
}
