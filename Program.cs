using System;
using System.Collections.Generic;

namespace Recepie
{
    class Program
    {
        static void Main(string[] args)
        {
            var recA = new Recipe(1, "CupCake",
                new List<string>() { "rice", "sugar", "oil", "milk" });
            var recB = new Recipe(2, "Hot tube",
                  new List<string>() { "eggs", "sugar", "flour", "water" });
            var recC = new Recipe(3, "Christmas cookies",
                new List<string>() { "mango", "cinamon", "flour", "vodka" });
            var recD = new Recipe(4, "Mom's favourite",
                new List<string>() { "milk", "ice", "coffe", "vodka" });
            var recE = new Recipe(5, "Niko",
                new List<string>() { "horse meat", "bannana", "puding", });

            Console.WriteLine(recA);
            Console.WriteLine(recB);
            Console.WriteLine(recC);
            Console.WriteLine(recD);
            Console.WriteLine(recE);

            var recAC = (Recipe)recA.Clone();
            var recADeepC = new Recipe(recA);
            var recBC = (Recipe)recB.Clone();
            var recBDeepC = new Recipe(recB);
            var recDC = (Recipe)recD.Clone();
            var recDDeepC = new Recipe(recD);


            recAC.Ingredients.Add("bear");
            recAC.ID++;
            recBC.Name = "Cold tuna";
            recBC.Ingredients.Remove("eggs");
            recADeepC.Ingredients.Add("sor");
            recBDeepC.Name = "Mateuska";
            recDC.ID = 67;
            recDC.Ingredients.Clear();

            Console.WriteLine("Deep copy A after mod " + recADeepC);
            Console.WriteLine("A after mod " + recA);
            Console.WriteLine("Clone A: " + recAC);
            Console.WriteLine("Deep copy B after mod " + recBDeepC);
            Console.WriteLine("After mod" + recB);
            Console.WriteLine("Clone B: " + recBC);
            Console.WriteLine("Deep copy D after mod " + recDDeepC);
            Console.WriteLine("After mod" + recD);
            Console.WriteLine("Clone D: " + recDC);

        }
    }
}
