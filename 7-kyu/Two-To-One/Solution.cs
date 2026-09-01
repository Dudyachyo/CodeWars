public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
  {
        string newString = s1 + s2; string result = "";
    for (char c = 'a'; c <= 'z'; c++)
        {
            if (newString.Contains(c))
            {
                result += c;
            }
        }
    return result;
    
    
  }
}