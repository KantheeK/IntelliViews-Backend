﻿using AutoMapper;
using IntelliViews.API.DTOs;
using IntelliViews.Data.DataModels;


namespace IntelliViews.API.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            // Mapping profile for the ApplicationUser:
            CreateMap<InRegisterDTO, ApplicationUser>();
            CreateMap<ApplicationUser, OutRegisterDTO>();
            CreateMap<InAuthDTO, ApplicationUser>();
           

        }
    }
}