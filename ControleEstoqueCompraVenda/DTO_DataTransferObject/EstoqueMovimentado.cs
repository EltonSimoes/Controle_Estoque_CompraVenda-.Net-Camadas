using System;

namespace DTO_DataTransferObject
{
    public class EstoqueMovimentado
    {
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public string EntrouSaiu { get; set; }
    }
}
