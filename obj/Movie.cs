using System.Collections.Generic;

namespace A11_Convert
{
    public class MovieContext
    {
        public long Id {get; set;}
        public string Title {get; set;}
        public virtual ICollection<Genres> Genres {get; set;}
    }
}