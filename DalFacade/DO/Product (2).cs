using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product
        (
            int Id,
            string? Name,
            Categories? Category,
            double? Price,
            int? Amount
        )
    {
        public Product():this(0, "",null,0.00,0)//Each product get preview product id plus one.
        {

        }
    }
}
