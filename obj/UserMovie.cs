using System;
using System.Collections.Generic;

namespace A11_Convert
{
    public class UserMovie
    {
        public long Id { get; set; }
        public long Rating {get;set;}
        public DateTime RatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Movie Movie { get; set; }

    }
}