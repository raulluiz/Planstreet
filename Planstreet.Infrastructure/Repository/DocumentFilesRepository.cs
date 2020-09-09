using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.Repository
{
    public class DocumentFilesRepository : BaseRepository<DocumentFiles>, IDocumentFilesRepository
    {
        public DocumentFilesRepository(PlanstreetContext dbContext) : base(dbContext)
        {

        }
    }
}
