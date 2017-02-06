using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValidandoComDataAnotations
{
    public class Aluno
    {
        //ID
        [Display(Name = "Código", Description = "Inform um inteiro entre 1 e 99999.")]
        [Range(1, 99999)]
        public int Id { get; set; }

        //NOME
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z'-'\s]{1,40}$", ErrorMessage = "Numeros e caracteres especiais não permitidos no nome.")]
        public string Nome { get; set; }

        //EMAIL
        [Required(ErrorMessage = "O Email é obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O email deve ter no minimo 5 caracteres e no maximo 100.")]
        public string Email { get; set; }

        //IDADE
        [Display(Name = "Idade", Description = "A idade deve estar entre 15 e 24 anos.")]
        [Range(15, 24)]
        public int Idade { get; set; }
    }
}
