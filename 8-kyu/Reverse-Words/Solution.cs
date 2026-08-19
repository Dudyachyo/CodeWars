using System.Linq;
using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    return string.Join(" ", str.Split(' ').Select(word => new string(word.Reverse().ToArray())));
  }
}