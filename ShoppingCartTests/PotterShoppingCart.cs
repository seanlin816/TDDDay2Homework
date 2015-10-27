using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Tests
{
    public class PotterShoppingCart
    {
        private List<PotterBookSet> potterBookSets = new List<PotterBookSet>();
        public void AddToCard(PotterBook book, int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddBook(book);
            }
        }

        private void AddBook(PotterBook book)
        {
            foreach (var bookSet in potterBookSets)
            {
                if (bookSet.CanAddBook(book))
                {
                    bookSet.AddBook(book);
                    return;
                }
            }
            // Can't find any bookSet
            PotterBookSet pbookSet = new PotterBookSet();
            pbookSet.AddBook(book);
            potterBookSets.Add(pbookSet);
        }
        public double getTotal()
        {
            return potterBookSets.Sum(x => x.GetPrice());
        }
    }
}