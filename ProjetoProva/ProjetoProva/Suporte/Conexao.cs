using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProva.Suporte
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            banco = new SqlConnection(ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
        }
    }
}
