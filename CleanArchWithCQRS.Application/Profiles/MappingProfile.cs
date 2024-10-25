﻿using AutoMapper;
using CleanArchWithCQRS.Application.Dtos.PhoneNumberDtos;
using CleanArchWithCQRS.Application.Dtos.StudentDtos;
using CleanArchWithCQRS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Application.Profiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            #region student Mapps
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, CreateStudent>().ReverseMap();
            CreateMap<Student, UpdateStudentDto>().ReverseMap();
            CreateMap<Student, ChangeStatusDto>().ReverseMap();
            #endregion

            #region PhoneNumber Mapps
            CreateMap<PhoneNumber, PhoneNumberDto>().ReverseMap();
            
            #endregion

        }
    }
}
