//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        private IRecipePrinter printer;

        public void SetPrinter(IRecipePrinter printer)
        {
            this.printer = printer;
        }

        public void PrintRecipe(Recipe recipe)
        {
            //printer.Print(recipe.GetTextToPrint());
        }
        
    }
}