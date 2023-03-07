using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class BookCategory : BaseEntity
    {
        public int BookID { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual Book Book { get; set; }

    }
}
