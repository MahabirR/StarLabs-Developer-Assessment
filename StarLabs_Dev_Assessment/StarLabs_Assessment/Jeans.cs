//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Abstract child class to calculate jeans price
//

using System;
namespace StarLabs_Assessment
{
    public class Jeans : Products
    {
        public override int Price()
        {
            return Convert_Size();
        }
    }
}