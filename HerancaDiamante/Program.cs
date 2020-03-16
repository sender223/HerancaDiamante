using System;
using HerancaDiamante.Dispositivos;

namespace HerancaDiamante {
    class Program {
        static void Main(string[] args) {
            //instanciando a classe Impressora
            Impressora i = new Impressora() { NumeroSerial = 1080 };
            i.ProcessandoDoc("Minha Carta");
            i.Impressao("Minha Carta");
            //instanciando a classe Scanner
            Scanner s = new Scanner() { NumeroSerial = 2003 };
            s.ProcessandoDoc("Meu Email");
            Console.WriteLine(s.Scan());            
        }
    }
}
