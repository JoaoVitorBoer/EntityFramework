namespace DemoEFCoreWebApi.Models;

public class Pedido
{
    public int Id{get;set;}
    public DateTime DataEmissao {get;set;}
    public int ClienteId {get;set;}
    public Cliente Cliente {get;set;} = null!;
    //relacionamento 1:N com Pedido
    public List<Item> Itens {get;set;} = null!;
    public ICollection<Produto> Produtos {get;set;} = null!;
}