using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        //"July 25, 2019 13:45:00"
        //"7/25/2019 13:45:00"
        //"Thursday, December 5, 2019 09:00:00"

        //If String contains '/', replace it with ' ' and replace ':' with ' '
        //If String contains ',', remove the first element as not relevant 
        return DateTime.Parse(appointmentDateDescription);

    }

    public static bool HasPassed(DateTime appointmentDate)
    {

        return true; 
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {


        return true; 
    }

    public static string Description(DateTime appointmentDate)
    {

        return null;
    }

    public static DateTime AnniversaryDate()
    {

        return new DateTime(2019, 09, 09, 12, 12, 12);
    }
}
