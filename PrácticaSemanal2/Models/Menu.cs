using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrácticaSemanal2.Models
{
    public class Menu
    {
        public int ID { get; set; }
        [Display(Name = "Nombre producto")]
        public string Producto { get; set; }
        public float Precio { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Disponibilidad { get; set; }
    }
}