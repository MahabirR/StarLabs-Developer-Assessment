//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Abstract parent class 'Products' to contain default method of converting sizes.
// Abstract method to calculate price.
//

using System;
namespace StarLabs_Assessment
{
    public abstract class Products
    {
        public string Name { get; set; }
        public string Size { get; set; }

        public int small = 10;
        public int medium = 20;
        public int large = 30;
        public int default_price = 0;

        public int Convert_Size()
        {
            Size = Size.Trim(); 
            char itemSize;
            Char.TryParse(Size, out itemSize);
            //Assumption of size entry deliberately being string due to double quotes being used in provided code.
            //Also accomadates for future use of 'x' sizes. 

            switch (itemSize)
            {
                case 's':
                    default_price = small;
                    break;
                case 'm':
                    default_price = medium;
                    break;
                case 'l':
                    default_price = large;
                    break;
                default:
                    Console.WriteLine($"Error with {Name} , Size \"{Size}\" invalid");
                    break;
            }
            return default_price;
        }

        public abstract int Price();
    }
}