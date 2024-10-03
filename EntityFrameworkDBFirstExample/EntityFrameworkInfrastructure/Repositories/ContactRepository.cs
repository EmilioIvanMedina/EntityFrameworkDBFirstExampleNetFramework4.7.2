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
            var contacts = _context.contact.Select(x => x).ToList();
                        
            var contactDTOs = new List<ContactDTO>();

            foreach (var contact in contacts)
            {
                var dto = new ContactDTO
                {
                    IdContact = contact.id_contact,
                    IdContactType = contact.id_contact_type ?? 0,
                    Contact = contact.contact1,
                    ContactName = contact.contact_name
                };
                contactDTOs.Add(dto);
            }

            return contactDTOs;
        }
    }
}
