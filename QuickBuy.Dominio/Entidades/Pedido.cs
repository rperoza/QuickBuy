using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
