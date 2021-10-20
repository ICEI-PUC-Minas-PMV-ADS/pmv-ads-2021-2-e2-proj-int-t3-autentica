using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace autentica.Models
{
    [Table("clientes")] 
    public class cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF_CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public int  Telefone { get; set; }
    }
}
