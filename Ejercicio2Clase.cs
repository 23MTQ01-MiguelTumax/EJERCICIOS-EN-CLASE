internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==================");
        Console.WriteLine("FAST CALCULATOR");
        Console.WriteLine("==================");

        double num1, num2, suma, resta, mult, div;
        int op;
        Console.WriteLine("Dime dos números y una opción y te diré el resultado.");
        Console.WriteLine("Opción 1: Suma");
        Console.WriteLine("Opción 2: Resta");
        Console.WriteLine("Opción 3: Multiplicación");
        Console.WriteLine("Opción 4: División");

        Console.Write("Número 1:");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Número 2:");
        num2 = double.Parse(Console.ReadLine());
        Console.Write("Opción: ");
        op= int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                suma = num1 + num2;
                Console.WriteLine("El resultado de la suma es: " + suma);
                break;
            case 2:
                resta = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + resta);
                break;
            case 3:
                mult = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es: " + mult);
                break;
            case 4:
                div = num1 / num2;
                Console.WriteLine("El resultado de la división es: " + div);
                break;
            default:
                Console.WriteLine("Ingrese una opción dentro del rango.");
                break;
        }
        }
}