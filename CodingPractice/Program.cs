using System;
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

////1
//Person person = new Person();
//person.Name = "홍길동";
//person.Age = 25;
//person.Print();

//public partial class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//public partial class Person
//{
//    public void Print()
//    {
//        Console.WriteLine($"{Name}: {Age}");
//    }
//}

////2
//Hello hello = new Hello();
//hello.Hi();
//hello.Bye();

//public partial class Hello
//{
//    public void Hi()
//    {
//        Console.WriteLine("안녕하세요!");
//    }
//}
//public partial class Hello
//{
//    public void Bye()
//    {
//        Console.WriteLine("안녕히 가세요!");
//    }
//}

////3
//Console.WriteLine($"덧셈 : {Calculator.Add(10,20)}");
//Console.WriteLine($"뺄셈 : {Calculator.Subtract(10, 20)}");
//Console.WriteLine($"곱셈 : {Calculator.Multiply(10, 20)}");

//public static class Calculator
//{
//    public static int Add(int x, int y)
//    {
//        return x + y;
//    }
//    public static int Subtract(int x, int y)
//    {
//        return x - y;
//    }
//    public static int Multiply(int x, int y)
//    {
//        return x * y;
//    }
//}

////4
//Console.WriteLine($"{StringHelper.CleanAndUpper(" hello world ")}");
//Console.WriteLine($"{StringHelper.Reverse("hello")}");
//Console.WriteLine($"{StringHelper.IsNullOrEmpty(string.Empty)}");
//public static class StringHelper
//{
//    public static string CleanAndUpper(string input)
//    {
//        string cau = input.Trim().ToUpper();
//        return cau;
//    }
//    public static string Reverse(string input)
//    {
//        StringBuilder sb = new StringBuilder();
//        for(int i = input.Length-1; i >= 0; i--)
//        {
//            sb.Append(input[i]);
//        }
//        return sb.ToString();
//    }
//    public static bool IsNullOrEmpty(string input)
//    {
//        if(input == null || input == string.Empty)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

////5
//Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
//Console.WriteLine($"거듭제곱근: {Math.Pow(2, 3)}");
//Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
//Console.WriteLine($"최솟값: {Math.Min(10, 20)}");

////6
//StringBuilder sb1 = new StringBuilder();
//sb1.Append("Hello");
//sb1.Append(" ");
//sb1.Append("World");
//Console.WriteLine($"{sb1}");
//String sb2 = new StringBuilder()
//    .Append("Hello")
//    .Append(" ")
//    .Append("World")
//    .ToString();
//Console.WriteLine($"{sb2}");

////7
//string mb = new MessageBuilder()
//    .AddText("안녕하세요!")
//    .AddNewLine()
//    .AddText("반갑습니다.")
//    .AddSpace()
//    .AddText("좋은")
//    .AddSpace()
//    .AddText("하루")
//    .AddSpace()
//    .AddText("되세요!")
//    .Build();
//Console.WriteLine(mb);

//class MessageBuilder
//{
//    private string _message = string.Empty;
//    public MessageBuilder AddText(string text)
//    {
//        _message += text;
//        return this;
//    }
//    public MessageBuilder AddSpace()
//    {
//        _message += " ";
//        return this;
//    }
//    public MessageBuilder AddNewLine()
//    {
//        _message += "\n";
//        return this;
//    }
//    public string Build()
//    {
//        return _message;
//    }

//}

////8
//Point point = new Point(0, 0)
//    .MoveBy(10, 10)
//    .MoveBy(20, 20)
//    .MoveBy(30, 30);
//Console.WriteLine(point);

//class Point
//{
//    private readonly int X;
//    private readonly int Y;

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//    public Point MoveBy(int dx, int dy)
//    {
//        return new Point(X + dx, Y + dy);
//    }
//    public override string ToString()
//    {
//        return $"({X},{Y})";
//    }
//}

