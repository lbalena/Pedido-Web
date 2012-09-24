using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Cliente
    {
        private string nome;
        private string tel;
        private Endereco end;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { this.tel = value; }
        }

        public Endereco End
        {
            get { return end; }
            set { this.end = value; }
        }

        public Cliente(string nome, string tel, Endereco end)
        {
            Nome = nome;
            Tel = tel;
            End = end;
        }
    }
}
