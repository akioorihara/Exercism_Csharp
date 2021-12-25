using System;

static class SavingsAccount
{
    //3.213 % for a negative balance(balance gets more negative).
    //0.5 % for a positive balance less than 1000 dollars.
    //1.621 % for a positive balance greater or equal than 1000 dollars and less than 5000 dollars.
    //2.475 % for a positive balance greater or equal than 5000 dollars.
    public static float InterestRate(decimal balance)
    {
        if( balance < 0)
        {
            return 3.213f;
        }
        else if(balance < 1000)
        {
            return 0.5f;
        }
        else if(balance >=1000 && balance < 5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }

        //throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        //Implement the(static) SavingsAccount.Interest() method to calculate the interest based on the specified balance:
        //SavingsAccount.Interest(balance: 200.75m)
        // 1.00375
        decimal divider = 100;
        return Convert.ToDecimal(InterestRate(balance)) * balance / divider;
            //InterestRate(balance) * balance / 100.00F;



    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        //Implement the(static) SavingsAccount.AnnualBalanceUpdate() method to calculate the annual balance update,
        //taking into account the interest rate:
        //SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
        //201.75375m
        //Assert.Equal(0.0000m, SavingsAccount.AnnualBalanceUpdate(0.0m));
        //ssert.Equal(0.000001005m, SavingsAccount.AnnualBalanceUpdate(0.000001m));
        //Assert.Equal(1016.210000m, SavingsAccount.AnnualBalanceUpdate(1_000.0m));
        return balance + Convert.ToDecimal(InterestRate(balance)) * balance;


    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
