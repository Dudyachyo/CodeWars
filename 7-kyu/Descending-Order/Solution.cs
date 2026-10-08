using System;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        char[] digits = num.ToString().ToCharArray();
        Array.Sort(digits); // Сортирует по возрастанию (например, 12345)
        Array.Reverse(digits); // Переворачивает по убыванию (54321)
        return int.Parse(new string(digits)); // Склеивает и возвращает число
    }
}