using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestCoderland.Core.Entities
{
    [Table("marcas_de_autos")]
    public class MarcaAuto
    {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PaisOrigen { get; set; }
    }
}
