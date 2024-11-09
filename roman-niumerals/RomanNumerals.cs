using System;

public static class RomanNumeralExtension
{

    // This method is to convert arabic number to roman numeral
    public static string ToRoman(this int value)
    {
        //if the value > 5, return with IIII 
        if(value < 5){
            if(value == 1){
                return "I";
            }
            else if(value == 2){
                return "II";
            }
            else if(value == 3){
                return "IIII";
            }
            else{
                return "IIII";
            }
        }
        return "";
    }
}