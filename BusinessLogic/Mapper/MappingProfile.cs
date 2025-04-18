﻿using AppModels;
using AutoMapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TblReportingPoint, ReportingPointModel>();
            CreateMap<ReportingPointModel, TblReportingPoint>();
        }
    }
}
