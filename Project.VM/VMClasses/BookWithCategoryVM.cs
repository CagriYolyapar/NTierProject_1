using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.VMClasses
{
    public class BookWithCategoryVM
    {
        public BookWithCategoryVM()
        {
            Categories = new List<string>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public List<string> Categories { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
