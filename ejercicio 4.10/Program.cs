namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int numb;

            Console.WriteLine("se detectara si el numero introducido esta entre 10 y 100");

            Console.WriteLine("Digite el numero");
            numb = Convert.ToInt32(Console.ReadLine());


            if (numb>=10 && numb<=100)
            {
                Console.WriteLine($"El numero introducido esta en el rango entre 10 y 100 el numero introducido fue:{numb}");
            }
            else
            {
                Console.WriteLine("fuera de rango");
            }
        }
    }
}
