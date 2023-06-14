using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SocialMediaBase
    {
        public Guid Id { get; set; }
        public Uri Link { get; set; }
        public Guid NetworkTypeId { get; set; }
        public NetworkType? NetworkType { get; set; }
    }
}
