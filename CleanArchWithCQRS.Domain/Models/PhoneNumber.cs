using CleanArchWithCQRS.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Domain.Models
{
    public class PhoneNumber:BaseEntity
    {
        public string?  Number { get; set; }
        public string? Comment { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Guid StudentId { get; set; }
      //  public Student? Student { get; set; }

    }
}
