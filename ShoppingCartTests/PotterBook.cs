namespace ShoppingCart.Tests
{
    public class PotterBook
    {
        private double price = 100;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Volumn { get; set; }
        public string Name { get; set; }
    }
}