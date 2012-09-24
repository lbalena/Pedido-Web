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
        private string ing;
        public string Ing
        {
            get
            { return ing; }
            set
            { ing = value; }
        }
        public Ingrediente()
        {
            this.Id = 0;
            this.Ing = null;
        }
    }
}
