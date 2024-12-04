using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Lab10_2
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal CalculateTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    public class Order
    {
        public List<OrderItem> Items { get; } = new List<OrderItem>();

        public void AddOrderItem(OrderItem item)
        {
            Items.Add(item);
        }

        public decimal CalculateTotalOrderPrice()
        {
            return Items.Sum(item => item.CalculateTotalPrice());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var product1 = new Product("Product 1", 10.0m);
            var product2 = new Product("Product 2", 20.0m);

            order.AddOrderItem(new OrderItem(product1, 2));
            order.AddOrderItem(new OrderItem(product2, 3));

            Console.WriteLine($"Total Order Price: {order.CalculateTotalOrderPrice()}");
        }
    }

    [TestFixture]
    public class OrderManagementTests
    {
        [Test]
        public void Product_Constructor_SetsNameAndPrice()
        {
            var product = new Product("Test Product", 10.0m);
            Assert.That(product.Name, Is.EqualTo("Test Product"));
            Assert.That(product.Price, Is.EqualTo(10.0m));
        }

        [Test]
        public void OrderItem_CalculateTotalPrice_ReturnsCorrectTotal()
        {
            var product = new Product("Test Product", 10.0m);
            var orderItem = new OrderItem(product, 5);
            var totalPrice = orderItem.CalculateTotalPrice();
            Assert.That(totalPrice, Is.EqualTo(50.0m));
        }

        [Test]
        public void Order_AddOrderItem_AddsItemToList()
        {
            var order = new Order();
            var product = new Product("Test Product", 10.0m);
            var orderItem = new OrderItem(product, 1);
            order.AddOrderItem(orderItem);
            Assert.That(order.Items.Count, Is.EqualTo(1));
            Assert.That(order.Items[0], Is.EqualTo(orderItem));
        }

        [Test]
        public void Order_CalculateTotalOrderPrice_ReturnsCorrectTotal()
        {
            var order = new Order();
            var product1 = new Product("Product 1", 10.0m);
            var product2 = new Product("Product 2", 20.0m);
            var orderItem1 = new OrderItem(product1, 2);
            var orderItem2 = new OrderItem(product2, 3);
            order.AddOrderItem(orderItem1);
            order.AddOrderItem(orderItem2);
            var totalOrderPrice = order.CalculateTotalOrderPrice();
            Assert.That(totalOrderPrice, Is.EqualTo(80.0m));
        }

        [Test]
        public void Order_CalculateTotalOrderPrice_ReturnsZeroForEmptyOrder()
        {
            var order = new Order();
            var totalOrderPrice = order.CalculateTotalOrderPrice();
            Assert.That(totalOrderPrice, Is.EqualTo(0m));
        }
    }
}
