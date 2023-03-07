using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Bookshelf : BaseEntity
    {
        public string CodeNumber { get; set; }

        //Relational Properties
        public virtual List<Book> Books { get; set; } 
    }
}
