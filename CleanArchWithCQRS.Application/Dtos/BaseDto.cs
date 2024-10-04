using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Dtos
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
    }
}
