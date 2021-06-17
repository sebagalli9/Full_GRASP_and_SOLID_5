//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        public Product FinalProduct { get; set;}
        public void AddStep(Product input, double quantity, Equipment equipment, int time);
        public void AddStep(string description, int time);
        public void RemoveStep(BaseStep step);
        public string GetTextToPrint();
        public double GetProductionCost();
    }
}