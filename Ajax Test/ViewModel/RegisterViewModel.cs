using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ajax_Test.ViewModel
{
    public class RegisterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IList<SelectListItem> Country { get; set; }
        public IList<SelectListItem> State { get; set; }
        public IList<SelectListItem> City { get; set; }

    }
}
