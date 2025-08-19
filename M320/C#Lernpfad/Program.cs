using System.Collections;

namespace C_Lernpfad
{
    public class Auto 
    {
        public string Farbe = "";
        public int Geschw = 0;
        public Auto(string farbe, int geschw)
        {
            Farbe = farbe;
            Geschw = geschw;
        }

        public void Schnell() 
        {
            Geschw += 50;
            Console.WriteLine(Geschw);
        }

        public void FarbeAuto() 
        {
            Console.WriteLine(Farbe);
        }

        public static void LieblingsAuto() 
        {
            Console.WriteLine("Mercedes");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto Auto1 = new Auto("Rot", 50);
            Auto Auto2 = new Auto("Blau", 30);

            Auto1.Schnell();
            Auto2.FarbeAuto(); 
            //Vom Objekt ansprechbar, weil Data je nach Objekt des Blueprints/Class variiert.
            Auto.LieblingsAuto();
            //Von der Klasse ansprechbar, weil Data immer diesselbe.
            
        }
    }
}
