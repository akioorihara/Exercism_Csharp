using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;

    public int battery = 100;
    private int meterDriven = 0; 

    public RemoteControlCar(int Speed, int BatteryDraid) {
        this.speed = Speed;
        this.batteryDrain = BatteryDraid;
        this.meterDriven = 0;
    }



    public bool BatteryDrained()
    {
        if(battery >= batteryDrain)
            return false;
        return true; 
    }

    public int DistanceDriven()
    {
        return meterDriven;
    }

    public void Drive()
    {
        if (battery < batteryDrain)
        {

        }
        else
        {
            this.meterDriven += speed;
            this.battery -= batteryDrain; //-- ?? not sure 
        }
        //TODO: check speed in meters & drain battery by BatteryDrained()

    }

    public static RemoteControlCar Nitro()
    {
        //TODO: How can I make it 4% - make it decimal? 
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance; 
    public RaceTrack(int Distance)
    {
        this.distance = Distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {

        //TODO: 
        decimal distanceBySpeed = (distance / (decimal)car.speed);
        var carFinish = car.batteryDrain * distanceBySpeed <= 100;
        return carFinish;

        //var possibleDrain = distanceBySpeed * car.batteryDrain;
        //if (possibleDrain >= car.battery)
        //    return true;

        //return false;
        


    }
}
