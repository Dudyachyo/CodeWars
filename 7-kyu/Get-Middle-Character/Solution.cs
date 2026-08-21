public class Kata
{
  public static string GetMiddle(string s)
  {
    int length = s.Length;
    int index = length / 2;
    
    if (length % 2 == 0)
    {
      return s.Substring(index - 1, 2);
    }
    else 
    {
      return s.Substring(index, 1);
    }
  }
}