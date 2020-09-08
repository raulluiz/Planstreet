using Planstreet.ApplicationCore.Entities;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.Services
{
    public class DefaultFolderService : BaseService<DefaultFolder>, IDefaultFolderService
    {
        private readonly IDefaultFolderRepository _defaultFolderRepository;
        public DefaultFolderService(IDefaultFolderRepository defaultFolderRepository) : base(defaultFolderRepository)
        {
            _defaultFolderRepository = defaultFolderRepository;
        }

    }
}
