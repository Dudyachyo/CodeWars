using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string numbers = n.ToString();
    string result = "";
    foreach (char c in numbers){
      int digit = int.Parse(c.ToString());
      int square = digit * digit;
      result += square.ToString();
    }
    return int.Parse(result);
  }
}