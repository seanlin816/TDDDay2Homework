using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Tests
{
    internal class PotterBookSet
    {
        private readonly List<PotterBook> Items = new List<PotterBook>();

        internal double GetPrice()
        {
            return Items.Sum(x => x.Price) * GetDiscount();
        }

        private double GetDiscount()
        {
            double discountRate = 1;
            switch (Items.Count)
            {
                case 1:
                    discountRate = 1;
                    break;
                case 2:
                    discountRate = 0.95;
                    break;
                case 3:
                    discountRate = 0.9;
                    break;
                case 4:
                    discountRate = 0.80;
                    break;
                case 5:
                    discountRate = 0.75;
                    break;
            }
            return discountRate;
        }

        internal bool CanAddBook(PotterBook book)
        {
            var isExist = Items.Any(x => x.Volumn == book.Volumn);
            return !isExist;

        }
        internal void AddBook(PotterBook book)
        {
            Items.Add(book);
        }
    }
}