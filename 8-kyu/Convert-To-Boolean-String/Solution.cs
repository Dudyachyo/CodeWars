using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
    string Yes = "Yes";
    string No = "No";
    if (word == true){
      return Yes;
    }
    else {
      return No;
    }
  }
}