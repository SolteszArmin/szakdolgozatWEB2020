using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdoga.Models
{
    public class Sportag
    {
        [Key,Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Sportág")]
        [Column(Order = 1)]
        public string SportagNev { get; set; }
    }
}