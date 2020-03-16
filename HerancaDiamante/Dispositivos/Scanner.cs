//SEGUNDA CLASSE CRIADA
using System;

namespace HerancaDiamante.Dispositivos {
    //herda da classe dispositivo
    class Scanner : Dispositivo {

        //sobreescreve o metodo ProcessandoDoc
        public override void ProcessandoDoc(string documento) {
            Console.WriteLine("Processando Scanner: " + documento) ;
        }
        //metodo scan que vai retornar A frase abaixo
        public string Scan() {
            return "Resultado Scanner Scan";
        }
    }
}
