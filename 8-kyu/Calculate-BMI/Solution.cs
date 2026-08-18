using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double bmi = weight/Math.Pow(height, 2);
    if (bmi <= 18.5){
      return "Underweight";
    }
    if (bmi <= 25.0){
      return "Normal";
    }
    if (bmi <= 30.0){
      return "Overweight";
    }
      return "Obese";
    }
  }
