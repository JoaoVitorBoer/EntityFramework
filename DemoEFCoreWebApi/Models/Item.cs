namespace DemoEFCoreWebApi.Models;

public class Item
{
    public int Quantidade {get;set;}
    public int ProdutoId {get;set;}
    public Produto Produto {get;set;} = null!;

    public int PedidoId {get;set;}
    public Pedido Pedido {get;set;} = null!;
}