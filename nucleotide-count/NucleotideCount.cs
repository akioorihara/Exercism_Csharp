using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dict = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        //init dict and allocate a memory 
        //  var expected = new Dictionary<char, int>

        for(int i = 0; i < sequence.Length; i++)
        {
            
            if (dict.ContainsKey(sequence[i]))
            {
                dict[sequence[i]]++;  

            }
            else
            {
                throw new ArgumentException("Invalid Nuceotides");
            }

        }

        return dict;
        //throw new NotImplementedException("You need to implement this function.");
    }
}