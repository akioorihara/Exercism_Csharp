using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
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
    int Mask;
    public List<string> list = new List<string>();

    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if (Mask <= 0)
            return false;

        while (Mask != 0 | Mask <= 0)
        {
            if (Mask >= (int)Allergen.Cats)
            {
                Mask = Mask - (int)Allergen.Cats;
                list.Add(allergen.ToString());
            }

            if (Mask >= (int)Allergen.Pollen)
            {
                Mask = Mask - (int)Allergen.Pollen;
                list.Add(allergen.ToString());
            }

            if (Mask >= (int)Allergen.Chocolate)
            {
                Mask = Mask - (int)Allergen.Chocolate;
                list.Add(allergen.ToString());
            }

            if (Mask >= (int)Allergen.Tomatoes)
            {
                Mask = Mask - (int)Allergen.Tomatoes;
                list.Add(allergen.ToString());
            }
            if (Mask >= (int)Allergen.Strawberries)
            {
                Mask = Mask - (int)Allergen.Strawberries;
                list.Add(allergen.ToString());
            }
            if (Mask >= (int)Allergen.Shellfish)
            {
                Mask = Mask - (int)Allergen.Shellfish;
                list.Add(allergen.ToString());
            }
            if (Mask >= (int)Allergen.Peanuts)
            {
                Mask = Mask - (int)Allergen.Peanuts;
                list.Add(allergen.ToString());
            }
            if (Mask >= (int)Allergen.Eggs)
            {
                Mask = Mask - (int)Allergen.Eggs;
                list.Add(allergen.ToString());
            }

        }

        //return (list.Contains(allergen.ToString())) ? true : false 
        if (list.Contains(allergen.ToString()))
            return true;
        else
            return false;

        throw new ArgumentException("Invalid Allergen");
        //throw new NotImplementedException("You need to implement this function.");
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}