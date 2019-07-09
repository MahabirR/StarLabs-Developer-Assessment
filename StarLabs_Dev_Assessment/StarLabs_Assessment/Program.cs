//Ruchit Mahabir
//StarLabs assessment
//06/07/19
//
// Base class to enter data and run the program
//

using System;

namespace StarLabs_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = "m"; 
            basket.Shirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Marvel Comics";
            golfer.Size = "s";
            basket.Shirts.Add(golfer);

            var jeans = new Jeans();
            jeans.Name = "Android";
            jeans.Size = "s";
            basket.Pants.Add(jeans);

            var formalpants = new FormalPants();
            formalpants.Name = "iOS";
            formalpants.Size = "l";
            basket.Pants.Add(formalpants);

            Console.WriteLine($"Your total price is {basket.GetTotalPrice()}");
            Console.Read();

        }
    }
}