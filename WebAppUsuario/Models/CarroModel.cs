using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppUsuario.Models
{
    [Table("Carros")]
    public class CarroModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]

        public string Marca { get; set; }
        [MaxLength(80)]

        public string Modelo { get; set; }

        public DateTime DataFabricacao { get; set; }
    }
}
