using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pregnancy_Safe.Domain.Models
{
    public class Mother
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        //public int PregnancyStageId { get; set; }
        //public PregnancyStage PregnancyStage { get; set; }
    }
}
