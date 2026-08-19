public class Kata
{
  public int Min(int[] list)
  {
    int min=0;
    foreach (int number in list){
      if (min > number){
        min = number;
      }
    }
    return min;
  }
  
  public int Max(int[] list)
  {
    int max=0;
    foreach (int number in list){
      if (max < number){
        max = number;
      }
    }
    return max;
  }
}
//Or we can use System.Linq to find the min and max values in the list more efficiently:
//using System.Linq;    
// with code
/* public int Min(int[] list)
  {
    return list.Min();
  }

    public int Max(int[] list)
    {
        return list.Max();
    }
  */