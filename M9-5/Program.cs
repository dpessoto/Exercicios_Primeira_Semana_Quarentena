using System;

namespace M9_5 {

    public class Classe1 {

        private string nome;
        private float total = 0;

        public void setNome(string nome) {
            this.nome = nome;
        }
        public string getNome() {
            return this.nome;
        }

        public float getTotal() {
            return this.total;
        }

        public void incrementa(float valor) {
            this.total += valor;
        }
    }

    class Program {
        static void Main(string[] args) {

            Classe1 c1 = new Classe1();
            c1.setNome("Galileu");
            c1.incrementa(100);
            Console.WriteLine("{0} {1}\n", c1.getNome(), c1.getTotal());

        }
    }
}
