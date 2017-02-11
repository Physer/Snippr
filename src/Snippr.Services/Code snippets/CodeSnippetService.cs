using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Snippr.Data.Models;
using Snippr.Data.Repositories;
using Snippr.Domain;
using Snippr.Domain.Models.API;
using Snippr.Domain.Models.Business;

namespace Snippr.Services.Code_snippets
{
    public class CodeSnippetService : ICodeSnippetService
    {
        private readonly IElasticRepository _elasticRepository;

        public CodeSnippetService(IElasticRepository elasticRepository)
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

        public void EditCodeSnippet(CodeSnippetEditRequestModel codeSnippetEditRequestModel)
        {
            var existingCodeSnippet = _elasticRepository.Get<CodeSnippetIndexModel>(codeSnippetEditRequestModel.Id);
            if(existingCodeSnippet == null)
                throw new Exception(Constants.ExceptionConstants.NoSnippetFound);

            existingCodeSnippet.Code = codeSnippetEditRequestModel.Code;
            existingCodeSnippet.Author = Mapper.Map<AuthorIndexModel>(codeSnippetEditRequestModel.OriginalAuthor);
            _elasticRepository.Edit(existingCodeSnippet);
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
                Id = x.Id,
                Code = x.Code,
                Upvotes = x.Upvotes
            }));
        }


    }
}
