using System.Collections.Generic;
using Snippr.Domain.Models;

namespace Snippr.Services.Codes
{
    public interface ICodeService
    {
        void AddCodeSnippet(CodeSnippet codeSnippet);
        IEnumerable<CodeSnippet> GetCodeSnippets();
        void RemoveCodeSnippet(CodeSnippet codeSnippet);
    }
}