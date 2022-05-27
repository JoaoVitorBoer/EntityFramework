namespace DemoEFCoreWebApi.Services;

public class ProdutoNaoEncotradoException : Exception
{
    public ProdutoNaoEncotradoException(int id) : base ( $"Produto id={id} não encontrado")
    {
    }
} 