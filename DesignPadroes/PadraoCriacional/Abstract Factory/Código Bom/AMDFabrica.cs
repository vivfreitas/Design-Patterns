namespace DesignPadroes.PadraoCriacional.Abstract_Factory.Código_Bom;

// Agora quando vc chama uma fábrica de AMD, ela só vai entregar AMD.
public class AmdFabrica : IHardwareFactory
{
    public IProcessador CriarProcessador() => new AmdProcessador();

    public IPlacaMae CriarPlacaMae() => throw new NotImplementedException();
}

/*
 * NO FINAL TEREMOS ESSA ESTRUTURA SEMPRE:
 
   Estrutura real:
   IProcessador → tipo genérico
   IPlacaMae → tipo genérico
   IHardwareFactory → contrato da fábrica
   
   E depois:
   
   AMDProcessador → implementação
   AMDPlacaMae → implementação
   AMDFactory → junta tudo
 */