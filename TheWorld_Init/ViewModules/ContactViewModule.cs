using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld_Init.ViewModules
{
    public class ContactViewModule
    {
        [Required]
        public string Name{ get; set; }
        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        [Required]
        [StringLength(4096,MinimumLength = 30)]
        public string Message{ get; set; }
    }
}
