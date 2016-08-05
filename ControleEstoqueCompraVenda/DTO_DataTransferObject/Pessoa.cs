
namespace DTO_DataTransferObject
{
    public class Pessoa
    {
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
    }
}
