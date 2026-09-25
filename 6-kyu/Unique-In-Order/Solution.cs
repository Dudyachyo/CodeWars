using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> result = new List<T>();        
        foreach (T item in iterable) 
        {
            if (result.Count == 0 || !result[result.Count - 1].Equals(item))
            {
                result.Add(item);
            }
        }       
        return result;
    }
}