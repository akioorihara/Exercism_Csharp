using System;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
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
        if (Mask == 0)
            return false; 
        if (Mask == 1 && (int)(allergen) == 0)
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