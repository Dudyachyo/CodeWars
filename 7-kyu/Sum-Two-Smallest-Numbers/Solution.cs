public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
     int TheLowest = int.MaxValue;
     int ALittlehigherThanLower = int.MaxValue;
		 for (int i = 0; i < numbers.Length; i++){
       if (numbers[i] < TheLowest){
         ALittlehigherThanLower = TheLowest;
         TheLowest = numbers[i];
         }
       else if(numbers[i] < ALittlehigherThanLower) {
         ALittlehigherThanLower = numbers[i];
       }
     }
    return TheLowest + ALittlehigherThanLower;
	}
}