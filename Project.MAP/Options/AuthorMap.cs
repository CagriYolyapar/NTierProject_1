using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AuthorMap:BaseMap<Author>
    
    {
        public AuthorMap()
        {
            HasOptional(x => x.AuthorProfile).WithRequired(x => x.Author);
        }
    }
}
