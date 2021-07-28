using System;

public class SpaceAge
{
    int seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        // Convert Eatch seconds into Earth Years
        double EarthYears = seconds / 31557600;

        // Convert Eearth Years into Planet's years
        //double PlanetYears = EarthYears / 1;

        return EarthYears;





        //double Earth = 1000000000.00 / 31536000.00;
        //return Earth; 
        //throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMercury()
    {
        // Convert Eatch seconds into Earth Years
        double EarthYears = this.seconds / 31557600;

        // Convert Eearth Years into Mercury's years
        double PlanetYears = EarthYears / 0.2408467;

        return PlanetYears;
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}