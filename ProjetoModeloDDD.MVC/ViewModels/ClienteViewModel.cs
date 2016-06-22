using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Preencha o Nome")]
        [MaxLength(150,ErrorMessage ="Máximo {0} de caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo {0} de caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} de caracteres")]
        [EmailAddress(ErrorMessage ="Preencha E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}