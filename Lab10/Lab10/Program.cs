using System;
using System.Collections.Generic;

namespace lab10
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
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public decimal CalculateTotalOrderPrice()
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.CalculateTotalPrice();
            }
            return total;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Order currentOrder = new Order();

            while (true)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Додати товар");
                Console.WriteLine("2. Створити елемент замовлення");
                Console.WriteLine("3. Додати елемент до замовлення");
                Console.WriteLine("4. Вивести загальну вартість замовлення");
                Console.WriteLine("5. Вихід");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Введіть назву товару: ");
                    string productName = Console.ReadLine();
                    Console.Write("Введіть ціну товару: ");
                    decimal productPrice = decimal.Parse(Console.ReadLine());

                    Product newProduct = new Product(productName, productPrice);
                    products.Add(newProduct);
                    Console.WriteLine($"Товар {productName} додано.");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Виберіть товар:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i].Name} - {products[i].Price} грн");
                    }
                    int productChoice = int.Parse(Console.ReadLine()) - 1;

                    Console.Write("Введіть кількість: ");
                    int quantity = int.Parse(Console.ReadLine());

                    OrderItem newOrderItem = new OrderItem(products[productChoice], quantity);
                    currentOrder.AddOrderItem(newOrderItem);
                    Console.WriteLine($"Елемент замовлення додано: {products[productChoice].Name}, кількість: {quantity}");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Виберіть елемент замовлення для додавання:");
                    for (int i = 0; i < currentOrder.OrderItems.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {currentOrder.OrderItems[i].Product.Name} - {currentOrder.OrderItems[i].Quantity} шт.");
                    }

                    int orderItemChoice = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Введіть додаткову кількість: ");
                    int additionalQuantity = int.Parse(Console.ReadLine());

                    currentOrder.OrderItems[orderItemChoice].Quantity += additionalQuantity;
                    Console.WriteLine($"До елемента замовлення додано {additionalQuantity} одиниць.");
                }
                else if (choice == "4")
                {
                    decimal totalPrice = currentOrder.CalculateTotalOrderPrice();
                    Console.WriteLine($"Загальна вартість замовлення: {totalPrice} грн");
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                }
            }
        }
    }
}
