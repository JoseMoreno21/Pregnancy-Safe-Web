using Pregnancy_Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pregnancy_Safe.Domain.Services
{
    public interface IMotherService
    {
        Task<IEnumerable<Mother>> ListAsync();
        //Task<MotherResponse> SaveAsync(Mother mother);
        //Task<MotherResponse> UpdateAsync(int id, Mother mother);
        //Task<MotherResponse> DeleteAsync(int id);
    }
}
