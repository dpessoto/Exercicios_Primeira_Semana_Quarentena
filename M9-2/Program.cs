using System;


namespace M9_2 {

    public class Classe1 {
        double a1, a2, a3;

        public Classe1(double p) : this(p,p) {
            Console.WriteLine("construtor com 1 parametro: ");
        }

        public Classe1(double p12, double p3) : this(p12, p12, p3) {
            Console.WriteLine("construtor com 2 parametros");
        }

        public Classe1(double p1, double p2, double p3)  {
            Console.WriteLine("construtor com 3 parametros: ");
        }

    }

    class Program {
        static void Main(string[] args) {

            Classe1 c1 = new Classe1(1, 1);
        }
    }
}
