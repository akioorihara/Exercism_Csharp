using System;

static class SavingsAccount
{
    //3.213 % for a negative balance(balance gets more negative).
    //0.5 % for a positive balance less than 1000 dollars.
    //1.621 % for a positive balance greater or equal than 1000 dollars and less than 5000 dollars.
    //2.475 % for a positive balance greater or equal than 5000 dollars.
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance < 1000)
        {
            return 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        decimal divider = 100;
        return Convert.ToDecimal(InterestRate(balance)) * balance / divider;

    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        //Assert.Equal(6, SavingsAccount.YearsBeforeDesiredBalance(1_000.0m, 1_100.0m));
        int counter = 0;
        while (true)
        {
            if (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                counter++;

            }
            else
            {
                break;
            }

        }
    
        return counter;
    }
}
