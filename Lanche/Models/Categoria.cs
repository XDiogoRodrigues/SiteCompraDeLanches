using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanche.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage ="O tamanho máximo é 100 caracteres")] //Declara que meu atributo vai ter no maximo 100 caracteres, passou exibe a msg de error
        [Required(ErrorMessage ="Informe o nome da categoria")] // Required declara que o campo é obrigatorio
        [Display(Name="Nome")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")] //Declara que meu atributo vai ter no maximo 200 caracteres, passou exibe a msg de error
        [Required(ErrorMessage = "Informe a descrição nome da categoria")] // Required declara que o campo é obrigatorio
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanches> Lanches { get; set; }

    }
}
