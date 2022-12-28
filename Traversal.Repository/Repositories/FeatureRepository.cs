﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Concrete;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.Repositories
{
    public class FeatureRepository : GenericRepository<Feature>
    {
        public FeatureRepository(TraversalContext context) : base(context)
        {
        }
    }
}
