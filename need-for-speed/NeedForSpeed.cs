using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;

    private int battery = 100;
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
        if(battery < 10)
        {

            //TODO: check if below X and if so, cannot drive 
        }

        meterDriven += speed;
        battery -= batteryDrain;

        //TODO: check speed in meters & drain battery by BatteryDrained()

    }

    public static RemoteControlCar Nitro()
    {
        //TODO: not completed yet 
        return new RemoteControlCar(50, 0);
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
        //var batterRequired =  distance ;
        
        
        return false;
    }
}
