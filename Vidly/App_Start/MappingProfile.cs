using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //*IMPORTANT: The variables should be same fro mapping , else it wont work

            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            //This is required to avoid the exception of "cannot change the id property"
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c=>c.Id, opt=>opt.Ignore());

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}