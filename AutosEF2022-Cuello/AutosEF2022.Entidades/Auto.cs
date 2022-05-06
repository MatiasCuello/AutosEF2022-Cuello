using AutosEF2022.Entidades;

namespace AutosEF2022.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Autos")]
    public partial class Auto
    {
        public int AutoId { get; set; }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoDeAuto { get; set; }

        public decimal Precio { get; set; }

        [Required]
        [StringLength(50)]
        public string PaisDeOrigen { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
