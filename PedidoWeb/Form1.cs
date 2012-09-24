using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PedidoWeb.Data_Type;
using System.Data.SqlClient;

namespace PedidoWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            Endereco endereco = GetEndereco();
            //Conexão ao BD
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PedidoWeb;Integrated Security=True;Pooling=False;";
            string query = "INSERT INTO Endereco (logradouro, endereco, numero, cep, referencia) values (@logradouro, @endereco, @numero, @cep, @referencia)";

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("logradouro", endereco.Logradouro));
                cmd.Parameters.Add(new SqlParameter("endereco", endereco.End));
                cmd.Parameters.Add(new SqlParameter("numero", endereco.Num));
                cmd.Parameters.Add(new SqlParameter("cep", endereco.Cep));
                cmd.Parameters.Add(new SqlParameter("referencia", endereco.Referencia));
                cmd.ExecuteNonQuery();
                conn.Close();
                tBTeste.AppendText("Cadastrado com sucesso, consulte o BD");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn == null) { }
                else
                {
                    conn.Close();
                }
            }
        }

        private Endereco GetEndereco()
        {
            Endereco end = new Endereco();
            end.Logradouro = "Rua";
            end.End = "Vicente Machado";
            end.Num = "2151";
            end.Cep = "85010-260";
            end.Referencia = "Simão Pneus";
            return end;
        }
    }
}
