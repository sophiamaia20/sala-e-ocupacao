using Dapper;
using GestaoSala.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoSala.DAL
{
    public class OCUPACAODAO
    {
        SqlConnection _conexao;
        public OCUPACAODAO()
        {
            _conexao = ConexaoBD.getConexao();
        }
        public List<OCUPACAO> getTodasAsOcupacoes()
        {
            string query = "select* from ocupacao";
            _conexao.Open();

            var lista = (List<OCUPACAO>)_conexao.Query(query);

            return lista;
        }
    }
}