using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Eleva.Application.DTO;
using Eleva.Domain.Models;

namespace Eleva.Application.AutoMapper
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<School, SchoolDTO>();
            CreateMap<SchoolDTO, School>();
            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<StudentClassDTO, StudentClass>();
            CreateMap<StudentClass, StudentClassDTO>()
                .ForMember(dest => dest.SchoolName, option => option.MapFrom(src => src.School.Name));
        }

    }
}
