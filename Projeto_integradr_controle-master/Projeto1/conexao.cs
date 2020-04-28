using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Projeto1
{
   public class conexao
    {
        sqlConnection con = new sqlConnection();

        //contrutor 
        public conexao()
        {
            con.ConnectionString == "";
        
        }
        //metodo conectar
        public SqlConnection conecta()
        {
            return;
        }
        //metodo desconectar
        public void desconectar()
        { 
        
        }


    }
}
