using Xunit;

namespace lab10.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalculateTotalPrice()
        {
            var product = new Product("Телефон", 10000);
            var orderItem = new OrderItem(product, 2);

            Assert.Equal(20000, orderItem.CalculateTotalPrice());
        }

        [Fact]
        public void TestAddOrderItem()
        {
            var order = new Order();
            var product = new Product("Телефон", 10000);
            var orderItem = new OrderItem(product, 2);

            order.AddOrderItem(orderItem);

            Assert.Single(order.OrderItems);
        }

        [Fact]
        public void TestCalculateTotalOrderPrice()
        {
            var order = new Order();
            var product1 = new Product("Телефон", 10000);
            var product2 = new Product("Ноутбук", 15000);

            order.AddOrderItem(new OrderItem(product1, 2));
            order.AddOrderItem(new OrderItem(product2, 1));

            Assert.Equal(35000, order.CalculateTotalOrderPrice());
        }
    }
}
