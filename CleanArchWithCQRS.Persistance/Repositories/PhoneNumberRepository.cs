using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Persistance.Repositories
{
    public class PhoneNumberRepository : BaseRepository<PhoneNumber>, IPhoneNumberRepository
    {
        private readonly ProjectDbContext _projectDbContext;

        public PhoneNumberRepository(ProjectDbContext projectDbContext) : base(projectDbContext)
        {

            _projectDbContext = projectDbContext;
        }

        public  Task<IReadOnlyList<PhoneNumber>> GetAllStudentPhoneNumber(Guid studentId)
        {
            var phoneNumbers = _projectDbContext.PhoneNumbers.Where(x => x.StudentId == studentId).ToList();
            return Task.FromResult<IReadOnlyList<PhoneNumber>>(phoneNumbers);
           
        }
    }
}
