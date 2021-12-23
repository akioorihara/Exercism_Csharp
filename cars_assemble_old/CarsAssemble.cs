using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed <= 0)
        {
            return 0.0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1.0;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else {
            return 0.77;
        }
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    //if the speed = 1, 221 cars per hour | 

    public static double ProductionRatePerHour(int speed)
    {
        //Assert.Equal(1591.2, AssemblyLine.ProductionRatePerHour(9), precision: 1)
        int perHour = 221; 
        if (speed <= 0)
        {
            return (SuccessRate(speed) * perHour * speed);
        }
        else if (speed >= 1 && speed <= 4)
        {
            return (SuccessRate(speed) * perHour * speed);
        }
        else if (speed >= 5 && speed <= 8)
        {
            return (SuccessRate(speed) * perHour * speed);
        }
        else if (speed == 9)
        {
            return (SuccessRate(speed) * perHour * speed);
        }
        else
        {
            return (SuccessRate(speed) * perHour * speed);
        }
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int perHour = 221;
        int perMinute = 60;
        if (speed <= 0)
        {
            return Convert.ToInt32(ProductionRatePerHour(speed) / perMinute);
        }
        else if (speed >= 1 && speed <= 4)
        {
            return Convert.ToInt32(Math.Floor (ProductionRatePerHour(speed) / perMinute) );
        }
        else if (speed >= 5 && speed <= 8)
        {
            return Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / perMinute));
        }
        else if (speed == 9)
        {
            return Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / perMinute)); 
        }
        else
        {
            return Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / perMinute));
        }
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
