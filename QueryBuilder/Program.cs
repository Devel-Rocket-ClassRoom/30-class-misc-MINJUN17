using System;

Console.WriteLine("=== 기본 쿼리 ===");
QueryBuilder qbBasic = new QueryBuilder()
    .Select("*")
    .From("Users");
Console.WriteLine(qbBasic.Build());
Console.WriteLine("\n=== 조건 쿼리 ===");
QueryBuilder qbIf = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18");
Console.WriteLine(qbIf.Build());
Console.WriteLine("\n=== 정렬 쿼리 ===");
QueryBuilder qbsort = new QueryBuilder()
    .Select("*")
    .From("Products")
    .Where("Price > 1000")
    .OrderBy("Price");
Console.WriteLine(qbsort.Build());