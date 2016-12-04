using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Snippr.Data.Models;
using Snippr.Data.Repositories;
using Snippr.Domain;
using Snippr.Domain.Models;

namespace Snippr.Services.Codes
{
    public class CodeService : ICodeService
    {
        private readonly IElasticRepository _elasticRepository;

        public CodeService(IElasticRepository elasticRepository)
        {
            _elasticRepository = elasticRepository;
        }

        public void AddCodeSnippet(CodeSnippet codeSnippet)
        {
            if (string.IsNullOrWhiteSpace(codeSnippet.Code))
                throw new ArgumentNullException(Constants.ExceptionConstants.NoCodeSupplied);

            var codeSnippetIndexModel = Mapper.Map<CodeSnippetIndexModel>(codeSnippet);
            _elasticRepository.Add(codeSnippetIndexModel);
        }

        public void RemoveCodeSnippet(CodeSnippet codeSnippet)
        {
            var codeSnippetIndexModel = Mapper.Map<CodeSnippetIndexModel>(codeSnippet);
            _elasticRepository.Delete(codeSnippetIndexModel);
        }

        public IEnumerable<CodeSnippet> GetCodeSnippets()
        {
            var codeIndexModels = _elasticRepository.GetAll<CodeSnippetIndexModel>();
            return new List<CodeSnippet>(codeIndexModels.Select(x => new CodeSnippet
            {
                Code = x.Code,
                Upvotes = x.Upvotes
            }));
        }


    }
}
