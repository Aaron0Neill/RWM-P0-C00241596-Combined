using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Xor21Filter.Xor21s(FactFilter.Factorial(xs));
    }
}

