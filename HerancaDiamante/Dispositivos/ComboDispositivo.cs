//QUARTA CLASSE CRIADA
using System;

namespace HerancaDiamante.Dispositivos {
    class ComboDispositivo : Dispositivo, IScanner, IImpressora {

        //implementando o metodo da interface Impressao
        public void Impressao(string documento) {
            Console.WriteLine("ComboDispositivo Processando " + documento);
        }
        //implementando a classe abstrata do Dispositivo, 
        public override void ProcessandoDoc(string documento) {
            Console.WriteLine("ComboDispositivo print " + documento);
        }        
        //implementando o metodo da interface Scan
        public string Scan() {
            return "ComboDispositivo Resultado Scan";
        }
    }
}

