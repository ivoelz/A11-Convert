using System.Collections.Generic;

namespace A11_Convert
{
    public class Genre
    {
        public string Name {get; set;}
        public long Id {get; set;}
        public virtual ICollection<Genres> Genres {get; set;}
    }
}