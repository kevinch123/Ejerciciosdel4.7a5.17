namespace ejercicio
{
    public class program
    {
        public static void Main()


        {
            int numb1;
            int numb2;
            string SoR;
            char S;
            int Suma=0;
            int Resta=0;



            Console.WriteLine("Digite dos numeros, se le dara dos opciones (R)resarlo o (S)sumarlo R/S");

            Console.WriteLine("Digite el primer numero");
            numb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            numb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor siga las instrucciones si desea sumar presione(S) si quiere restar presione (R)");
            SoR = Console.ReadLine();

            if (SoR == "S" || SoR == "s"  )
            {
                Suma = numb1 + numb2;

                Console.WriteLine($"La suma es :{Suma}");

            }
            else if (SoR == "R"|| SoR == "r")
            {
                Resta = numb1 - numb2;

                Console.WriteLine($"La suma es :{Resta}");
            }




        }
    }
}