using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Book : BaseEntity
    {
       
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public int? BookshelfID { get; set; }
        public int? AuthorID { get; set; }


        //Relational Properties
        public virtual Bookshelf Bookshelf { get; set; }
        public virtual Author Author { get; set; }

        public virtual List<BookCategory> BookCategories { get; set; }
    }
}
