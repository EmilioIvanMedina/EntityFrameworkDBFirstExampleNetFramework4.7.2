using EntityFrameworkApplication.DTOs;
using EntityFrameworkApplication.Interfaces;
using EntityFrameworkInfrastructure.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace EntityFrameworkInfrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly websitedatabase _context;
        public ContactRepository(websitedatabase context)
        {
            _context = context;
        }
        public IEnumerable<ContactDTO> GetAll()
        {
            try
            {
                var contacts = _context.contact.Select(x => x).ToList();
            }
            catch (Exception e)
            { 
                throw new Exception("cannot get contact data from database", e);
            }
            
            return Enumerable.Empty<ContactDTO>();
        }
    }
}
