//clone is used to copy the string object   data.
//by default clone return type is Object
using System;    
    public class StringExample  
    {    
        public static void Main(string[] args)    
        {    
             string s1 = "Hello ";    
             string s2 = (String)s1.Clone();   
             Console.WriteLine(s1);  
             Console.WriteLine(s2);    
        }    
    }   