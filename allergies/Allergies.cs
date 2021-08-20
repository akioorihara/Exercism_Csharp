using System;

public enum Allergen
{
    Eggs = 1 ,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    int Mask, Coutner; 
    public Allergies(int mask)
    {
        Mask = mask; 
    }
    public int checker()
    {
        if(Mask == 1)
            return 0;
        throw new ArgumentException("Invalid Allergen");
    }
    public bool IsAllergicTo(Allergen allergen)
    {
        while(Mask != 0)
        {
            if(Mask > (int)allergen)
            {
                return true; 
            }
        }
        if (Mask == 0)
            return false; 
        if (Mask == 1 && (int)(allergen) == 1)
            return true;


        throw new ArgumentException("Invalid Allergen");
        //throw new NotImplementedException("You need to implement this function.");
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
//var sut = new Allergies(3);
//Assert.True(sut.IsAllergicTo(Allergen.Eggs));