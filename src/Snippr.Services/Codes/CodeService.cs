using System;
using System.Collections.Generic;
using Snippr.Data.Clients;
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

        private readonly IIndexClient _dataClient;

        public CodeService(IIndexClient dataClient)
        {
            _dataClient = dataClient;
        }

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
            return new List<CodeSnippet>();
            //return _repository.GetMany<CodeSnippet>();
        }
    }
}
