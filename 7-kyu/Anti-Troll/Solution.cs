using System.Linq;
using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
      return string.Concat(str.Where(c => !"aeuioAEUIO".Contains(c)));
      
    }
}