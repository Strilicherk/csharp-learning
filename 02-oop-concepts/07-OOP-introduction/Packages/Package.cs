namespace Packages
{
    internal class Package
    {
        public string size;
        public string senderAddress;
        public string recipientAddress;
        public double distance;
        public double productValue;

        public double CalculateShipping()
        {
            Dictionary<string, double> sizeMultipliers = new Dictionary<string, double>()
            {
                {"S", 0.01},
                {"M", 0.03},
                {"L", 0.05},
            };

            double shippingCost = 0;

            if (distance < 50)
            {
                shippingCost = 3.0;
            } else if (distance < 200)
            {
                shippingCost = 5.0;
            } else
            {
                shippingCost = 7.0;
            }

            return shippingCost + (productValue * sizeMultipliers[size]);
        }

        public void ApplyDiscountCoupon(int discountValue)
        {
            productValue = productValue - (productValue * discountValue / 100.0);
        }

        public double TotalPackageValue()
        {
            return productValue + CalculateShipping();
        }
    }
}
