namespace conversion
{
    public class program
    {
        public static void Main()
        {
            double u, d, c, m, valor;

            Console.WriteLine("Escriba su numero entero para la conversión a romano");
            valor = Convert.ToInt32(Console.ReadLine());

            m = Math.Truncate(valor / 1000);
            c = Math.Truncate(valor / 100) % 10;
            d = Math.Truncate(valor / 10) % 10;
            u = Math.Truncate(valor / 1) % 10;

            if (m < 0)
            {
                Console.WriteLine("Fuera de rago");
            }
            else
            {
                switch (m)
                {
                    case 1:
                        Console.Write("M");
                        break;

                    case 2:
                        Console.Write("MM");
                        break;

                    case 3:
                        Console.Write("MMM");
                        break;


                }
                switch (c)
                {
                    case 1:
                        Console.Write("C");
                        break;

                    case 2:
                        Console.Write("CC");
                        break;

                    case 3:
                        Console.Write("CCC");
                        break;
                    case 4:
                        Console.Write("CD");
                        break;
                    case 5:
                        Console.Write("D");
                        break;
                    case 6:
                        Console.Write("DC");
                        break;
                    case 7:
                        Console.Write("DCC");
                        break;
                    case 8:
                        Console.Write("DCCC");
                        break;
                    case 9:
                        Console.Write("CM");
                        break;


                }
                switch (d)
                {
                    case 1:
                        Console.Write("X");
                        break;
                    case 2:
                        Console.Write("XX");
                        break;
                    case 3:
                        Console.Write("XXX");
                        break;
                    case 4:
                        Console.Write("XL");
                        break;
                    case 5:
                        Console.Write("L");
                        break;
                    case 6:
                        Console.Write("LX");
                        break;
                    case 7:
                        Console.Write("LXX");
                        break;
                    case 8:
                        Console.Write("LXXX");
                        break;
                    case 9:
                        Console.Write("XC");
                        break;

                }
                switch (u)
                {
                    case 1:
                        Console.Write("I");
                        break;
                    case 2:
                        Console.Write("II");
                        break;
                    case 3:
                        Console.Write("III");
                        break;
                    case 4:
                        Console.Write("IV");
                        break;
                    case 5:
                        Console.Write("V");
                        break;
                    case 6:
                        Console.Write("VI");
                        break;
                    case 7:
                        Console.Write("VII");
                        break;
                    case 8:
                        Console.Write("VIII");
                        break;
                    case 9:
                        Console.Write("IX");
                        break;
                }

            }
        }
    }

}
