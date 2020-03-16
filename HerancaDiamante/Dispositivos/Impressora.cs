//TERCEIRA CLASSE CRIADA -- MODIFICADA
using System;

namespace HerancaDiamante.Dispositivos {
    //herda da classe dispositivo, vai ser uma subclasse da Dispositivo
    //e agora ela vai implementar a interface IImpressora
    class Impressora : Dispositivo, IImpressora {
        
        //sobreescreve o metodo ProcessandoDoc -- SubClasse Dispositivo.
        public override void ProcessandoDoc(string documento) {
            Console.WriteLine("Processando Impressão: " + documento);
        }
        //sobreescreve o metodo Print -- implementação do metodo IImpressora
        public void Impressao(string documento) {
            Console.WriteLine("Impressora imprimindo " + documento);
        }
    }
}
