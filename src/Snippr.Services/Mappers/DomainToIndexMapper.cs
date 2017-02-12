using AutoMapper;
using Snippr.Data.Models;
using Snippr.Domain.Models.Business;

namespace Snippr.Services.Mappers
{
    public class DomainToIndexMapper : Profile
    {
        public DomainToIndexMapper()
        {
            CreateMap<Author, AuthorIndexModel>()
                .ForMember(output => output.Id, input => input.Ignore())
                ;

            CreateMap<Category, CategoryIndexModel>()
                .ForMember(output => output.Id, input => input.Ignore())
                ;

            CreateMap<CodeSnippet, CodeSnippetIndexModel>()
                .ForMember(output => output.Id, input => input.MapFrom(src => src.Id))
                .ForMember(output => output.Code, input => input.MapFrom(src => src.Code))
                .ForMember(output => output.Upvotes, input => input.MapFrom(src => src.Upvotes))
                .ForMember(output => output.Author, input => input.Ignore())
                .ForMember(output => output.Categories, input => input.Ignore())
                ;

            CreateMap<Comment, CommentIndexModel>()
                .ForMember(output => output.Id, input => input.Ignore())
                ;

            CreateMap<User, UserIndexModel>()
                .ForMember(output => output.Id, input => input.MapFrom(src => src.Id))
                .ForMember(output => output.Username, input => input.MapFrom(src => src.Username))
                .ForMember(output => output.EmailAddress, input => input.MapFrom(src => src.EmailAddress))
                .ForMember(output => output.HashedPassword, input => input.MapFrom(src => src.HashedPassword))
                ;
        }
    }
}
