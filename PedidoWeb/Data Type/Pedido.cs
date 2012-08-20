using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Pedido
    {
        private List<Bebida> bebidas;
        private List<Lanche> lanches;
        private List<Produto> consumo;

        public List<Bebida> Bebidas
        {
            get { return bebidas; }
            set { bebidas = value; }
        }

        public List<Lanche> Lanches
        {
            get { return lanches; }
            set { lanches = value; }
        }

        public List<Produto> Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        public Pedido()
        {
            Bebidas = new List<Bebida>();
            Lanches = new List<Lanche>();
            Consumo = new List<Produto>();
        }
    }
}
