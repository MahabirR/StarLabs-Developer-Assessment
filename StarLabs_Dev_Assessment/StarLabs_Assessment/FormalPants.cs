//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Abstract child class to calculate formal pants price
//

using System;
namespace StarLabs_Assessment
{
    public class FormalPants : Products
    {
        public override int Price()
        {
            return Convert_Size() + 30;
        }
    }
}