using System;
using System.Collections.Generic;
using System.Text;

public partial class Recipe
{
    public void Addingredient(string ingredient)
    {
        if(MaxCount <= IngredientCount)
        {
            Console.WriteLine("배열이 가득참");
        }
        else
        {
            Ingredient[IngredientCount] = ingredient;
            IngredientCount++;
        }
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");
        for(int i = 0; i < IngredientCount; i++)
        {
            Console.WriteLine($"\t{i+1}. {Ingredient[i]}");
        }
        Console.WriteLine();
    }
    public void HasIngredient(string ingredient)
    {
        bool contain = false;
        for (int i = 0; i < IngredientCount; i++)
        {
            if(ingredient == Ingredient[i])
            {
                contain = true;
            }
        }
        if(contain == true)
        {
            Console.WriteLine($"{ingredient} 포함: {contain}");
        }
        else
        {
            Console.WriteLine($"{ingredient} 포함: {contain}");
        }
    }
}
