using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos
{
    public class PhoneNumberDto:BaseDto
    {
        public string? Number { get; set; }
        public string? Comment { get; set; }
        public Guid StudentId { get; set; }
    }
}
