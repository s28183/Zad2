using System.Security.AccessControl;

namespace Lab022;

public class Konflikt
{
    public static void Main1(string[] args)
    {
        int[] tab = {5,4,3,2,1};
        int x = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("Ile :" + tab[i] + " " + x);
        }
        
    }
}