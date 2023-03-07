using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.VMClasses
{
    public class BookVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurName { get; set; }

        public override string ToString()
        {
            return $"{Title} {PageNumber} {AuthorName} {AuthorSurName}";
        }
    }
}
