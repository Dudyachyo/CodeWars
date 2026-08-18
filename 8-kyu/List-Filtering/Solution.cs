using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     List<int> numbers = new List<int>();
     foreach (object number in listOfItems){
       if (number is int num) {
         numbers.Add(num);
       }
     }
    return numbers;
   }
}
