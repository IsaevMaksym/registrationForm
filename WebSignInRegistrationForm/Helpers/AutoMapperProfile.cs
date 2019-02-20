using AutoMapper;
using WebSignInRegistrationForm.Dtos;
using WebSignInRegistrationForm.Model;

namespace WebSignInRegistrationForm.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
