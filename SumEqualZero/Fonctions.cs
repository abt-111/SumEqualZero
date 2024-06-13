public static class Fonctions
{
    public static void Generation(int[] entiers)
    {
        int n = entiers.Length;

        for (int i = 0; i < n; i++)
        {
            if (i < (n / 2))
            {
                GenerationEntierUnique(entiers, i, -100, 0);
            }
            else if (i == (n - 1))
            {
                entiers[i] = -entiers.Sum();
            }
            else
            {
                GenerationEntierUnique(entiers, i, 0, 100);
            }
        }
    }

    public static void GenerationEntierUnique(int[] entiers, int i, int min, int max)
    {
        Random random = new Random();
        int entierTemporaire;
        // On vérifie que l'entier n'est pas déjà présent dans le tableau
        do
        {
            entierTemporaire = Convert.ToInt32(random.NextInt64(min, max));
        }
        while (entiers.Contains(entierTemporaire));

        entiers[i] = entierTemporaire;
    }

    public static void Affichage(int[] entiers)
    {
        int n = entiers.Length;
        string chaine = "[";

        for (int i = 0; i < n; i++)
        {
            chaine += entiers[i];
            if (i < (n - 1))
            {
                chaine += ",";
            }
        }
        chaine += "]";
        Console.WriteLine(chaine);
    }
}
