using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vizew.WebUI.Models.Entity
{
    public class Contact:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}