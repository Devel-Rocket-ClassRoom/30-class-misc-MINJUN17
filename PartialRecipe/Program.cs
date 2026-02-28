using System;

Recipe bibimBab = new Recipe("비빔밥", 2, 5);
bibimBab.Addingredient("밥");
bibimBab.Addingredient("고추장");
bibimBab.Addingredient("계란");
bibimBab.Addingredient("시금치");
bibimBab.Addingredient("당근");
bibimBab.PrintRecipe();
bibimBab.HasIngredient("계란");
bibimBab.HasIngredient("소고기");
Console.WriteLine();
Recipe sandwich = new Recipe("샌드위치", 1, 3);
sandwich.Addingredient("빵");
sandwich.Addingredient("햄");
sandwich.Addingredient("치즈");
sandwich.PrintRecipe();


