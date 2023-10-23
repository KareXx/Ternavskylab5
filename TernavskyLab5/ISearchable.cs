using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyLab5
{
    internal interface ISearchable
    {
        List<Product> SearchByPrice();
        List<Product> SearchByCategory(string categoryName);
        List<Product> SearchByRating();
    }
}
