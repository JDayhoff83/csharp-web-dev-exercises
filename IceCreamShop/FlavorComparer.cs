using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            /*return string.Compare(x.Name, y.Name);*/
            double diff = x.Allergens.Count - y.Allergens.Count;
            if (diff == 0)
            {
                return 0;
            }
            else if (diff < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
