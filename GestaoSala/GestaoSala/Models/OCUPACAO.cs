using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoSala.Models
{
    public class OCUPACAO
    {
        public int OCUID { get; set; }

        public string SALID { get; set; }
        public DateTime OCUDATA { get; set; }
        public DateTime OCUHORARIOINICIO { get; set; }
        public DateTime OCUHORAFIM { get; set; }

    }
}
