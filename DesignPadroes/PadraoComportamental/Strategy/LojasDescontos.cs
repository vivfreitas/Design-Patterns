namespace DesignPadroes.PadraoComportamental.Strategy;

public class LojasDescontos
{
    public ICupom Cupom;

    public int Descontar(int valor)
    { 
        return Cupom.Desconto(valor);
    }
}