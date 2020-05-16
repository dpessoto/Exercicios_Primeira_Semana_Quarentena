using System;

namespace M9_7 {

    class Classe1 : Classe2 {

        public Classe1() {
            Console.WriteLine("Lugar1");
        }

    }

    class Classe2{

        public Classe2() {
            Console.WriteLine("Lugar2");
        }

    }

    class Program {
        static void Main(string[] args) {

            Classe1 c1 = new Classe1();
            Classe2 c2 = new Classe2();
        }
    }
}
