namespace DesignPadroes.PadraoComportamental.Strategy;

public class MercadoLivre : ICupom
{
    public int Desconto(int valor)
    {
        const int descontoPor = (10 * 100) / 100;
        return valor - descontoPor;
    }
}