using System;

public class CountDig
{
    public static int NbDig(int n, int d)
    {
        int count = 0;
        char target = Convert.ToChar(d.ToString());
        
        for (int k = 0; k <= n; k++)
        {
            string sq = (k * k).ToString();
            foreach (char c in sq)
            {
                if (c == target)
                {
                    count++;
                }
            }
        }
        
        return count;
    }
}