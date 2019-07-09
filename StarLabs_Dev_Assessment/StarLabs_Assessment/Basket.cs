//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Basket class to contain arrays of 'Pants' and 'Shirts'.
// Calls abstract 'price' method to calcualte individual prices.
//

using System;
using System.Collections;

namespace StarLabs_Assessment
{
    public class Basket
    {
        public ArrayList Shirts;
        public ArrayList Pants;
        public Basket()
        {
            Shirts = new ArrayList();
            Pants = new ArrayList();
        }

        public int GetTotalPrice()
        {
            int sum = 0;
            foreach (Products S in Shirts)
            {
                sum += S.Price();
            }
            foreach (Products P in Pants)
            {
                sum += P.Price();
            }
            return sum;
        }
    }
}