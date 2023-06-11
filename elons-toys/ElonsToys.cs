using System;

class RemoteControlCar
{
    private static readonly int _startingDistance = 0;
    private static readonly int _startingBattery = 100;

    private int _remainingBattery = 100;
    private int _distanceDriven = 0;

    private int _milesDrivenPerDrive  = 20;
    private int _batteryPerDrive = 1;

    public RemoteControlCar()
    {
        _remainingBattery = _startingBattery;
        _distanceDriven = _startingDistance;
    }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }


    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (_remainingBattery <= 0) //at 0%
        {
            return "Battery empty";
        }
        return $"Battery at {_remainingBattery}%";
    }

    public void Drive()
    {
        if (_remainingBattery > 0)
        {
            _distanceDriven += _milesDrivenPerDrive;
            _remainingBattery -= _batteryPerDrive;
        }
    }

}
