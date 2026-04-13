namespace Bakery
{
    internal class Cake
    {
        public string flavor;
        public double price;
        public int quantitySold;
        public int quantityInStock;

        public void SellCake(int quantity)
        {
            if (quantity > 0 && quantity <= quantityInStock)
            {
                quantitySold += quantity;
                quantityInStock -= quantity;
            }
        }

        public void IncreaseStock(int quantity)
        {
            if (quantity > 0)
            {
                quantityInStock += quantity;
            }
        }

        public int AvailableQuantity()
        {
            return quantityInStock;
        }

        public double TotalSold()
        {
            return quantitySold * price;
        }
    }
}
