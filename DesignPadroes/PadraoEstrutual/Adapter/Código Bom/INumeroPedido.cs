namespace DesignPadroes.PadraoEstrutual.Adapter;

// Nova interface do sistema externo só recebe int.
public interface INumeroPedido
{
    void Receber(int numeroDoPedido);
}