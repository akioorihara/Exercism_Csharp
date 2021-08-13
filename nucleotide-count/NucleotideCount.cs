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
            sequence;

            if (dict.ContainsKey('A'))
            {
                dict['A'] += 1;  

            }
            if (dict.ContainsKey('C'))
            {
                dict['C'] += 1;

            }
            if (dict.ContainsKey('G'))
            {
                dict['G'] += 1;

            }
            if (dict.ContainsKey('T'))
            {
                dict['T'] += 1;

            }

        }

        return dict;
        //throw new NotImplementedException("You need to implement this function.");
    }
}