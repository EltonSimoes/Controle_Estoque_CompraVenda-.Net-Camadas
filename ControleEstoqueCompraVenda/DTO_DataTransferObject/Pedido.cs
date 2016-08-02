using System;

namespace DTO_DataTransferObject
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public DateTime DataHora { get; set; }
        public Operacao Operacao { get; set; }
        public Situacao Situacao { get; set; }
        public Pessoa Emitente { get; set; }
        public Pessoa Destinatario { get; set; }
    }
}
