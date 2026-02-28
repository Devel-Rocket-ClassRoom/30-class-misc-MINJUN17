using System;
using System.Collections.Generic;
using System.Text;

public static class GameUtils
{
    public static int Clamp(int value, int min, int max)
    {
        return value < min ? min : value > max ? max: value;
    }
    public static int GetPercentage(int current, int max)
    {
        return current * 100 / max ;
    }
    public static bool IsInRange(int value, int min, int max)
    {
        return value > min && value < max;
    }
}
