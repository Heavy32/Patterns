using System.Collections.Generic;

namespace Decorator
{
    public interface IMeal
    {
        public int Calories { get; set; }
        public List<string> Parts { get; set; }
    }
}
