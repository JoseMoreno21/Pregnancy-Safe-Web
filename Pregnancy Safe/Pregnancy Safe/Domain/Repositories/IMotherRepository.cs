using Pregnancy_Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pregnancy_Safe.Domain.Repositories
{
    public interface IMotherRepository
    {
        Task<IEnumerable<Mother>> ListAsync();
        Task<Mother> FindByIdAsync(int id);
        Task AddASync(Mother mother);
        void Update(Mother mother);
        void Remove(Mother mother);
    }
}
