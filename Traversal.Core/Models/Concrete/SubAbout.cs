﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class SubAbout : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
