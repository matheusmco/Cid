using AutoMapper;
using Cid.Domain.DTOs;
using Cid.Domain.Models;

namespace Cid.Service.Config
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Item, ItemDTO>();
        }
    }
}