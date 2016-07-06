namespace TicketingSystem.Web.ViewModels.Comments
{
    using System;
    using AutoMapper;
    using TicketSystem.Web.Infrastructure.Mapping;
    using Models;
    public class CommentViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.AuthorName, opt => opt.MapFrom(c => c.Author.UserName));
        }
    }
}