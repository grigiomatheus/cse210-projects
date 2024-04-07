using System.Text;

namespace Foundation2.Models
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;

            foreach (var product in _products)
            {
                totalPrice += product.GetPrice();
            }

            return totalPrice + GetShippingCost();
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();

            foreach (var product in _products)
            {
                packingLabel.AppendLine(product.GetProductLabel());
            }

            return packingLabel.ToString();
        }

        public string GetShippingLabel() => _customer.GetInformation();

        private double GetShippingCost()
        {
            if (_customer.LivesInUSA())
                return 5d;
            else
                return 35d;
        }
    }
}