using System.Collections.Generic;

namespace Decorator
{
    public class Fish : IMeal
    {
        private readonly IMeal meal;
        private int calories = 200;
        private readonly string ingredient = "Fish";

        public Fish()
        {
            Parts = new List<string>();
            Parts.Add(ingredient);
        }

        public Fish(IMeal meal)
        {
            this.meal = meal;
            Calories = meal.Calories + Calories;
            meal.Parts.Add(ingredient + " ");
            Parts = meal.Parts;
        }

        public int Calories { get => calories; set => calories = value; }
        public List<string> Parts { get; set; }
    }
}
