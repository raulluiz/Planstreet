using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.Repository
{
    public class DefaultFolderRepository : BaseRepository<DefaultFolder>, IDefaultFolderRepository
    {
        public DefaultFolderRepository(PlanstreetContext dbContext) : base(dbContext)
        {

        }
    }
}
