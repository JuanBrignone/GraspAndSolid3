using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
public class FilePrinter : IRecipePrinter
    {
        public void Print(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}