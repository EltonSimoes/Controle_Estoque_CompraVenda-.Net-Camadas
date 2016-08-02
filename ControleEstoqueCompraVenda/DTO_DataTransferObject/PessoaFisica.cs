using System;

namespace DTO_DataTransferObject
{
    public class PessoaFisica
    {
        public Pessoa Pessoa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
