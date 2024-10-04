using CleanArchWithCQRS.Application.Contracts.Persistance.Common;
using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using CleanArchWithCQRS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Contracts.Persistance
{
    public interface IStudentRepository:IBaseRepository<Student>
    {
        Task ChangeStatus(Student entity);
    }
}
