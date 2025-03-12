using System.ComponentModel.DataAnnotations;    

namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El campo Telefono es requerido")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El campo Correo es requerido")]
        public string? Correo { get; set; }
    }
}
