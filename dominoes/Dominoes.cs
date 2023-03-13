using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        //var dominoes = new[] { (1, 2), (4, 1), (2, 3) };
        //check the length and if > 2
        //returns false 

        int first = 0, second = 0;

        int counter = 0;
        foreach (var d in dominoes)
        {
            counter++;

            if ((counter != 0 && first == d.Item1) || (counter != 0 && first == d.Item2)) 
            {
                continue;
            }
            else if((counter != 0 && first != 0) || (counter != 0 && first != 0))
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
