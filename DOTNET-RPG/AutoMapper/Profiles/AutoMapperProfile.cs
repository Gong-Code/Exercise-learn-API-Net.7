using AutoMapper;
using DOTNET_RPG.Dtos.Character;
using DOTNET_RPG.Model;

namespace DOTNET_RPG.AutoMapper.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>().ReverseMap();
            CreateMap<AddCharacterDto, Character>().ReverseMap();
            CreateMap<UpdateCharacterDto, Character>().ReverseMap();
        }
    }
}
