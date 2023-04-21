using MessagePack;
using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class equipos
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id_equipos { get; set; }
        public String? nombre { get; set; }
        public String? descripcion { get; set; }


    }
}
