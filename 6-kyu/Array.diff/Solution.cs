using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    List<int> result = new List<int>();

    foreach (int numberA in a)
    {
      bool isFind = false;
      foreach (int numberB in b){
        if (numberB == numberA) { isFind = true; break; }
      }
      if (isFind == false) { result.Add(numberA); }
    }
    return result.ToArray();
  }
}