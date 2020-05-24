using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrácticaSemanal2.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        [Display(Name = "Número de teléfono")]
        public string Orden { get; set; }
        public string Cliente { get; set; }
        public string Notas { get; set; }
        public int MenuID { get; set; }
        [ForeignKey("MenuID")]
        public Menu Menu { get; set; }
    }
}