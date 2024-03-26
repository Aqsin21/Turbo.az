using Turbo.az.Enums;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az.Entities;

namespace Turbo.az.Models.Entities
{
    public  class Announcement
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int March { get; set; }
        public double Price { get; set; }
        public TypeOfBan Banner { get; set; }
        public TypeofFuel FuelType { get; set; }
        public TypeOfGearBox GearBox { get; set; }
        public TypeOfTransMissions Transmission { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
