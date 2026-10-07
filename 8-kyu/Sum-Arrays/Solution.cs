public class Kata
{
  public static double SumArray(double[] array)
  {
    double result = 0;
    foreach(double number in array){
      result += number;
    }
    return result;
  }
}