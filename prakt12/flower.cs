using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt12
{
    public class Flower
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Shade { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public int Length { get; set; }
        public Flower(string name, string type, string shade, string country, decimal price, int stemLength)
        {
            Name = name;
            Type = type;
            Shade = shade;
            Country = country;
            Price = price;
            Length = stemLength;
        }
        // Метод для вывода информации о цветке
        public string GetInfo()
        {
            return $"Название: {Name}, Тип: {Type}, Оттенок: {Shade}, Страна: {Country}, Цена: {Price}, Длина стебля: {Length}";
        }

        // Метод для подсчета стоимости покупки букета
        public string Cost(int quantity)
        {
            decimal totalCost = Price * quantity;
            return $"Стоимость букета из {quantity} цветов: {totalCost}";
        }

        // Дополнительный метод: проверка, является ли цветок дорогим
        public string IsExpensive()
        {
            if(Price > 50)
            {
                return "Дорогая цена";
            }
            else
            {
                return "вполне дешего";
            }
        }
    }

}
