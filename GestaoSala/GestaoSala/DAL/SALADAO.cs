using Dapper;
using GestaoSala.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoSala.DAL
{
    public class SALADAO
    {
        SqlConnection _conexao; 
        public SALADAO()
        {
            _conexao = ConexaoBD.getConexao(); 
        }
        public List<SALA> getTodasAsSalas()
        { string query = "select* from sala";
            _conexao.Open();

            var lista = (List<SALA>) _conexao.Query(query);

            return lista; 
        }  
    }
}
