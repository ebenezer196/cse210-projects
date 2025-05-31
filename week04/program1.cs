using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string Name { get => _name; }
        public string ProductId { get => _productId; }
        public double Price { get => _price; }
        public int Quantity { get => _quantity; }

        public double GetTotalCost()
        {
            return _price * _quantity;
        }
    }

    public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country.Trim().ToUpper() == "USA";
        }

        public override string ToString()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }

    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string Name { get => _name; }
        public Address Address { get => _address; }

        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }
    }

    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double totalProductCost = 0;
            foreach (var product in _products)
            {
                totalProductCost += product.GetTotalCost();
            }

            double shippingCost = _customer.LivesInUSA() ? 5 : 35;

            return totalProductCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _products)
            {
                sb.AppendLine($"{product.Name} (ID: {product.ProductId})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_customer.Name);
            sb.AppendLine(_customer.Address.ToString());
            return sb.ToString();
        }
    }
}
