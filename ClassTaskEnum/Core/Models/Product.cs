using Core.Helpers.Exceptions;
using Core.Helpers.Enums;

namespace Core.Models
{
    public class Product
    {
        private static int _no;
        public readonly int No;

        public string Name { get; set; }

        private double _price = 0;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0) throw new PriceMustBeGratherThanZeroException();
                else _price = value;
            }
        }

        public Types Type { get; set; }


        public Product(string name, double price, Types type)
        {
            Name = name;
            Price = price;
            Type = type;
            No = ++_no;
        }
    }
}

