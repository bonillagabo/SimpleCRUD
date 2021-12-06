using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class NuevoClienteVM
    {   
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Nombre { set; get; }
        
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Apellido { set; get; }
        
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int Dni { set; get; }
        
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Celular { set; get; }
        
        public string Domicilio { set; get; }
        
        public string Email { set; get; }
    }
}
