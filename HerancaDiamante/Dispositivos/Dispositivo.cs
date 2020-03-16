//PRIMEIRA CLASSE CRIADA
namespace HerancaDiamante.Dispositivos {
    //CLASSE ABSTRATA DISPOSITIVO
    abstract class Dispositivo {
        
        public int NumeroSerial { get; set; }

        public abstract void ProcessandoDoc(string documento);

    }
}
