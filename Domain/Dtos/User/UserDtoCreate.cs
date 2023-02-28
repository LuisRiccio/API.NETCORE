using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Name é campo obrigatório para Login")]
        [StringLength(60, ErrorMessage = "Name deve ter no máximo {1} carateres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} carateres.")]
        public string Email { get; set; }


    }
}
