﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntidadBase
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
