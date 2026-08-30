using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] splitted = numbers.Split(' ');
    int number = 0;
    int min = int.MaxValue; int max = int.MinValue;
    for (int i = 0; i < splitted.Length; i++){
      number = int.Parse(splitted[i]);
      if (number > max){
        max = number;
      }
      if(number < min){
        min = number;
      }
    }
    return $"{max} {min}";
  }
}