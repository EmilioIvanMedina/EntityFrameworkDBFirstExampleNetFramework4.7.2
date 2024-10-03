using EntityFrameworkApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkWebSiteApplication.ViewModels
{
    public class ContactViewModel
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public IEnumerable<ContactDTO> Contacts { get; set; }
    }
}