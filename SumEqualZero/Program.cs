internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int n, somme, entierTemporaire;
        int[] entiers;

        Console.Write("Entrez un entier : ");
        n = Convert.ToInt32(Console.ReadLine());

        entiers = new int[n];

        for (int i = 0; i < n; i++)
        {
            if(i < (n / 2))
            {
                // On vérifie que l'entier n'est pas déjà présent dans le tableau
                do
                {
                    entierTemporaire = Convert.ToInt32(random.NextInt64(-100, 0));
                }
                while (entiers.Contains(entierTemporaire));

                entiers[i] = entierTemporaire;
            }
            else if(i == (n - 1))
            {
                entiers[i] = -entiers.Sum();
            }
            else
            {
                // On vérifie que l'entier n'est pas déjà présent dans le tableau
                do
                {
                    entierTemporaire = Convert.ToInt32(random.NextInt64(0, 100));
                }
                while (entiers.Contains(entierTemporaire));

                entiers[i] = entierTemporaire;
            }
        }

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(entiers[i]);
        }

        Console.WriteLine(entiers.Sum());
    }
}