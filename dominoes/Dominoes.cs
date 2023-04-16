using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        //var dominoes = new[] { (1, 2), (1, 3), (2, 3) };
        int first = 0, second = 0;
        int counter = 0;
        foreach (var d in dominoes)
        {
            counter++;

            if ((first == d.Item1) || (first == d.Item2)) 
            {
                continue;
            }
            else if(first != 0)
            {
                return false;
            }


            first = d.Item1;
            second = d.Item2;
            
        }
        if(counter < 2)
        { return true; }




        return true;
    }
}
