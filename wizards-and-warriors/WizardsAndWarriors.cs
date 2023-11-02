using System;

abstract class Character
{
    protected Character(string characterType)
    {

    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false; 
    }

    public override string ToString()
    {
        return "";
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        return 0;
    }
}

class Wizard : Character
{
    public Wizard() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        return 0;
    }

    public void PrepareSpell()
    {

    }
}
