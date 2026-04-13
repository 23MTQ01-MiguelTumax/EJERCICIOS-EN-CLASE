internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==================");
        Console.WriteLine("DÍAS DE LA SEMANA");
        Console.WriteLine("==================");

        Console.WriteLine("Dime un número del 1 al 7 y te diré que día es.");
        int x;

        Console.Write("Número: ");
        x = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Ingrese un número dentro del rango.");
                break;
        }
    }
}