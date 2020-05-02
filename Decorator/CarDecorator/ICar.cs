using System.Collections.Generic;

namespace Decorator
{
    public interface ICar
    {
        public float Cost { get; set; }

        public List<string> Extra { get; set; }
    }
}
