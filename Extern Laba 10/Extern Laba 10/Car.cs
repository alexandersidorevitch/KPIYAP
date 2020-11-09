using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extern_Laba_10
{
    class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
        public virtual int Price()
        {
            return MaxSpeed * 100;
        }
        public virtual void UpdateModel()
        {
            MaxSpeed += 10;
        }
        public string Information()
        {
            return $"Название: {Name} Макс.скорость: {MaxSpeed} Цена: {Price()}";
        }
    }
}
