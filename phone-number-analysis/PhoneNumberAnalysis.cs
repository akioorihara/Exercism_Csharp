using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // Assert.Equal((false, false, "1234"), PhoneNumber.Analyze("631-502-1234"));
        bool IsNewYork = false;
        bool IsFake = false;
        string LocalNumber = "";
        string PhoneNumber = phoneNumber;

        //check NY area code 
        IsNewYork = ("212" == PhoneNumber.Substring(0,3)) ? IsNewYork = true : IsNewYork = false;

        //check 555 
        IsFake = ("555" == PhoneNumber.Substring(4, 3)) ? IsFake = true : IsFake = false;

        //string 
        LocalNumber = (PhoneNumber.Substring(8, 4));

        return (IsNewYork, IsFake, LocalNumber); 

    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        //Assert.True(PhoneNumber.IsFake(PhoneNumber.Analyze("212-555-1234")));
        bool isFake = phoneNumberInfo.IsFake;

        return isFake;
        //throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
