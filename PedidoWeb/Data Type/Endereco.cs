using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoWeb.Data_Type
{
    class Endereco
    {
        #region atributos
        private string logradouro;
        private string end;
        private string num;
        private string referencia;
        private string cep;
        #endregion

        #region acessadores/modificadores
        public string Logradouro
        {
            get { return logradouro; }
            set { this.logradouro = value; }
        }

        public string End
        {
            get { return end; }
            set { this.end = value; }
        }

        public string Num
        {
            get { return num; }
            set { this.num = value; }
        }

        public string Referencia
        {
            get { return referencia; }
            set { this.referencia = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { this.cep = value; }
        }
        #endregion

        #region construtores
        public Endereco() {
        }
        #endregion
    }
}
