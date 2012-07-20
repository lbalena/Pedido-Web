using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Ingrediente
    {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; }
        }
        private string ingrediente;
        public string Ingrediente
        {
            get
            { return ingrediente; }
            set
            { ingrediente = value; }
        }
        public Ingrediente()
        {
            this.Id = 0;
            this.Ingrediente = null;
        }
    }
}
