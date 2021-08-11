using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> list; 
    //List<int> list = new List<int>(); 
    //I thought this is how I have to do this to create an empty list 
    
    public HighScores(List<int> list)
    {
        // var sut = new HighScores(new List<int> { 30, 50, 20, 70 });
        // list.Sort();
        // int max = 0, last = list.Count - 1;
        // max = list[last];
        // Console.WriteLine(max);
        // // return max;

        // List<int> listv2 = new List<int>(); 
        this.list = list; 


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
        return list;
        // throw new NotImplementedException();
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

        return list.Max();
        // throw new NotImplementedException();
    }



   
    public List<int> PersonalTopThree()
    {

        /*
        List<int> v2 = new List<int>();
        if (list.Count == 1){
            list.Sort();
            int l = list.Count-1; 
            v2.Add(list[l]);
            return v2;
        }
        else if (list.Count == 2)
        {
            list.Sort();
            int l = list.Count-1; 
            int v = list.Count-2;
            v2.Add(list[l]);
            v2.Add(list[v]);
            return v2; 
        }

        int last = list.Count-1; 
        int second = list.Count-2;
        int  third = list.Count-3; 
        // return list[last], list[second], list[third];

        
        int one = 0;
        int two = 0;
        int three = 0; 
        int temp = 0;    
        //Find Top Val 
        foreach(int i in list)
        {
            if(Math.Max(i,one) == i)
                one = i;
        }

        //Find the second top val 
        foreach(int i in list)
        {
            if(one > i) { 
                if(Math.Max(two, i) == i)
                    two = i; 
            }
        }

         
        list.Sort();
        last = list[last];
        second = list[second];
        third = list[third];
        v2.Add(last);
        v2.Add(second);
        v2.Add(third);

        return v2; 

        */ 
        //throw new NotImplementedException();
       return list; 
    } 
}


/*
 *  [Fact]
    public void Latest_score_should_not_change_after_calling_personal_top_three()
    {
        var sut = new HighScores(new List<int> { 20, 100, 30, 90, 2, 70 });
        Assert.Equal(new List<int> { 100, 90, 70 }, sut.PersonalTopThree());
        Assert.Equal(70, sut.Latest());
    }
}
 * 
 */