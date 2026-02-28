using System;
using System.Collections.Generic;
using System.Text;


public partial class Recipe
{
    private string[] Ingredient;
    private int IngredientCount;
    private int MaxCount;
    public string Name { get; private set; }
    public int Servings { get; private set; }
    public Recipe(string name, int servings, int Count)
    {
        Name = name;
        Servings = servings;
        IngredientCount = 0;
        MaxCount = Count;
        Ingredient = new string[Count];
    }
    public string this[int index]
    {
        get { return Ingredient[index];}
        set { Ingredient[index] = value; }
    }
}
