using System;

public static class Kata
{
  public static string Greet(string name)
  {
    string text = "Hello, " + name + " how are you doing today?";
  
  return text;
  // or: return $"Hello, {name} how are you doing today?";
  }
  
}
