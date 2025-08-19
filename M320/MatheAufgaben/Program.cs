namespace MatheAufgaben
{
    public class MyMath 
    { 
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            do
            {
                z = a % b;
                a = b;
                b = z;
            }
            while (b != 0);

            return a;
        }

        public static int Calc_ggT_r(int a, int b) 
        {
            if (b == 0) 
            {
                return a;
            }
            else 
            {
             return MyMath.Calc_ggT(a, b%a);
            }
        }

        public static int Calc_kgv(int x, int y) 
        {
            return (x * y) / Calc_ggT(x, y);
        }

        public static double Mittelwert() 
        {
           double Total = 0;
           double Result = 0;

            int[] ZahlenArray = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Gib mir die {i+1}. Zahl");
                ZahlenArray[i] = int.Parse(Console.ReadLine());
                Total = Total + ZahlenArray[i];
            }

            Result = Total/ZahlenArray.Length;
            
            return Result;
        }

        public static int kleinsterWert() 
        {
            int klein = 1000000;

            int[] ZahlenArray = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Gib mir die {i + 1}. Zahl");
                ZahlenArray[i] = int.Parse(Console.ReadLine());
                if(ZahlenArray[i] < klein) 
                { 
                    klein = ZahlenArray[i];
                }
            }

            return klein;
        }

        public static int groessterWert()
        {
            int gross = 0;

            int[] ZahlenArray = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Gib mir die {i + 1}. Zahl");
                ZahlenArray[i] = int.Parse(Console.ReadLine());
                if (ZahlenArray[i] > gross)
                {
                    gross = ZahlenArray[i];
                }
            }

            return gross;
        }
        public static void Swap(int a, int b) 
        {
            int c = 0;
            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int Antwort = 1;
            String StringAntwort;
            while (Antwort != 0) 
            {
                Console.WriteLine("------------------Menu------------------");
                Console.WriteLine("ggT: 1");
                Console.WriteLine("ggT_r: 2");
                Console.WriteLine("Kgv: 3");
                Console.WriteLine("Mittelwert: 4");
                Console.WriteLine("Kleinster: 5");
                Console.WriteLine("Groesster: 6");
                Console.WriteLine("Swap: 7");



                Console.WriteLine("Drücke 0 um zu verlassen");

                StringAntwort = Console.ReadLine();
                Antwort = int.Parse(StringAntwort);

                if (Antwort == 1)
                {
                    Console.WriteLine("ggT Wird berechnet...");
                    Console.WriteLine("Gib mir den ersten Wert");
                    String StringWert1 = Console.ReadLine();
                    int IntWert1 = int.Parse(StringWert1);
                    Console.WriteLine("Gib mir den zweiten Wert");
                    String StringWert2 = Console.ReadLine();
                    int IntWert2 = int.Parse(StringWert2);

                    int Result = MyMath.Calc_ggT(IntWert1, IntWert2);
                    Console.WriteLine($"\n{Result}");

                }
                else if (Antwort == 2) 
                {
                    Console.WriteLine("ggT rekursiv Wird berechnet...");
                    Console.WriteLine("Gib mir den ersten Wert");
                    int IntWert1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gib mir den zweiten Wert");
                    int IntWert2 = int.Parse(Console.ReadLine());
                    int Result = MyMath.Calc_ggT_r(IntWert1,IntWert2);
                    Console.WriteLine($"\n{Result}");

                }
                else if (Antwort == 3)
                {
                    Console.WriteLine("Kgv Wird berechnet...");
                    Console.WriteLine("Gib mir den ersten Wert");
                    int IntWert1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gib mir den zweiten Wert");
                    int IntWert2 = int.Parse(Console.ReadLine());

                    int Result = MyMath.Calc_kgv(IntWert1, IntWert2);
                    Console.WriteLine($"\n{Result}");


                }
                else if (Antwort == 4) 
                {
                    Console.WriteLine("Mittelwert eines Arrays Wird berechnet...");
                    double Result = MyMath.Mittelwert();
                    Console.WriteLine($"\n{Result}");
                }
                else if (Antwort == 5) 
                {
                    Console.WriteLine("Kleinste Zahl eines Arrays Wird berechnet...");
                    int Result = MyMath.kleinsterWert();
                    Console.WriteLine($"\n{Result}");

                }
                else if (Antwort == 6) 
                {
                    Console.WriteLine("Groesste Zahl eines Arrays Wird berechnet...");
                    int Result = MyMath.groessterWert();
                    Console.WriteLine($"\n{Result}");

                }
                else if (Antwort == 7) 
                {
                    int a = 0;
                    int b = 0;

                    Console.WriteLine("Swap wird ausgeführt...");
                    Console.WriteLine("Gib mir die Zahl A");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gib mir die Zahl B");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    MyMath.Swap(a, b);
                }
            }
            
        }
    }
}
