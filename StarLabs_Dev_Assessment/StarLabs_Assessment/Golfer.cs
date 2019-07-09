//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Abstract child class to calculate golfer price
//

using System;
namespace StarLabs_Assessment
{
    public class Golfer : Products
    {
        public override int Price()
        {
            return Convert_Size() * 2;
        }
    }
}