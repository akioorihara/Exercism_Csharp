using System;

class RemoteControlCar
{
    //20 meters and drains one percent of battries
    //Start with 100$ of battries

    public int battery = 100;
    public int Driven = 0;


    public static RemoteControlCar Buy()
    {

        //private int _battery = 100;
        //private int _Driven = 0;
        return null;
    }


    public string DistanceDisplay()
    {
        return "Driven " + Driven + " meters";
    }

    public string BatteryDisplay()
    {
        if (battery <= 0) //at 0%
        {
            return "Battery empty";
        }
        return "Battery at " + battery;
    }

    public void Drive()
    {
        Driven += 20;
        battery -= 1;
    }

}
