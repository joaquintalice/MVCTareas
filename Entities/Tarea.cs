using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace TareasMVC.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public List<Paso> Pasos { get; set; }
        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
