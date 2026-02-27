using System;

Money money = new Money(100, 50);
Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"지갑: {money}");
Console.WriteLine();

Money money2 = money.Add(50, 30);
Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {money2}");
Console.WriteLine($"원본 지갑: {money}");
Console.WriteLine();

Money money3 = money.Substract(20, 30);
Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {money3}");
Console.WriteLine($"원본 지갑: {money}");
Console.WriteLine();

Console.WriteLine("=== 메서드 체이닝 ===");
Money money4 = new Money(100, 50)
    .Add(50, 30)
    .Substract(20, 30);
Console.WriteLine($"결과: {money4}");