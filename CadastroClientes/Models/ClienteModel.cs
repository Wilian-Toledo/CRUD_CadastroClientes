using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataExp { get; set; }
        public string OrgExp { get; set; }
        public string UfExp { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Nascimento { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string EstCivil { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string UF { get; set; }

    }
}
