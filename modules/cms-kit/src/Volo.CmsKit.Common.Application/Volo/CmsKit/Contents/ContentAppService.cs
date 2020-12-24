﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.CmsKit.Common.Application.Contracts.Volo.CmsKit.Contents;

namespace Volo.CmsKit.Contents
{
    public class ContentAppService : CmsKitAppServiceBase, IContentAppService
    {
        private readonly IContentRepository _contentRepository;

        public ContentAppService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<ContentDto> GetAsync(GetContentInput input)
        {
            var entity = await _contentRepository.FindAsync(
                input.EntityType,
                input.EntityId,
                CurrentTenant.Id);

            return ObjectMapper.Map<Content, ContentDto>(entity);
        }
    }
}
