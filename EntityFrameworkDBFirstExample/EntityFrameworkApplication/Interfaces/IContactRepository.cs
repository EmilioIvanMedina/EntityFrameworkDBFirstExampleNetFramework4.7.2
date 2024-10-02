using EntityFrameworkApplication.DTOs;
using System.Collections.Generic;

namespace EntityFrameworkApplication.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<ContactDTO> GetAll();
    }
}
