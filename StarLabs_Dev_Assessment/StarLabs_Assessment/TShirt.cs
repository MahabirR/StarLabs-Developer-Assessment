//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Abstract child class to calculate tshirt price
//

using System;
namespace StarLabs_Assessment
{
    public class TShirt : Products
    {
        public override int Price()
        {
            return Convert_Size();
        }
    }
}