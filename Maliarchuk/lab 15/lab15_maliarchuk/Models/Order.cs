namespace lab15_maliarchuk.Models
{
    public class Order
    {
        public int Id { get; set; } // Унікальний ідентифікатор замовлення
        public string ProductName { get; set; } = string.Empty; // Назва продукту
        public int Quantity { get; set; } // Кількість продукту
        public DateTime OrderDate { get; set; } // Дата замовлення

        // Додаткові властивості можна додати за потреби
        public string CustomerName { get; set; } = string.Empty; // Ім'я клієнта
        public string CustomerEmail { get; set; } = string.Empty; // Електронна пошта клієнта
    }
}
