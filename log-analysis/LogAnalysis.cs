using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    //Assert.Equal(" am the 1st test", "I am the 1st test".SubstringAfter("I"));
    public static string SubstringAfter(this string value, string str){

        //Allow retrieving the string after a specific substring
        //" test", "I am the 2nd test".SubstringAfter("2nd"))
        
        // int found = value.IndexOf(str);
        // value = value.Remove(found, str.Length);

        string [] words = value.Split(str);
        return words[1]; 
        
    } 
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string value, string str1, string str2){
        //"[INFO]: File Deleted.".SubstringBetween("[", "]"));
        //Assert.Equal("SOMETHING", "FIND >>> SOMETHING <===< HERE".SubstringBetween(">>> ", " <===<"));
        int found1 = value.IndexOf(str1); //0
        int found2 = value.IndexOf(str2); //5
        value = value.Remove(found2);
        value = value.Remove(found1, str1.Length);
            
        return value;
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string value){
        return value.SubstringAfter("[WARNING]: ");   
   
    }


    
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string value){
        // "[WARNING]: Library is deprecated.";
        // Assert.Equal("WARNING", log.LogLevel());
        
        value = value.Replace("[", " ");
        value = value.Replace("]", " ");
        string [] words = value.Split(" ");
        return words[1];
    }
}