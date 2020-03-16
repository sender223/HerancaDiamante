//SEGUNDA CLASSE CRIADA -- MODIFICADA
using System;

namespace HerancaDiamante.Dispositivos {
    //herda da classe Dispositivo e Implementa da Classe IScanner
    class Scanner : Dispositivo, IScanner {

        //sobreescreve o metodo ProcessandoDoc -- SubClasse Dispositivo.
        public override void ProcessandoDoc(string documento) {
            Console.WriteLine("Processando Scanner: " + documento) ;
        }
        //metodo scan que vai retornar A frase abaixo -- Implementacao da Interface IScanner
        public string Scan() {
            return "Resultado Scanner Scan";
        }
    }
}