////9
//string hello = "Hello World"
//    .Trim()
//    .ToLower()
//    .Replace(" ", "_");
//Console.WriteLine(hello);

////10
//MutableCircle circle = new MutableCircle(10);
//Console.WriteLine($"반지름: {circle.Radius}");
//circle.Radius = 20;
//Console.WriteLine($"반지름: {circle.Radius}");
//public class MutableCircle
//{
//    public int Radius { get; set; }
//    public MutableCircle(int radius)
//    {
//        Radius = radius;
//    }
//}

////11
//ImmutableCircle ic = new ImmutableCircle(10);
//Console.WriteLine($"원본 반지름: {ic.Radius}");
//ImmutableCircle ic2 = ic.WithRadius(20);

//Console.WriteLine($"새 원 반지름: {ic2.Radius}");
//Console.WriteLine($"원본 반지름: {ic.Radius}");
//class ImmutableCircle
//{
//    public int Radius { get; }
//    public ImmutableCircle(int radius)
//    {
//        Radius = radius;
//    }
//    public ImmutableCircle WithRadius(int newRadius)
//    {
//        return new ImmutableCircle(newRadius);
//    }

//}

////12
//Player player1 = new Player("용사", 1);
//Player player2 = player1.LevelUp();
//Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
//Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");

//class Player
//{
//    public readonly string Name;
//    public readonly int Level;

//    public Player(string name, int level)
//    {
//        Name = name;
//        Level = level;
//    }
//    public Player LevelUp()
//    {
//        return new Player(Name, Level + 1);
//    }
//}

////13
//string text = "Hello";
//string upperText = text.ToUpper();

//Console.WriteLine(text);
//Console.WriteLine(upperText);

////14
//Character c = new Character("용사", 100, 1);
//Console.WriteLine($"{c._name} - 레벨: {c._level}, 체력: {c._health}");
//c.TakeDamage(30);
//c.Heal(10);

//public partial class Character
//{
//    public string _name { get; set; }
//    public int _health { get; set; }
//    public int _level { get; set; }

//    public Character(string name, int health, int level)
//    {
//        _name = name;
//        _health = health;
//        _level = level;
//    }
//}

//public partial class Character
//{
//    public void TakeDamage(int damage)
//    {
//        _health -= damage;
//        if(_health < 0)
//        {
//            _health = 0;
//        }
//        Console.WriteLine($"{_name}이 {damage}의 피해를 입음, 남은 체력: {_health}");
//    }
//    public void Heal(int amount)
//    {
//        _health += amount;
//        Console.WriteLine($"{_name}이 {amount}만큼 회복함, 남은 체력: {_health}");
//    }
//}

////15
//Console.WriteLine($"계산된 데미지: {GameHelper.CalculateDamage(20,3)}");
//Console.WriteLine($"생존 여부: {GameHelper.IsAlive(10)}");
//Console.WriteLine($"체력상태: {GameHelper.GetHealthStatus(31, 100)}");
//public static class GameHelper
//{
//    public static int CalculateDamage(int BaseDamage, int level) => BaseDamage + (level * 5);
//    public static bool IsAlive(int health) => health > 0;
//    public static string GetHealthStatus(int health, int maxHealth)
//    {
//        if (maxHealth <= 0)
//        {
//            return health > 0 ? "오류" : "사망";
//        }

//        double ratio = (double)health / maxHealth;

//        if (ratio > 0.7)
//        {
//            return "양호";
//        }
//        else if (ratio > 0.3)
//        {
//            return "주의";
//        }
//        else if (ratio > 0)
//        {
//            return "위험";
//        }
//        else
//        {
//            return "사망";
//        }
//    }
//}

//16
Vector2D vector = new Vector2D(1, 1)
    .Add(2, 3)
    .Multiply(2)
    .Add(-1, -2);
Console.WriteLine(vector);

class Vector2D
{
    public readonly double X;
    public readonly double Y;
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}