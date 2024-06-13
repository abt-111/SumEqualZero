internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        int[] entiers;

        Console.Write("Entrée : n = ");
        n = Convert.ToInt32(Console.ReadLine());

        entiers = new int[n];

        // Génération
        Fonctions.Generation(entiers);

        // Affichage sous la forme [-7,-1,1,3,4]
        Fonctions.Affichage(entiers);

        // Vérification de la valeure de somme
        // Console.WriteLine(entiers.Sum());
    }
}