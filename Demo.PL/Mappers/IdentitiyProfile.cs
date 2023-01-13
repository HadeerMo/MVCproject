using AutoMapper;
using Demo.DAL.Entites;
using Demo.PL.Models;
using Microsoft.AspNetCore.Identity;

namespace Demo.PL.Mappers
{
	public class IdentitiyProfile:Profile
	{
        public IdentitiyProfile()
        {
            CreateMap<ApplicationUser, RegisterViewModel>().ReverseMap();
        }
    }
}
