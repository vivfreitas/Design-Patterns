namespace DesignPadroes.PadraoCriacional.Abstract_Factory.CódigoRuim;

public class CheckoutService
{
    // Aqui iremos criar um método de exemplo para demonstrar o acoplamento ruim.
    public void FinalizarCompra(string metodoDePagamento)
    {
        if (metodoDePagamento == "PIX")
        {
            PixQrCodeGerador gerador = new PixQrCodeGerador();
            PixChaveValidador validador = new PixChaveValidador();
            validador.Validar("123456");
            gerador.Gerar();
        }
        else if (metodoDePagamento == "CARTAO")
        {
            CartaoProcessador processador = new CartaoProcessador();
            CartaoCvvValidador validadorCvv = new CartaoCvvValidador();
            
            validadorCvv.Validar("123");
            processador.Processar();
        }
    }
    // 1. Perceba que criamos classes concretas, mesmo que estejam na mesma familia de objetos.
    // 2. Se caso um dia a sua classe mudar, você terá ue mexer nesse código também.
    // 3. Grande volume de acoplamento.
}

public class CartaoCvvValidador
{
    public void Validar(string chave){}

}

public class CartaoProcessador
{
    public void Processar(){}

}

public class PixChaveValidador
{
    public void Validar(string chave){}
}

public class PixQrCodeGerador
{
    public void Gerar(){}
}