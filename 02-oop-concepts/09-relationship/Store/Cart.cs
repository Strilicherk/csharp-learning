using System.Xml.Linq;

namespace Store
{
    internal class Cart
    {
        public string Customer { get; set; }
        List<Product> productList = new();

        public int GetQuantity()
        {
            return productList.Count;
        }

        public void Add(Product product)
        {
            productList.Add(product);
        }

        public bool ExistsByName(String name)
        {
            foreach (var item in productList)
            {
                if (item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public int GetQuantityByCategory(String category)
        {
            int quantity = 0;
            foreach (var item in productList)
            {
                if (item.Category.Equals(category, StringComparison.CurrentCultureIgnoreCase))
                {
                    quantity++;
                }
            }
            return quantity;
        }

        public void Clear()
        {
            productList.Clear();
        }

        public void RemoveByName(String name)
        {
            foreach (var item in productList.ToList())
            {
                if (item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    productList.Remove(item);
                }
            }
        }

        public Product? GetByName(String name)
        {
            foreach (var item in productList)
            {
                if (item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var item in productList)
            {
                totalValue += item.Price;
            }
            return totalValue;
        }
    }
}
