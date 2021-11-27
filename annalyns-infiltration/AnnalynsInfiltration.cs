using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        else {
            return true;
        }
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //one of them is awake 
        if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
        {
            return true; 
        }
        else
        {
            return false;
        }
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //Signal prisoner: the prisoner can be signalled using bird sounds if the prisoner is awake and the archer is sleeping,
        //as archers are trained in bird signaling so they could intercept the message.
        //if (archerIsAwake is true && prisonerIsAwake is false)
        
        if(archerIsAwake is false && prisonerIsAwake is true)
        {
            return true;
        }
        else
        {
            return false;
        }
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //Free prisoner: Annalyn can try sneaking into the camp to free the prisoner. This is a risky thing to do and can only succeed in one of two ways:
        //If Annalyn has her pet dog with her she can rescue the prisoner if the archer is asleep.
        //The knight is scared of the dog and the archer will not have time to get ready before Annalyn and the prisoner can escape.

        //If Annalyn does not have her dog then she and the prisoner must be very sneaky!
        //Annalyn can free the prisoner if the prisoner is awake and the knight and archer are both sleeping,
        //but if the prisoner is sleeping they can't be rescued: the prisoner would be startled by Annalyn's sudden appearance and wake up the knight and archer.
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");


        /*
        Implement the (static) QuestLogic.CanFreePrisoner() method that takes four boolean values.
        The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake. The last parameter indicates if Annalyn's pet dog is present.
        The method returns true if the prisoner can be freed based on the state of the three characters and Annalyn's pet dog presence. Otherwise, it returns false:
         
         */

        if (petDogIsPresent is true && archerIsAwake is false){
            return true; 
        }
        if (prisonerIsAwake is true && knightIsAwake is false && archerIsAwake is false)
        {
            if (prisonerIsAwake is true)
            {
                return true;
            }
            return false;
        }
        else;
        {
            return false; 
        }

    }
}
