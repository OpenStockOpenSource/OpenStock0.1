using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class UsuarioLoginViewModel
    {
        [Required(ErrorMessage = "Informe o login do usuário")]
        [Display(Name = "Login do usuário:")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a senha do usuário")]
        [Display(Name = "Senha do usuário:")]
        public string Senha { get; set; }

    }
}