using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10
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
        public Product Product { get; set; }
        public int Quantity { get; set; }

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
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddOrderItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public decimal CalculateTotalOrderPrice()
        {
            return Items.Sum(item => item.CalculateTotalPrice());
        }
    }

    public class Program
    {
        private static List<Product> products = new List<Product>();
        private static Order currentOrder = new Order();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add product");
                Console.WriteLine("2. Create order item");
                Console.WriteLine("3. Add item to order");
                Console.WriteLine("4. Show total order price");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an action: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        CreateOrderItem();
                        break;
                    case "3":
                        AddOrderItemToOrder();
                        break;
                    case "4":
                        ShowTotalOrderPrice();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                products.Add(new Product(name, price));
                Console.WriteLine("Product added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid price. Product not added.");
            }
        }

        static void CreateOrderItem()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Please add products first.");
                return;
            }

            Console.WriteLine("Available products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - {products[i].Price:C}");
            }

            Console.Write("Select product number: ");
            if (int.TryParse(Console.ReadLine(), out int productIndex) && productIndex > 0 && productIndex <= products.Count)
            {
                Console.Write("Enter quantity: ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                {
                    OrderItem newItem = new OrderItem(products[productIndex - 1], quantity);
                    currentOrder.AddOrderItem(newItem);
                    Console.WriteLine("Order item added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid quantity.");
                }
            }
            else
            {
                Console.WriteLine("Invalid product selection.");
            }
        }

        static void AddOrderItemToOrder()
        {
            Console.WriteLine("Item has already been added to the order upon creation.");
        }

        static void ShowTotalOrderPrice()
        {
            decimal totalPrice = currentOrder.CalculateTotalOrderPrice();
            Console.WriteLine($"Total order price: {totalPrice:C}");
        }
    }
}