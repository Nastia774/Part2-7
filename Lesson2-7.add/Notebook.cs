using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_7.add
{
    struct Notebook
    {
        string _model;
        string _manufacturer;
        double _price;
        public Notebook(string model, string manufacturer, double price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }
        public void Write()
        {
            Console.WriteLine($"Модель : {_model}, Производитель : {_manufacturer}, Цена : {_price} ");
        }
    }
}
