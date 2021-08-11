using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(firstStrand.Length != secondStrand.Length)
            Console.WriteLine("Not The Same Length");


        int counter = 0; 
        string charString = "CAGT";
        foreach(char c in firstStrand)
        {
            int i = 0;
            //if(firstStrand[i] != secondStrand[i])
            if(firstStrand[i] != secondStrand[i] && charString.Contains(char.ToUpper(c)))
            {
                counter += 1; 
            }
            i++; 
        }
        return counter; 
        //throw new NotImplementedException("You need to implement this function.");
    }
}

// Assert.Equal(9, Hamming.Distance("GGACGGATTCTG", "AGGACGGATTCT"));