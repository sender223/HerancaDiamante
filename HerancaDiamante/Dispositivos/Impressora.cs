//TERÇA CLASSE CRIADA
using System;

namespace HerancaDiamante.Dispositivos {
    //herda da classe dispositivo
    class Impressora : Dispositivo {
        
        //sobreescreve o metodo ProcessandoDoc
        public override void ProcessandoDoc(string documento) {
            Console.WriteLine("Processando Impressão: " + documento);
        }
        //sobreescreve o metodo Print
        public void Impressao(string documento) {
            Console.WriteLine("Impressora imprimindo " + documento);
        }
    }
}
