﻿using System;
using System.Collections.Generic;

namespace DemoScaffold.Models
{
    public partial class PedidosProduto
    {
        public decimal NumPedido { get; set; }
        public decimal CodProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public virtual Produto CodProdutoNavigation { get; set; } = null!;
        public virtual Pedido NumPedidoNavigation { get; set; } = null!;
    }
}
