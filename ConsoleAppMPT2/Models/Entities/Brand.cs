using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az.Entities;

namespace Turbo.az.Models.Entities
{
    public class Brand
    {
        

            public int Id { get; set; }
            public string Name { get; set; }

            public DateTime CreatedAt { get; set; }

            public int CreatedBy { get; set; }

            public int? LastModifiedBy { get; set; }

            public DateTime? LastModifiedAt { get; set; }

            public int? DeletedBy { get; set; }

            public DateTime? DeletedAt { get; set; }

        
    }
}
