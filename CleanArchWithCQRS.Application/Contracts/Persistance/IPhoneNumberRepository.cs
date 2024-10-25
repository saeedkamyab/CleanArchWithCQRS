using CleanArchWithCQRS.Application.Contracts.Persistance.Common;
using CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos;
using CleanArchWithCQRS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Contracts.Persistance
{
    public interface IPhoneNumberRepository:IBaseRepository<PhoneNumber>
    {
        Task<IReadOnlyList<PhoneNumber>> GetAllStudentPhoneNumber(Guid studentId);
    }
}
