public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    string result = "";
    for (int i = 0; i < numbers.Length; i ++){
      if (i == 0){
        result+= $"({numbers[i]}";
      }
      else if (i == 2){
        result+= $"{numbers[i]}) ";
      }
      else if (i == 5){
        result += $"{numbers[i]}-";
      }
      else {
        result += $"{numbers[i]}";
      }
    }
    return result;
  }
}