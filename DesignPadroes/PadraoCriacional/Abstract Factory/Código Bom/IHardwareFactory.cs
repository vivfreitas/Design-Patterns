namespace DesignPadroes.PadraoCriacional.Abstract_Factory.Código_Bom;

// Uma placa mãe precisa de dois produtos relacionados: Processador e Modelo.
// Aqui está a nossa fábrica.
public interface IHardwareFactory
{
    IProcessador CriarProcessador();
    IPlacaMae CriarPlacaMae();
}

// SEM O FACTORY VC PRECISARIA USAR OS DOIS SEPARADAMENTE ASSIM:
// var cpu = new AMDProcessador();
// var placa = new IntelPlacaMae();