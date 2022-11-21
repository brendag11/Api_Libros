using ApiLibros.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ApiLibros.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "El campo {0} solo puede tener hasta 250 caracteres")]
        [PrimeraLetraMayuscula]

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public List<Seccions> Seccions { get; set; }
        public List<LibroCategoria> LibroCategoria { get; set; }

    }
}
