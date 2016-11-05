using System.Collections.Generic;
using Snippr.Data.Repositories;
using Snippr.Domain.Models;

namespace Snippr.Services.Codes
{
    public class CodeService : ICodeService
    {
        private readonly IRepository _repository;

        public CodeService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddCodeSnippet(CodeSnippet codeSnippet)
        {
            _repository.Add(codeSnippet);
        }

        public void RemoveCodeSnippet(CodeSnippet codeSnippet)
        {
            _repository.Remove(codeSnippet);
        }

        public IEnumerable<CodeSnippet> GetCodeSnippets()
        {
            return _repository.GetMany<CodeSnippet>();
        }
    }
}
