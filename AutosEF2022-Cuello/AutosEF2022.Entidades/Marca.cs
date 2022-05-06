using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutosEF2022.Context;

namespace AutosEF2022.Entidades
{
    public partial class Marca
    {
        public Marca()
        {
            Autos = new HashSet<Auto>();
        }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
