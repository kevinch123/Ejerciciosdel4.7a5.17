namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            Random aleatorio = new Random();
            int numb1 = aleatorio.Next(-10,10);

            Random aleatori = new Random();
            int numb2 = aleatori.Next(0,11);

            double numb;



            Console.WriteLine($"el numero de la potencia es : {numb1}");
            Console.WriteLine($"el numero base es :{numb2}");


                numb = Math.Pow(numb2,numb1);
                Console.WriteLine(numb);



            
        }
    }
}