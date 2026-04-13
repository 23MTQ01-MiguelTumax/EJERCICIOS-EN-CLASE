internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una letra (A, B, C, D, F) y te diré de que tipo es.");
        Console.Write("Letra: ");
        char x;
        x = char.Parse(Console.ReadLine().ToUpper()); 

        switch (x)
        {
            case 'A':
                Console.WriteLine("Su nota es excelente.");
                break;
            case 'B':
                Console.WriteLine("Su nota es buena.");
                break;
            case 'C':
                Console.WriteLine("Su nota es regular.");
                break;
            case 'D':
                Console.WriteLine("Su nota es deficiente.");
                break;
            case 'F':
                Console.WriteLine("Usted está reprobado.");
                break;
            default:
                Console.WriteLine("Ingrese una nota dentro del rango por favor.");
                break;

        }
    }
}