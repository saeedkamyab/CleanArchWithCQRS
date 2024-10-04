using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Contracts.Persistance.Common
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> Get(Guid id);
        Task<IReadOnlyList<TEntity>> GetAll();//when you use IReadOnlyList change tracker in ef or orms does not track the list because it knows that it won't change  
        Task<TEntity> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);
    }
}
