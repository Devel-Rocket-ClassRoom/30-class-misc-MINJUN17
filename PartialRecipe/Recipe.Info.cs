using System;
using System.Collections.Generic;
using System.Text;


public partial class Recipe
{
    private string[] ingredient;
    private int IngredientCount;
    public string Name { get; private set; }
    public int Servings { get; private set; }
    public Recipe(string name, int servings, int ingredientCount)
    {
        Name = name;
        Servings = servings;
        IngredientCount = ingredientCount;
    }
    public string this[int index]
    {
        get { return ingredient[index];}
        set { ingredient[index] = value; }
    }
}
