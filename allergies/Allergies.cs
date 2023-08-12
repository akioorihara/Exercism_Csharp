using System;
using System.Collections.Generic;


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
    private int mask;
    public Allergies(int mask)
    {
        this.mask = mask;
    }
    public bool IsAllergicTo(Allergen allergen)
    {
        int shift = (this.mask >> (int)allergen) & 1;
        if (shift == 0) return false;
        else return true;
    }
    public Allergen[] List()
    {
        List<Allergen> allergens = new List<Allergen>();
        for (int i = 0; i < 8; i++)
        {
            if (((mask >> i) & 1) == 1) allergens.Add((Allergen)i);
        }
        return allergens.ToArray();
    }
}