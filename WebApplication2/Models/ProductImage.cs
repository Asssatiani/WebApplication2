using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        [Display(Name ="File")]
        public string FileName { get; set; }
    }
}