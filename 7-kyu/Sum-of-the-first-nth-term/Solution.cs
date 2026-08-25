using System;

public class NthSeries {
    public static string seriesSum (int n) {
        double result = 0;
        for (int i = 0; i < n; i++) {
            result += 1.0 / (1 + 3 * i);
        }
        return result.ToString("F2");
    }
}