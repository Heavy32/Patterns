using System.Collections.Generic;

namespace Decorator
{
    public class Potato : IMeal
    {
        private readonly IMeal meal;
        private int calories = 300;
        private readonly string ingredient = "Potato";

        public Potato()
        {
            Parts = new List<string>();
            Parts.Add(ingredient);
        }

        public Potato(IMeal meal)
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
