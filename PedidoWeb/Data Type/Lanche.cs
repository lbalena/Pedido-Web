using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Lanche
    {
        private int id;
        private string nome;
        private List<Ingrediente> ingredientes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Ingrediente> Ingredientes
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }

        public Lanche(string nome)
        {
            if (id == 0)
            {
                this.Id = 1;
            }
            else
            {
                this.Id = id++;
            }
            this.Nome = nome;
            this.Ingredientes = new List<Ingrediente>();
        }

        public void AddIngrediente(string ingrediente)
        {
            Ingrediente i = new Ingrediente();
            i.Ing = ingrediente;
            this.Ingredientes.Add(i);
        }
    }
}
