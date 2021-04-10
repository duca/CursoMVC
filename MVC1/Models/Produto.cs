using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    using System.Linq;  
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1,20, ErrorMessage ="Valor inválido")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
