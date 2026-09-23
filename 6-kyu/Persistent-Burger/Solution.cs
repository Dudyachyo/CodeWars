using System;

public class Persist 
{
    public static int Persistence(long n) 
    {
        int steps = 0;
        while (n >= 10) 
        {
            long product = 1;
            while (n > 0) 
            {
                product = product * (n % 10); 
                n = n / 10;                   
            }
            
            n = product;
            steps++;     
        }
      
        return steps;
    }
}