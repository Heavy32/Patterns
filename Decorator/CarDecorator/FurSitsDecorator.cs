using System.Collections.Generic;

namespace Decorator
{
    public class FurSitsDecorator : ICar
    {
        private readonly ICar decoratedCar;

        public FurSitsDecorator(ICar decoratedCar)
        {
            this.decoratedCar = decoratedCar;
            Cost = decoratedCar.Cost + 1000;
            decoratedCar.Extra.ForEach(x => Extra.Add(x));
            Extra.Add("+ Fur sits ");
        }

        public float Cost { get; set; }
        public List<string> Extra { get; set; } = new List<string>();
    }
}
