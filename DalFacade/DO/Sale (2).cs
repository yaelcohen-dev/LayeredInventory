using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale
        (
            int Id,
            int ProductId,
            int? MinAmount,
            double? SalePrice,
            bool IsForClub,
            DateOnly? Begin,
            DateOnly? End
        )
    {
        public Sale() : this(0, 0, 1, null, false, null, null)//Each sale get preview sale id plus one.
        {

        }
    }
}