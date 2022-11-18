using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creto.Infrastrucure.AutoMappers
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			//CreateMap<User, UserViewModel>().ForMember(x => x.UserType, x => x.MapFrom(x => x.UserType.ToString()));
			//CreateMap<CreateUserDto, User>().ForMember(x => x.ImageUrl, x => x.Ignore());
			//CreateMap<UpdateUserDto, User>().ForMember(x => x.ImageUrl, x => x.Ignore());
			//CreateMap<User, UpdateUserDto>().ForMember(x => x.Image, x => x.Ignore());




		}
	}
}
