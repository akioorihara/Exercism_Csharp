using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> list = new List<int>(); 
    
    public HighScores(List<int> list)
    {
        // var sut = new HighScores(new List<int> { 30, 50, 20, 70 });
        // list.Sort();
        // int max = 0, last = list.Count - 1;
        // max = list[last];
        // Console.WriteLine(max);
        // // return max;

        List<int> listv2 = new List<int>(); 
        this.list = listv2; 


        // throw new NotImplementedException();
    }

//how do i know if there is void func? 
//Score() returns the whole list but how should I return or print out?

    public List<int> Scores()
    {
        // List<int> list = new List<int>(); 
        // foreach(int i in list ){
        //     Console.Write(i);
        // }
        throw new NotImplementedException();
    }

    public int Latest()
    {
        // List<int> list = new List<int>(); 
        int last = list.Count-1;
        return list[last];
        // throw new NotImplementedException();
    }
//This is not passing any args and how could I return or test agaist the list value? 



    public int PersonalBest()
    {
        throw new NotImplementedException();
    }

    public List<int> PersonalTopThree()
    {
        throw new NotImplementedException();
    }
}