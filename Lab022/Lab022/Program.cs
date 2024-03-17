// See https://aka.ms/new-console-template for more informatio

using System.Security.AccessControl;

class Program
{
    public static void Main(string[] args)
    {
        int[] tab = {1,2,3,4,5};
        Console.WriteLine(WyliczSrednia(tab));
    }
    public static int WyliczSrednia(int[] tab)
    {
        int counter = 0;
        for(int i =0; i < tab.Length; i++)
        {
            counter = counter + tab[i];
        }
        Console.WriteLine("Pierwsza zmiana");
        Console.WriteLine("Druga zmiana");
        return counter / tab.Length;
    }
}
