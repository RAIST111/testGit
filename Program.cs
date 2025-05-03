using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public int Max(int[] ints)
    {
        int a = -1000;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > a)
            {
                a = ints[i];
            }
        }
        return a;
    }
}