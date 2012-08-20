using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Bebida
    {

        private int id;
        private string nome;
        private float valor;

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Bebida(string nome, float valor)
        {
            this.Nome = nome;
            this.Valor = Valor;
        }
    }
}
