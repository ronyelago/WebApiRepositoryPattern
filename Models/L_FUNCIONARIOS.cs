namespace ProductCatalog.Models
{
    public class L_FUNCIONARIOS
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Funcao { get; set; }
        public int? Fk_Funcao { get; set; }
        public string Matricula { get; set; }
        public byte[] Senha { get; set; }
        public string Tipo_Sanguineo { get; set; }
        public string Status { get; set; }
        public int Fk_Cliente { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
