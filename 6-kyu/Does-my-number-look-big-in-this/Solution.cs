using System;
public class Kata
{
  public static bool Narcissistic(int value)
  {
    string valueStr = value.ToString();
    double result = 0; 
    for (int i = 0; i < valueStr.Length; i++){
      int digit = valueStr[i] - '0';
      result += Math.Pow(digit, valueStr.Length);
    }
    return (result == value) ? true : false;
  }
}