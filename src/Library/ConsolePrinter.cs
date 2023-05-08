using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
     public class ConsolePrinter : IRecipePrinter
    {
        public void Print(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }

}