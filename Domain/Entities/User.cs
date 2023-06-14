using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Phone { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Gender Gender { get; set; }
    }
}
