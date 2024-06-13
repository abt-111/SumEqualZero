internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int n, somme, entierTemporaire;
        int[] entiers;

        Console.Write("Entrez un entier : ");
        // Que des n pairs pour le moment pour le moment
        n = Convert.ToInt32(Console.ReadLine());

        entiers = new int[n];

        for (int i = 0; i < n; i++)
        {
            if(i < (n / 2))
            {
                entiers[i] = Convert.ToInt32(random.NextInt64(-100, 0));
            }
            else if(i == (n - 1))
            {
                entiers[i] = -entiers.Sum();
            }
            else
            {
                entiers[i] = Convert.ToInt32(random.NextInt64(0, 100));
            }
        }

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(entiers[i]);
        }

        Console.WriteLine(entiers.Sum());
    }
}