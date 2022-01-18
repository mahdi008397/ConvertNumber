namespace ConvertNumber;


public static class ConvertNumber
{
    public static string ConvertToK(this int count)
    {
        decimal res;

        if (count <= 1000) return count.ToString();
        if (count >= 1000000)
        {
            res = decimal.Divide(count, 1000000);
            return $"{res}M";
        }
        else
        {
            res = decimal.Divide(count, 1000);
            return $"{res}K";
        }
    }
}
