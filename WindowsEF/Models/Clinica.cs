﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public int ClinicaId { get; set; }

        [Required] 
        [Column(TypeName = "varchar")] 
        [MaxLength(50)] 
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicioActividades { get; set; }

        public List<Habitacion> Habitaciones { get; set; }
    }
}
