using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_6 {

    class Motor {
        public int Cilindros;
        public double Capacidade;

        public Motor(int cil, double cc) {
            this.Cilindros = cil;
            this.Capacidade = cc;

        }
    }

    class Carro {
        public string cor;
        public Motor motor;

        public Carro(string cor, Motor motor) {
            this.cor = cor;
            this.motor = motor;
        }
    }


    class Program {
        static void Main(string[] args) {

            Motor m1 = new Motor(4, 1.0);
            Motor m2 = new Motor(4, 1.6);
            Motor m3 = new Motor(4, 1.8);

            Carro c1 = new Carro("Preto", m1);
            Carro c2 = new Carro("Prata", m2);

            c2.motor = m3;
            c1.motor.Capacidade = 1.2;

        }
    }
}
