using System.Collections.Generic;

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        text = text.ToLower(); 
        
        List<string> result = new List<string>();
        
        foreach (char c in text)
        {
            int index = alphabet.IndexOf(c);
            if (index != -1) 
            {
                result.Add((index + 1).ToString());
            }
        }
        
        return string.Join(" ", result);
    }
}