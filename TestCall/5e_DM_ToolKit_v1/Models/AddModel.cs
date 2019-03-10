using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class AddModel
    {
        [Required(ErrorMessage = " Name")]
        [DisplayName(" Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }

       // [Required(ErrorMessage = " Initiative")]
        [DisplayName(" Initiative")]
        [Range(1, 30)]
       // ErrorMessage = "Value for {0} must be between {0} and {2}.")]
        public int Init { get; set; }



    }
}