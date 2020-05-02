using System.Collections.Generic;

namespace Decorator
{
    public class SportDisksDecorator : ICar
    {
        private readonly ICar decoratedCar;

        public SportDisksDecorator(ICar decoratedCar)
        {
            this.decoratedCar = decoratedCar;
            Cost = decoratedCar.Cost + 1500;
            decoratedCar.Extra.Add(" + Sport Disks ");
            Extra = decoratedCar.Extra;
        }

        public float Cost { get; set; }
        public List<string> Extra { get; set; } = new List<string>();
    }
}
