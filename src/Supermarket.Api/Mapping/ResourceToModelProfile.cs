using AutoMapper;
using Supermarket.Api.Domain.Models;
using Supermarket.Api.Resources;

namespace Supermarket.Api.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
