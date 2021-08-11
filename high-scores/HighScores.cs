using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> list;


    public HighScores(List<int> list)
    {

        this.list = list;

    }

    public List<int> Scores()
    {

        return list;
    }

    public int Latest()
    {
        //int last = list.Count - 1;
        //return list[last];
        return list.Last();

    }

    public int PersonalBest()
    {
        return list.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> cList = new List<int>(list);
       
        //cList = list; //If I use this, list also gets sorted and why does this also sort 'list' itself instead of just cList???
        List<int> v2 = new List<int>();
        if (cList.Count == 1)
        {
            cList.Sort();
            int l = cList.Count - 1;
            v2.Add(cList[l]);
            return v2;
        }
        else if (cList.Count == 2)
        {
            cList.Sort();
            int l = cList.Count - 1;
            int v = cList.Count - 2;
            v2.Add(cList[l]);
            v2.Add(cList[v]);
            return v2;
        }

        int last = list.Count - 1;
        int second = list.Count - 2;
        int third = list.Count - 3;

        cList.Sort();
        last = cList[last];
        second = cList[second];
        third = cList[third];
        v2.Add(last);
        v2.Add(second);
        v2.Add(third);

        return v2;

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