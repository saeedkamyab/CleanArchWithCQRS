using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Persistance.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly ProjectDbContext _projectDbContext;
        public StudentRepository(ProjectDbContext projectDbContext) : base(projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public async Task ChangeStatus(Student entity)
        {

            _projectDbContext.Entry(entity).State = EntityState.Modified;
            await _projectDbContext.SaveChangesAsync();

        }
    }
}
