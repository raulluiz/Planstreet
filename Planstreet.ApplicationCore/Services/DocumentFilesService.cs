using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.Services
{
    public class DocumentFilesService : BaseService<DocumentFiles>, IDocumentFilesService
    {
        private readonly IDocumentFilesRepository _documentFilesRepository;
        public DocumentFilesService(IDocumentFilesRepository documentFilesRepository) : base(documentFilesRepository)
        {
            _documentFilesRepository = documentFilesRepository;
        }

    }
}
