using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SimpleCRUD.DAL
{
    [Index(nameof(Dni), IsUnique = true)]
    public partial class Cliente
    {
        [Key]
        public long NroSocio { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Apellido { get; set; }
        public long Dni { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Celular { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Domicilio { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }       
    }
}
