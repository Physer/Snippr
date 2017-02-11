using System.Collections.Generic;
using Snippr.Domain.Models.API;
using Snippr.Domain.Models.Business;

namespace Snippr.Services.Code_snippets
{
    public interface ICodeSnippetService
    {
        void AddCodeSnippet(CodeSnippet codeSnippet);
        void EditCodeSnippet(CodeSnippetEditRequestModel codeSnippetEditRequestModel);
        IEnumerable<CodeSnippet> GetCodeSnippets();
        void RemoveCodeSnippet(CodeSnippet codeSnippet);
    }
}