using System;
using System.Collections.Generic;
using System.Text;



internal class Money
{
    public int Gold { get; private set; }
    public int Silver { get; private set; }

    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }
    public Money Add(int gold, int silver)
    {
        return new Money(Gold + gold, Silver + silver);
    }
    public Money Substract(int gold, int silver)
    {
        if(gold  < Gold && silver < Silver)
        {
            return new Money(Gold - gold, Silver - silver);
        }
        else
        {
            Console.WriteLine("잔액부족");
            return new Money(Gold, Silver);
        }
    }
    public override string ToString()
    {
        return $"{Gold}골드, {Silver}실버";
    }
}

