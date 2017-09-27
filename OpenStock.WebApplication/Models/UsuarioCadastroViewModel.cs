using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class UsuarioCadastroViewModel
    {
        [Required(ErrorMessage = "Informe o nome do usuário")]
        [Display(Name = "Nome do usuário:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o login do usuário")]
        [Display(Name = "Login do usuário:")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a senha do usuário")]
        [Display(Name = "Senha do usuário:")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirme a senha do usuário")]
        [Display(Name = "Confirme a senha:")]
        public string SenhaConfirm { get; set; }

        public DateTime DataCadastro { get; set; }


    }
}