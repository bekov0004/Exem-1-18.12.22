public class Min
{

   public int FindMinimum(int a, int b, int c, int d)
    {
        var find = new List<int>(){a,b,c,d};
        return find.Min();
    }
}