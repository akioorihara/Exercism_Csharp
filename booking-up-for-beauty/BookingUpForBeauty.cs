using System;
using Xunit;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        //"July 25, 2019 13:45:00"
        //"7/25/2019 13:45:00"
        //"Thursday, December 5, 2019 09:00:00"

        //Assert.Equal(new DateTime(2019, 6, 3, 11, 30, 0), Appointment.Schedule("7/25/2019 13:45:00"));

        return DateTime.Parse(appointmentDateDescription);

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentDateTime = DateTime.Now;
        if (currentDateTime >= appointmentDate)
            return true;
        return false; 
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int StartTime = 12;
        int EndTime = 18; 
        var apptHour = appointmentDate.Hour;
        if(apptHour >= StartTime && apptHour < EndTime)
            return true;
        return false; 
    }   

    public static string Description(DateTime appointmentDate)
    {
        return "You have an appointment on " + appointmentDate.ToString("M/d/yyyy h:mm:ss tt") + ".";
    }

    public static DateTime AnniversaryDate()
    {
        var ThisYear = DateTime.Now.Year;
        var AnnivMonth = 9;
        var AnnivDay = 15; 
        return new DateTime(ThisYear, AnnivMonth, AnnivDay);
    }
}
