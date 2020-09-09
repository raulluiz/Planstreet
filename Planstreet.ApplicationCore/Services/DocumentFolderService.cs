using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.Services
{
    public class DocumentFolderService : BaseService<DocumentFolder>, IDocumentFolderService
    {
        private readonly IDocumentFolderRepository _documentFolderRepository;
        public DocumentFolderService(IDocumentFolderRepository documentFolderRepository) : base(documentFolderRepository)
        {
            _documentFolderRepository = documentFolderRepository;
        }

    }
}
