using System;
using System.Collections.Generic;
using Snippr.Domain;
using Snippr.Domain.Models;

namespace Snippr.Services.Codes
{
    public class CodeService : ICodeService
    {
        //private readonly IRepository _repository;

        //public CodeService(IRepository repository)
        //{
        //    _repository = repository;
        //}

        public void AddCodeSnippet(CodeSnippet codeSnippet)
        {
            if (string.IsNullOrWhiteSpace(codeSnippet.Code))
                throw new ArgumentNullException(Constants.ExceptionConstants.NoCodeSupplied);

            //_repository.Add(codeSnippet);
            //_repository.SaveChanges();
        }

        public void RemoveCodeSnippet(CodeSnippet codeSnippet)
        {
            //_repository.Remove(codeSnippet);
        }

        public IEnumerable<CodeSnippet> GetCodeSnippets()
        {
            throw new NotImplementedException();
            //return _repository.GetMany<CodeSnippet>();
        }
    }
}
