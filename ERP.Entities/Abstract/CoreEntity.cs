﻿using ERP.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Abstract
{
    public class CoreEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedIP { get; set; }
        public string? ModifiedIP { get; set; }
    }
}
