using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }
       
        public string Name { get; set; }
      
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
      
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]       
        public decimal Price { get; set; }
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public SelectList CategoryList { get; set; }
        public List<SelectList> ImageLists { get; set; }
        public string[] ProductImages { get; set; }
    }
}