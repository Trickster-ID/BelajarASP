using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace newASP.Models
{
    [Table("TB_M_Supplier")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name id is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address id is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression("[a-zA-Z0-9._]+@gmail+.com", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public Supplier()
        {

        }
    }
}