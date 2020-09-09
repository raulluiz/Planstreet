using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.Repository
{
    public class DocumentFolderRepository : BaseRepository<DocumentFolder>, IDocumentFolderRepository
    {
        public DocumentFolderRepository(PlanstreetContext dbContext) : base(dbContext)
        {

        }
    }
}
