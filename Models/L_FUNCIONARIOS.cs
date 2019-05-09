namespace ProductCatalog.Models
{
    public class L_FUNCIONARIOS
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string CPF { get; set; }
        public string FUNCAO { get; set; }
        public int? FK_FUNCAO { get; set; }
        public string MATRICULA { get; set; }
        public byte[] SENHA { get; set; }
        public string TIPO_SANGUINEO { get; set; }
        public string STATUS { get; set; }
        public int FK_CLIENTE { get; set; }
        public string CNPJ { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }
    }
}
