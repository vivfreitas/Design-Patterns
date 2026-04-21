namespace DesignPadroes.PadraoEstrutual.Adapter.Código_Bom;

public class PedidosAdapter : INumeroPedido
{
    private readonly SistemaLegado _legado;

    public PedidosAdapter(SistemaLegado legado)
    {
        _legado = legado;
    }

    public void Receber(int numeroDoPedido)
    {
        string numero = numeroDoPedido.ToString();
        _legado.NumeroPedido(numero);
    }
}